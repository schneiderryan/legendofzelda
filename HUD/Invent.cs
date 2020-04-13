using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class Invent
    {
        private LegendOfZelda game;
        private InventIcons icons;
        public Invent(LegendOfZelda game)
        {
            this.game = game;
            this.icons = new InventIcons(game);
        }

        public void Update()
        {
            //Nothing to do
        }

        public void Draw()
        {
            icons.Draw();
        }
    }
}
