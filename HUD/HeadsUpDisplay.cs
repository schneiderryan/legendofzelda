﻿using Microsoft.Xna.Framework;
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
        private HUDMap hudmap;
        private Texture2D itemSheet = Textures.GetItemSheet();
        private HUDCurrentItem hudcurrentitem;
        public int offset;

        public HeadsUpDisplay(LegendOfZelda game)
        {
            this.game = game;
            hudhearts = new HUDHearts(this.game);
            hudbombs = new HUDCounter(this.game, "bombs");
            hudkeys = new HUDCounter(this.game, "keys");
            hudrupees = new HUDCounter(this.game, "rupees");
            hudmap = new HUDMap(this.game);
            hudcurrentitem = new HUDCurrentItem(this.game);
            if (game.state.ToString().Equals("LegendOfZelda.InventoryState"))
            {
                offset = 360;
            }
            else
            {
                offset = 0;
            }
        }
        
        public void Update()
        {
            hudhearts.Update();
            hudbombs.Update();
            hudkeys.Update();
            hudrupees.Update();
            hudmap.Update();
            hudcurrentitem.Update();

        }

        public void Draw()
        {
            hudhearts.Draw();
            hudbombs.Draw();
            hudkeys.Draw();
            hudrupees.Draw();
            hudmap.Draw();
            hudcurrentitem.Draw();
            game.spriteBatch.Draw(itemSheet, new Rectangle(305, offset + 55, 14, 32), new Rectangle(104, 0, 8, 16), Color.White);
            //game.spriteBatch.Draw(itemSheet, new Rectangle(257, 55, 14, 32), new Rectangle(136, 0, 8, 16), Color.White);

            
        }
    }
}
