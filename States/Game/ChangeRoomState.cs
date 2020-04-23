using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class ChangeRoomState : IGameState
    {
        private LegendOfZelda game;
        private int timer;
        private Texture2D HUD;
        private Texture2D HUDBackground;
        private string direction;
        private IPlayer player;

        public ChangeRoomState(string direction, IPlayer player, LegendOfZelda game)
        {
            this.HUD = Textures.GetHUD();
            this.HUDBackground = Textures.GetHUDBackground();
            this.direction = direction;
            if (direction == "left" || direction == "right")
            {
                this.timer = 257 / 2;
            }
            else
            {
                this.timer = 177 / 2;
            }
            this.game = game;
            this.player = player;
            player.Inventory.BlueCandle.UsedInRoom = false;
            if (player.Inventory.HasClock)
            {
                this.player = (player as DamagedLink).InnerLink;
                game.rooms[game.roomIndex].Players[player.ID] = this.player;
                this.player.Inventory.HasClock = false;
                game.rooms[game.roomIndex].FreezeEnemies = false;
            }
            game.rooms[game.roomIndex].Players.Remove(player.ID);
            game.ProjectileManager.Clear();
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

        public void OpenInventory()
        {
            //Nothing to do
        }

        public void CloseInventory()
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

        public void SelectMode()
        {
            //Do nothing
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
            game.rooms[game.roomIndex].background = RoomSpriteFactory.Instance.CreateRooms(game.xRoom, game.yRoom);
            if (direction == "up")
            {
                if (timer > 0)
                {
                    game.yRoom -= 2;
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
                }
            }
            else if (direction == "down")
            {
                if (timer > 0)
                {
                    game.yRoom += 2;
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
                }
            }
            else if (direction == "left")
            {
                if (timer > 0)
                {
                    game.xRoom -= 2;
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
                }
            }
            else
            {
                if (timer > 0)
                {
                    game.xRoom += 2;
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
                }
            }

            if (timer == 0)
            {
                game.rooms[game.roomIndex].Players.Add(player.ID, player);
                game.rooms[game.roomIndex].Update();
                this.PlayGame();
            }
            timer--;
        }

        public void Draw()
        {
            game.rooms[game.roomIndex].background.Draw(game.spriteBatch, Color.White);
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 512, 120), Color.Black);
            game.spriteBatch.Draw(HUD, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.White);
        }
    }
}
