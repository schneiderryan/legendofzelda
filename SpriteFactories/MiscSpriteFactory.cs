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
    }
}
