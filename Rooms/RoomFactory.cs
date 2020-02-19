using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{ 
    class RoomFactory
    {
        private Texture2D roomSheet = Textures.GetRoomSheet();
        private static RoomFactory instance = new RoomFactory();

        private RoomFactory() {
            
        }

        public static RoomFactory Instance
        {
            get
            {
                return instance;
            }
        }
            
    public IRoom CreateRoom2()
        {
            return new Room(roomSheet, new Rectangle(258, 886, 256, 176));
        }
    }
    
}
