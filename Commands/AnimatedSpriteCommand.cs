using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class AnimatedSpriteCommand : StaticSpriteCommand
    {
        public AnimatedSpriteCommand(Game1 game1) : base(game1)
        {
            Point center = this.sprite.Position;
            this.sprite = new AnimatedSprite(game1.SpriteSheet, new Rectangle(241, 0, 15, 15), 3)
            {
                Position = center,
                Scale = 4
            };
        }
    }
}
