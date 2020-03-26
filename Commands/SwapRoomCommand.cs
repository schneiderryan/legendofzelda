using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class SwapRoomCommand : ICommand
    {
        private LegendOfZelda game;
        private string swapDirection;

        public SwapRoomCommand(LegendOfZelda game, string direction)
        {
            this.game = game;
            this.swapDirection = direction;
        }
        
        public void Execute()
        {
            if (swapDirection.Equals("next"))
            {
                if (game.rooms.Count - 1 == game.roomIndex)
                {
                    game.roomIndex = 0;
                }
                else
                {
                    game.roomIndex++;
                }
            }
            else if (swapDirection.Equals("previous"))
            {
                if (0 == game.roomIndex)
                {
                    game.roomIndex = game.rooms.Count - 1;
                }
                else
                {
                    game.roomIndex--;
                }
            }
            else if (swapDirection.Equals("up"))
            {
                System.Diagnostics.Debug.WriteLine("walk through top door");
                if (game.roomIndex == 2 || game.roomIndex == 4 ||  game.roomIndex == 12)
                {
                    game.roomIndex += 2;
                }
                else if(game.roomIndex == 9)
                {
                    game.roomIndex += 3;
                }
                else if(game.roomIndex == 5 || game.roomIndex == 6 || game.roomIndex == 7)
                {
                    game.roomIndex += 4;
                }
                else if(game.roomIndex == 13)
                {
                    game.roomIndex += 5;
                }
            }
            else if (swapDirection.Equals("down"))
            {
                System.Diagnostics.Debug.WriteLine(game.roomIndex);
                System.Diagnostics.Debug.WriteLine("walk through bottomdoor");

                if (game.roomIndex == 4 || game.roomIndex == 6 || game.roomIndex == 14)
                {
                    game.roomIndex -= 2;
                }
               
                
                else if (game.roomIndex == 13)
                {
                    game.roomIndex -= 3;
                }
                else if (game.roomIndex == 9 || game.roomIndex == 10 || game.roomIndex == 11)
                {
                    game.roomIndex -= 4;
                }
                else if (game.roomIndex == 13 || game.roomIndex == 18)
                {
                    game.roomIndex -= 5;
                }
                
            }
            game.projectiles.Clear();
            game.effects.Clear();
            System.Diagnostics.Debug.WriteLine("switching rooms");
        }
    }
}
