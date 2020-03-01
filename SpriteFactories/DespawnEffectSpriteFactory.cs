using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    static class DespawnEffectSpriteFactory
    {
        private static Texture2D sheet = Textures.GetLinkSheet();
        private const int DELAY = 3;

        public static ISprite SwordSpriteUpperRight()
        {
            return new AnimatedSprite(sheet, new Rectangle(158, 282, 8, 10), 3)
                { AnimationDelay = DELAY };
        }

        public static ISprite SwordSpriteUpperLeft()
        {
            return new AnimatedSprite(sheet, new Rectangle(150, 282, 8, 10), 3)
                { AnimationDelay = DELAY };
        }

        public static ISprite SwordSpriteLowerRight()
        {
            return new AnimatedSprite(sheet, new Rectangle(158, 293, 8, 10), 3)
                { AnimationDelay = DELAY };
        }

        public static ISprite SwordSpriteLowerLeft()
        {
            return new AnimatedSprite(sheet, new Rectangle(150, 293, 8, 10), 3)
                { AnimationDelay = DELAY };
        }
    }
}
