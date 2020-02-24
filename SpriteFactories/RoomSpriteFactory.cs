using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{ 
    class RoomSpriteFactory
    {
        private Texture2D roomSheet = Textures.GetRoomSheet();
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
    
        public ISprite CreateRoom1()
        {
            return new Sprite(roomSheet, new Rectangle(515, 886, 256, 176));
        }

        public ISprite CreateRoom2()
        {
            return new Sprite(roomSheet, new Rectangle(772, 886, 256, 176));
        }

        public ISprite CreateRoom3()
        {
            return new Sprite(roomSheet, new Rectangle(515, 709, 256, 176));
        }

        public ISprite CreateRoom4()
        {
            return new Sprite(roomSheet, new Rectangle(258, 532, 256, 176));
        }

        public ISprite CreateRoom5()
        {
            return new Sprite(roomSheet, new Rectangle(515, 532, 256, 176));
        }

        public ISprite CreateRoom6()
        {
            return new Sprite(roomSheet, new Rectangle(772, 532, 256, 176));
        }

        public ISprite CreateRoom7()
        {
            return new Sprite(roomSheet, new Rectangle(1, 355, 256, 176));
        }

        public ISprite CreateRoom8()
        {
            return new Sprite(roomSheet, new Rectangle(258, 355, 256, 176));
        }

        public ISprite CreateRoom9()
        {
            return new Sprite(roomSheet, new Rectangle(515, 355, 256, 176));
        }

        public ISprite CreateRoom10()
        {
            return new Sprite(roomSheet, new Rectangle(772, 355, 256, 176));
        }

        public ISprite CreateRoom11()
        {
            return new Sprite(roomSheet, new Rectangle(1029, 355, 256, 176));
        }

        public ISprite CreateRoom12()
        {
            return new Sprite(roomSheet, new Rectangle(515, 178, 256, 176));
        }
        public ISprite CreateRoom13()
        {
            return new Sprite(roomSheet, new Rectangle(1029, 178, 256, 176));
        }

        public ISprite CreateRoom14()
        {
            return new Sprite(roomSheet, new Rectangle(1286, 178, 256, 176));
        }

        public ISprite CreateRoom15()
        {
            return new Sprite(roomSheet, new Rectangle(258, 1, 256, 176));
        }

        public ISprite CreateRoom16()
        {
            return new Sprite(roomSheet, new Rectangle(515, 1, 256, 176));
        }
    }
    
}
