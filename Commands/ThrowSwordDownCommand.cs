using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class ThrowSwordDownCommand : ICommand
    {
        private LegendOfZelda game1;

        public ThrowSwordDownCommand(LegendOfZelda game1)
        {
            this.game1 = game1;
        }
        
        public void Execute()
        {
            game1.sword.ThrowDown(new Vector2());
        }
    }
}
