using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ChangeRoomState : IGameState
    {
        private LegendOfZelda game;
        private int timer;
        private int x;
        private int y;
        private Texture2D background;
        private string direction;
        public ChangeRoomState(String direction, LegendOfZelda game)
        {

            this.background = Textures.GetRoomSheet();
            this.direction = direction;
            x = game.xRoom;
            y = game.yRoom;
            if(direction == "left" || direction == "right")
            {
                this.timer = 257 / 2;
            }
            else
            {
                this.timer = 177 / 2;
            }

            
            this.game = game;

        }

        public void ToStart()
        {
            //Nothing to do
        }

        public void NewGame()
        {
            //Nothing to do
        }

        public void PlayGame()
        {
            game.state = new PlayState(game);
        }

        public void PauseGame()
        {
            //Nothing to do
        }

        public void ResumeGame()
        {
            game.state = new PlayState(game);
        }

        public void ChangeRoom()
        {

            if (game.link is DamagedLink && game.link.Inventory.HasClock)
            {
                game.link.Inventory.HasClock = false;
                game.link = (game.link as DamagedLink).InnerLink;
            }

        }

        public void WinGame()
        {
            //Nothing to do
        }

        public void LoseGame()
        {
            //Nothing to do
        }

        public void SelectItem()
        {
            //Nothing to do
        }

        public void Update()
        {
            if (timer == 0)
            {
               
                this.PlayGame();
            }
            game.rooms[game.roomIndex].background = RoomSpriteFactory.Instance.CreateRooms(game.xRoom, game.yRoom);
            if (direction == "up")
            {
                if (timer > 0)
                {
                    game.yRoom-=2;
                    timer--;
                }
                else
                {
                    if (game.roomIndex == 2 || game.roomIndex == 4 || game.roomIndex == 12)
                    {
                        game.roomIndex += 2;
                    }
                    else if (game.roomIndex == 9 || game.roomIndex == 10)
                    {
                        game.roomIndex += 3;
                    }
                    else if (game.roomIndex == 5 || game.roomIndex == 6 || game.roomIndex == 7)
                    {
                        game.roomIndex += 4;
                    }
                    else if (game.roomIndex == 13)
                    {
                        game.roomIndex += 5;
                    }

                    timer = 0;
                    this.PlayGame();
                }
            }
            else if(direction == "down")
            {
                if (timer > 0)
                {
                    game.yRoom+=2;
                    timer--;
                }
                else
                {
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
                    timer = 0;
                    
                }
            }
            else if(direction == "left")
            {
                if (timer > 0)
                {
                    game.xRoom -= 2;
                    timer--;
                }
                else
                {
                    if (0 == game.roomIndex)
                    {
                        game.roomIndex = game.rooms.Count - 1;
                    }
                    else
                    {
                        game.roomIndex--;
                    }
                    timer = 0;
                } 
            }
            else
            {
                if (timer > 0)
                {
                    game.xRoom+=2;
                    timer--;
                }
                else
                {
                    if (game.rooms.Count - 1 == game.roomIndex)
                    {
                        game.roomIndex = 0;
                    }
                    else
                    {
                        game.roomIndex++;
                    }
                    timer = 0;
                    
                }
            }
            


        }

        public void Draw()
        {
            game.rooms[game.roomIndex].background.Draw(game.spriteBatch, Color.White);
            
        }
    }
}
