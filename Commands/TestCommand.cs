using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class TestCommand : ICommand
    {
        private LegendOfZelda game1;

        public TestCommand(LegendOfZelda game1)
        {
            this.game1 = game1;
        }
        
        public void Execute()
        {
            game1.testItem.ThrowRight(new Vector2(100, 100));
        }
    }
}
