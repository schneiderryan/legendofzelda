using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class DancingSpriteCommand : StaticSpriteCommand
    {
        public DancingSpriteCommand(Game1 game1) : base(game1)
        {
            Viewport viewport = game1.GraphicsDevice.Viewport;
            Point leftCenter = new Point(0, this.sprite.Position.Y);
            Point rightCenter = new Point(viewport.Width - 60, leftCenter.Y);
            IPath path = new LineLoop(leftCenter, rightCenter, new Vector2(3, 0));
            this.sprite = new DancingSprite(game1.SpriteSheet, new Rectangle(241, 0, 15, 15), 3, path)
            {
                Scale = 4
            };
        }
    }
}
