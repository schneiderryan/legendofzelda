using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
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
        private Texture2D HUD;
        private Texture2D HUDBackground;
        private string direction;
        public ChangeRoomState(String direction, LegendOfZelda game)
        {
            this.HUD = Textures.GetHUD();
            this.HUDBackground = Textures.GetHUDBackground();
            this.background = Textures.GetRoomSheet();
            this.direction = direction;
            x = game.xRoom;
            y = game.yRoom;
            if (direction == "left" || direction == "right")
            {
                this.timer = 257 / 2;
            }
            else
            {
                this.timer = 177 / 2;
            }
            this.game = game;
            if (game.link.Inventory.HasClock)
            {
                game.link = (game.link as DamagedLink).InnerLink;
                game.link.Inventory.HasClock = false;
            }
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
            
            //game.soundEffects[0].Play();
            if (timer == 0)
            {
                this.PlayGame();
            }
            game.rooms[game.roomIndex].background = RoomSpriteFactory.Instance.CreateRooms(game.xRoom, game.yRoom);
            if (direction == "up")
            {
                if (timer > 0)
                {
                    game.yRoom -= 2;
                    timer--;
                }
                else
                {
                    if (game.roomIndex == 1 || game.roomIndex == 3 || game.roomIndex == 11)
                    {
                        game.roomIndex += 2;
                    }
                    else if (game.roomIndex == 8 || game.roomIndex == 9)
                    {
                        game.roomIndex += 3;
                    }
                    else if (game.roomIndex == 4 || game.roomIndex == 5 || game.roomIndex == 6)
                    {
                        game.roomIndex += 4;
                    }
                    else if (game.roomIndex == 12)
                    {
                        game.roomIndex += 5;
                    }

                    game.rooms[game.roomIndex].Update();
                    this.PlayGame();
                }
            }
            else if (direction == "down")
            {
                if (timer > 0)
                {
                    game.yRoom += 2;
                    timer--;
                }
                else
                {
                    if (game.roomIndex == 3 || game.roomIndex == 5 || game.roomIndex == 13)
                    {
                        game.roomIndex -= 2;
                    }

                    else if (game.roomIndex == 12)
                    {
                        game.roomIndex -= 3;
                    }
                    else if (game.roomIndex == 8 || game.roomIndex == 9 || game.roomIndex == 10)
                    {
                        game.roomIndex -= 4;
                    }
                    else if (game.roomIndex == 12 || game.roomIndex == 17)
                    {
                        game.roomIndex -= 5;
                    }
                    game.rooms[game.roomIndex].Update();
                    this.PlayGame();

                }
            }
            else if (direction == "left")
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
                    game.rooms[game.roomIndex].Update();
                    this.PlayGame();

                }
            }
            else
            {
                if (timer > 0)
                {

                    game.xRoom += 2;
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
                    game.rooms[game.roomIndex].Update();
                    this.PlayGame();

                }
            }



        }

        public void Draw()
        {
            game.rooms[game.roomIndex].background.Draw(game.spriteBatch, Color.White);
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 512, 120), Color.Black);
            game.spriteBatch.Draw(HUD, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.White);

        }
    }
}