using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class MoveSpriteCommand : StaticSpriteCommand
    {
        public MoveSpriteCommand(Game1 game1) : base(game1)
        {
            Viewport viewport = game1.GraphicsDevice.Viewport;
            Point centerTop = new Point(this.sprite.Position.X, 0);
            IPath path = new LineLoop(centerTop, new Point(viewport.Height - 56), new Vector2(0, 3));
            this.sprite = new MovingSprite(game1.SpriteSheet, new Rectangle(0, 16, 14, 14), path)
            {
                Scale = 4
            };
        }
    }
}
