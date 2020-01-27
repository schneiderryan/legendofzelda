using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class StaticSpriteCommand : ICommand
    {
        protected Game1 game1;
        protected ISprite sprite;

        public StaticSpriteCommand(Game1 game1)
        {
            this.game1 = game1;
            Viewport viewport = game1.GraphicsDevice.Viewport;
            Point center = new Point(viewport.Width / 2 - 30, viewport.Height / 2 - 30);
            this.sprite = new Sprite(game1.SpriteSheet, new Rectangle(210, 0, 15, 15))
            {
                Position = center,
                Scale = 4
            };
        }

        public virtual void Execute()
        {
            if (game1.Sprite != sprite)
                game1.Sprite = sprite;
        }
    }
}
