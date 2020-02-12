using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;

namespace LegendOfZelda
{
    public class StaticSpriteCommand : ICommand
    {
        protected LegendOfZelda game1;
        protected ISprite sprite;

        public StaticSpriteCommand(LegendOfZelda game1)
        {
            this.game1 = game1;
            Viewport viewport = game1.GraphicsDevice.Viewport;
            Point center = new Point(viewport.Width / 2 - 30, viewport.Height / 2 - 30);
            this.sprite = new Sprite(game1.EnemySpriteSheet, new Rectangle(0, 0, 15, 15))
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
