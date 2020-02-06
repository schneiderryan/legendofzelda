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


        public CreateItemCommand(Game1 game1)
        {
            this.game1 = game1;
        }
        

        public void Execute()
        {
            game1.bomb.Detonate();
        }
    }
}
