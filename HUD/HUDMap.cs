using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class HUDMap
    {
        private LegendOfZelda game;
        private Texture2D map = Textures.GetMap();
        private Texture2D bigMap = Textures.GetMapTransparent();
        private ISprite whiteBox = FontSpriteFactory.GetWhiteBox();
        private ISprite bigWhiteBox = FontSpriteFactory.GetWhiteBox();
        private ISprite compassBox = MiscSpriteFactory.Instance.CreateCompassSelector();
        private ISprite bigCompassBox = MiscSpriteFactory.Instance.CreateCompassSelector();
        private int offset;
        private int[] locations;
        private int currentDelay;
        private int totalDelay;
        private int bigOffsetX;
        private int bigOffsetY;


        public HUDMap(LegendOfZelda game)
        {
            this.game = game;
            bigOffsetX = 140;
            bigOffsetY = 105;
            int[] locations = { 
                68, 90,  //room0
                84, 90,  //room1
                101, 90, //room2
                84, 82,  //room3
                68, 73,  //room4
                84, 73,  //room5
                101, 73, //room6
                52, 65,  //room7
                68, 65,  //room8
                84, 65,  //9
                101, 65, //10
                118,65,  //11
                84,57,   //12
                118,57,  //13
                135,57,  //14
                68,49,   //15
                0, 0, // place holder for room 16
                84,59 }; //17
            compassBox.X = locations[28];
            compassBox.Y = locations[29] + offset;
            bigCompassBox.X = locations[28] * 2 + bigOffsetX;
            bigCompassBox.Y = locations[29] * 2 + bigOffsetY;
            bigCompassBox.Scale = 3;
            this.locations = locations;
            currentDelay = 0;
            totalDelay = 5;
        }

        public void Update()
        {
            currentDelay++;
            if (currentDelay == totalDelay)
            {
                compassBox.Update();
                bigCompassBox.Update();
                currentDelay = 0;
            }
            compassBox.X = locations[28];
            compassBox.Y = locations[29] + offset;
            offset = game.hud.offset;
            whiteBox = MoveThatBox(whiteBox, game, offset, locations, false);
            bigWhiteBox = MoveThatBox(bigWhiteBox, game, offset, locations, true);
        }

        public void Draw()
        {
            if (game.Link.Inventory.HasMap)
            {
                game.spriteBatch.Draw(map, new Rectangle(45, offset + 47, 100, 48), new Rectangle(0, 0, 94, 46), Color.White);
                
            }
            if (game.Link.Inventory.HasCompass)
            {
                compassBox.Draw(game.spriteBatch);
            }
            whiteBox.Draw(game.spriteBatch);
            if (game.state.ToString().Equals("LegendOfZelda.InventoryState"))
            {
                if (game.Link.Inventory.HasMap)
                {
                    game.spriteBatch.Draw(bigMap, new Rectangle(230, 200, 200, 96), new Rectangle(0, 0, 94, 46), Color.White);
                }
                if (game.Link.Inventory.HasCompass)
                {
                    bigCompassBox.Draw(game.spriteBatch);
                }
                bigWhiteBox.Draw(game.spriteBatch);
            }
        }

        private static ISprite MoveThatBox(ISprite sprite, LegendOfZelda game, int offset, int[] locations, bool isBig)
        {
            int bigOffsetX = 140;
            int bigOffsetY = 105;
            ISprite temp = sprite;
            if (!isBig)
            {
                temp.X = locations[game.roomIndex * 2];
                temp.Y = locations[game.roomIndex * 2 + 1];
                temp.Y += offset;
            } else
            {
                temp.Scale = 4;
                temp.X = locations[game.roomIndex * 2] * 2 + bigOffsetX;
                temp.Y = locations[game.roomIndex * 2 + 1] * 2 + bigOffsetY;
            }
            
            
            return temp;
        }
    }
}
