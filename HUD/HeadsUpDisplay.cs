using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class HeadsUpDisplay
    {
        private LegendOfZelda game;
        private HUDHearts hudhearts;
        private HUDCounter hudbombs;
        private HUDCounter hudkeys;
        private HUDCounter hudrupees;
        private Texture2D itemSheet = Textures.GetItemSheet();
        private IItem currentItem;



        public HeadsUpDisplay(LegendOfZelda game)
        {
            this.game = game;
            hudhearts = new HUDHearts(this.game);
            hudbombs = new HUDCounter(this.game, "bombs");
            hudkeys = new HUDCounter(this.game, "keys");
            hudrupees = new HUDCounter(this.game, "rupees");
        }
        
        public void Update()
        {
            hudhearts.Update();
            hudbombs.Update();
            hudkeys.Update();
            hudrupees.Update();
        }

        public void Draw()
        {
            hudhearts.Draw();
            hudbombs.Draw();
            hudkeys.Draw();
            hudrupees.Draw();
            game.spriteBatch.Draw(itemSheet, new Rectangle(305, 55, 14, 32), new Rectangle(104, 0, 8, 16), Color.White);
            game.spriteBatch.Draw(itemSheet, new Rectangle(257, 55, 14, 32), new Rectangle(136, 0, 8, 16), Color.White);
        }
    }
}
