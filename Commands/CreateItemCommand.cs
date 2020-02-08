using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class CreateItemCommand : ICommand
    {
        private LegendOfZelda game1;

        public CreateItemCommand(LegendOfZelda game1)
        {
            this.game1 = game1;
        }
        
        public void Execute()
        {
            game1.sword.ThrowRight(new Vector2());
        }
    }
}
