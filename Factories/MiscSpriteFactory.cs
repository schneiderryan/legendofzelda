using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class MiscSpriteFactory
    {
        private static MiscSpriteFactory instance = new MiscSpriteFactory();
        private Texture2D menu = Textures.GetStartMenu();
        private Texture2D BWRoom = Textures.GetBWRoom();
        private Texture2D WinCurtain = Textures.GetWinCurtain();
        private Texture2D hudcontents = Textures.GetHUDContents();
        private MiscSpriteFactory() { }
        public static MiscSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public ISprite CreateStartMenu()
        {

            return new AnimatedSprite(menu, new Rectangle(0, 0, 197, 191), 4, false);
        }

        public ISprite CreateBWRoom()
        {
            return new Sprite(BWRoom, new Rectangle(0, 0, BWRoom.Width, BWRoom.Height));
        }

        public ISprite CreateWinCurtain()
        {
            return new Sprite(WinCurtain, new Rectangle(0, 0, WinCurtain.Width, WinCurtain.Height));
        }

        public ISprite CreateStory()
        {
            return new Sprite(menu, new Rectangle(523, 20, 252, 960));
        }

        public ISprite CreateLife()
        {
            return new Sprite(hudcontents, new Rectangle(440, 25, 51, 11));
        }
    }
}