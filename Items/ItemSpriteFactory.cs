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
    }
}
