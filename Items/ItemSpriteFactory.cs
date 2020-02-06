using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public static class ItemSpriteFactory
    {
        public static ISprite GetHeart()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(144, 0, 8, 16));
        }

        public static ISprite GetHeartContainer()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(25, 1, 13, 13));
        }

        public static ISprite GetFairy()
        {
            return new AnimatedSprite(Textures.GetItemsSheet(),
                    new Rectangle(29, 34, 8, 16), 2);
        }

        public static ISprite GetRupee()
        {
            return new AnimatedSprite(Textures.GetItemsSheet(),
                    new Rectangle(61, 34, 8, 16), 2);
        }

        public static ISprite GetBlueRupee()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(61, 34, 8, 16));
        }

        public static ISprite GetSword()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(104, 0, 7, 16));
        }

        public static ISprite GetBomb()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(136, 0, 8, 14));
        }

        public static ISprite GetExplodingBomb()
        {
            return new AnimateOnceSprite(Textures.GetEffectsSheet(),
                new Rectangle(138, 203, 16, 16), 4)
            {
                AnimationDelay = 20
            };
        }

        public static ISprite GetBoomerang()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(129, 3, 5, 8));
        }

        public static ISprite GetBow()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(144, 0, 8, 16));
        }

        public static ISprite GetArrow()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(154, 0, 5, 16));
        }

        public static ISprite GetMap()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(88, 0, 8, 16));
        }

        public static ISprite GetCompass()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(258, 1, 11, 12));
        }

        public static ISprite GetKey()
        {
            return new Sprite(Textures.GetItemsSheet(),
                    new Rectangle(240, 0, 8, 16));
        }

        public static ISprite GetTriforceShard()
        {
            return new AnimatedSprite(Textures.GetItemsSheet(),
                    new Rectangle(95, 34, 10, 10), 2);
        }
    }
}
