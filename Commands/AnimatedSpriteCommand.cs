using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class AnimatedSpriteCommand : StaticSpriteCommand
    {

        public AnimatedSpriteCommand(Game1 game1) : base(game1)
        {
            Point center = this.sprite.Position;
            sprite = new AnimatedSprite(game1.SpriteSheet, new Rectangle(-4, 52, 30, 30), 2)
            {
                Position = center,
                Scale = 4
            };
        }
    }
}
