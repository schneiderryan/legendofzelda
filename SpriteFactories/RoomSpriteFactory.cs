using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{ 
    class RoomSpriteFactory
    {
        private Texture2D roomSheet = Textures.GetRoomSheet();
        private Texture2D dungeonSheet = Textures.GetDungeonSheet();
        private static RoomSpriteFactory instance = new RoomSpriteFactory();

        private RoomSpriteFactory() {
            
        }

        public static RoomSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public ISprite CreateRoom0()
        {
            return new Sprite(roomSheet, new Rectangle(258, 886, 256, 176));
        }

        public ISprite CreateRightOpenDoor()
        {
            return new Sprite(dungeonSheet, new Rectangle(848, 77, 32, 32));
        }

        public ISprite CreateLeftWall()
        {
            return new Sprite(dungeonSheet, new Rectangle(815, 44, 32, 32));
        }

        public ISprite CreateRoom1()
        {
            return new Sprite(roomSheet, new Rectangle(515, 886, 256, 176));
        }
    }
    
}
