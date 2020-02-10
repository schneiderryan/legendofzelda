using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class CreateSwordCommand : ICommand
    {
        private LegendOfZelda game1;

        public CreateSwordCommand(LegendOfZelda game1)
        {
            this.game1 = game1;
        }
        
        public void Execute()
        {
            WoodSword sword = new WoodSword();
            sword.BeOnGround();
            game1.items.Add(sword);
        }
    }
}
