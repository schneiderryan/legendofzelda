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
        private int offset;
        public HUDCurrentItem(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Update()
        {
            this.item = game.link.HeldItem;
            this.offset = game.hud.offset;
        }

        public void Draw()
        {
            if (this.item != null)
            {
                this.item.X = 257;
                this.item.Y = offset + 55;
                this.item.Draw(game.spriteBatch, Color.White);
            }
        }
    }
}
