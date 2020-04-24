using System.Net.Sockets;
using System.Net;


namespace LegendOfZelda
{
    class UpdateState
    {
        public bool Ready { get; set; }
        public UdpClient Udp { get; private set; }
        public IPEndPoint Endpoint { get; private set; }

        public UpdateState(UdpClient udp, IPEndPoint end)
        {
            Ready = false;
            Udp = udp;
            Endpoint = end;
        }
    }
}
