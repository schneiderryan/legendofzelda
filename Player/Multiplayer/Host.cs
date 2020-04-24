using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net.Sockets;
using System.Net;


namespace LegendOfZelda
{
    class Host : IUpdateable, IDisposable
    {
        UdpClient relayServer;
        UpdateState state;
        LegendOfZelda game;
        IDictionary<int, int> playerRooms;

        public Host(LegendOfZelda game)
        {
            this.game = game;
            relayServer = new UdpClient("localhost", 81);
            IPEndPoint end = new IPEndPoint(IPAddress.Any, 81);
            state = new UpdateState(relayServer, end);
            playerRooms = new Dictionary<int, int>();
        }

        private static void HandleReceive(IAsyncResult result)
        {
            UpdateState state = result.AsyncState as UpdateState;
            IPEndPoint end = state.Endpoint;
            byte[] data = state.Udp.EndReceive(result, ref end);
            JsonSerializer.Deserialize(Encoding.ASCII.GetString(data), Type.GetType("PlayerInfo"));
            state.Ready = true;
        }

        private static void HandleSend(IAsyncResult result)
        {
            // do nothing
        }

        public void Update()
        {
            if (state.Ready)
            {
                // do update
                // send player position & state
                // send updated room info
                foreach (KeyValuePair<int, int> pair in playerRooms)
                {
                    int playerID = pair.Key;
                    int roomID = pair.Value;
                    PlayerInfo player = new PlayerInfo(game.rooms[game.roomIndex].Players[playerID]);
                    string data = JsonSerializer.Serialize(player);
                    relayServer.Send(Encoding.ASCII.GetBytes(data), data.Length);
                }
            }
            else
            {
                relayServer.BeginReceive(new AsyncCallback(HandleReceive), state);
            }

            // client only control player movement
            // host handle collisions

            // move projectiles to be in room
        }

        public void Dispose()
        {
            state.Udp.Dispose();
        }
    }
}
