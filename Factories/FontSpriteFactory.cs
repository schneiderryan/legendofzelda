using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public static class FontSpriteFactory
    {
        public static ISprite GetX()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(16, 32, 7, 7));
        }

        public static ISprite Get0()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(0, 0, 7, 7));
        }

        public static ISprite Get1()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(18, 0, 7, 7));
        }

        public static ISprite Get2()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(32, 0, 7, 7));
        }

        public static ISprite Get3()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(48, 0, 7, 7));
        }

        public static ISprite Get4()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(64, 0, 7, 7));
        }

        public static ISprite Get5()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(80, 0, 7, 7));
        }

        public static ISprite Get6()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(96, 0, 7, 7));
        }

        public static ISprite Get7()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(112, 0, 7, 7));
        }

        public static ISprite Get8()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(128, 0, 7, 7));
        }

        public static ISprite Get9()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(144, 0, 7, 7));
        }

        public static ISprite GetWhiteBox()
        {
            return new Sprite(Textures.GetFonts(),
                    new Rectangle(96, 17, 2, 2));
        }

        public static ISprite GetP()
        {
            return new Sprite(Textures.GetTransparentFonts(),
                    new Rectangle(144, 16, 7, 7));
        }

        public static ISprite GetA()
        {
            return new Sprite(Textures.GetTransparentFonts(),
                    new Rectangle(160, 0, 7, 7));
        }

        public static ISprite GetU()
        {
            return new Sprite(Textures.GetTransparentFonts(),
                    new Rectangle(224, 16, 7, 7));
        }

        public static ISprite GetS()
        {
            return new Sprite(Textures.GetTransparentFonts(),
                    new Rectangle(192, 16, 7, 7));
        }

        public static ISprite GetE()
        {
            return new Sprite(Textures.GetTransparentFonts(),
                    new Rectangle(224, 0, 7, 7));
        }

        public static ISprite GetD()
        {
            return new Sprite(Textures.GetTransparentFonts(),
                    new Rectangle(208, 0, 7, 7));
        }

        public static ISprite GetModeScreen()
        {

            return new Sprite(Textures.GetSelectModeScreen(),
                    new Rectangle(0, 0, 108, 68))
            {
                Scale = 4
            };
        }

        public static ISprite GetSuddenDeathMessage()
        {
            return new Sprite(Textures.GetSuddenDeathMessage(),
                    new Rectangle(0, 0, 47, 16));
        }
    }
}
