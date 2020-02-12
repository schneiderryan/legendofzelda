using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public class AnimatedSpriteCommand : StaticSpriteCommand
    {

        public AnimatedSpriteCommand(LegendOfZelda game1) : base(game1)
        {
            Point center = this.sprite.Position;
            sprite = new AnimatedSprite(game1.EnemySpriteSheet, new Rectangle(-4, 52, 30, 30), 2, false)
            {
                Position = center,
                Scale = 4
            };
        }
    }
}
