using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class CreateItemCommand : ICommand
    {

        private Game1 game1;
        private Item item;
        private SpriteBatch spriteBatch;
        private ISprite sprite;


        public CreateItemCommand(Game1 game1, SpriteBatch spriteBatch)
        {
            this.game1 = game1;
            Viewport viewport = game1.GraphicsDevice.Viewport;
            Point center = new Point(viewport.Width / 2 - 30, viewport.Height / 2 - 30);
            this.spriteBatch = spriteBatch;
            this.sprite = game1.Sprite;
        }
        

        public void Execute()
        {
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            item = new Arrow();
            game1.Arrow = item;
            sprite = item.getSprite();
            sprite.Draw(spriteBatch);
            spriteBatch.End();

        }
    }
}
