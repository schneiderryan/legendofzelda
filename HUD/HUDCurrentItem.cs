using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class HUDCurrentItem
    {
        private LegendOfZelda game;
        private IItem item;
        public HUDCurrentItem(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Update()
        {
            this.item = game.link.HeldItem;
        }

        public void Draw()
        {
            if (this.item != null)
            {
                this.item.X = 257;
                this.item.Y = 55;
                this.item.Draw(game.spriteBatch, Color.White);
            }
        }
    }
}
