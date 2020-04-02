﻿

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
            game.ProjectileManager.Clear();
            System.Diagnostics.Debug.WriteLine("switching rooms");
        }
    }
}
