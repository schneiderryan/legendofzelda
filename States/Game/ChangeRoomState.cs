using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class ChangeRoomState : IGameState
    {
        private static Texture2D HUD = Textures.GetHUD();
        private static Texture2D HUDBackground = Textures.GetHUDBackground();

        private LegendOfZelda game;
        private int timer;
        private string direction;
        private IPlayer player;
        private Color tint = Color.White;

        public ChangeRoomState(string direction, IPlayer player, LegendOfZelda game)
        {
            this.direction = direction;
            if (direction == "left" || direction == "right")
            {
                this.timer = 257 / 2;
            }
            else if (direction == "up" || direction == "down")
            {
                this.timer = 177 / 2;
            }
            else
            {
                this.timer = 60;
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
            game.rooms[game.roomIndex].Players.Add(player.ID, player);
            game.rooms[game.roomIndex].Update();
            if (game.currentMode.Equals("hard"))
            {
                game.cone.Update();
            }
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

        public void CloseItemShop()
        {
            //
        }

        public void OpenItemShop()
        {
            //
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
            if (game.currentMode.Equals("puzzle"))
            {
                game.rooms[game.roomIndex].background = RoomSpriteFactory.Instance.CreatePuzzleRooms(game.xRoom, game.yRoom);
                if (direction == "up")
                {
                    if (timer > 0)
                    {
                        game.yRoom -= 2;
                    }
                    else
                    {
                        if (game.roomIndex == 0 || game.roomIndex == 1 || game.roomIndex == 2 || game.roomIndex == 3 || game.roomIndex == 6 || game.roomIndex == 7 || game.roomIndex == 8 || game.roomIndex == 11)
                        {
                            game.roomIndex += 4;
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
                        if (game.roomIndex == 4 || game.roomIndex == 5 || game.roomIndex == 6 || game.roomIndex == 7 || game.roomIndex == 10 || game.roomIndex == 11 || game.roomIndex == 13 || game.roomIndex == 16)
                        {
                            game.roomIndex -= 4;
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
                        if (2 == game.roomIndex || game.roomIndex == 5 || game.roomIndex == 10 || game.roomIndex == 16 || game.roomIndex == 15 || game.roomIndex == 14 || game.roomIndex == 9)
                        {
                            game.roomIndex--;
                        }
                    }
                }
                else if (direction == "right")
                {
                    if (timer > 0)
                    {
                        game.xRoom += 2;
                    }
                    else
                    {
                        if (1 == game.roomIndex || 4 == game.roomIndex || 8 == game.roomIndex || 9 == game.roomIndex || 13 == game.roomIndex || 14 == game.roomIndex || 15 == game.roomIndex)
                        {
                            game.roomIndex++;
                        }
                    }
                }
                else // stairup & stairdown
                {
                    if (timer > 50)
                    {
                        tint = Color.Gray;
                    }
                    else if (timer > 40)
                    {
                        tint = Color.DarkSlateGray;
                    }
                    else if (timer > 30)
                    {
                        tint = Color.Black;
                        if (direction == "stairdown" && timer == 39)
                        {
                            game.roomIndex--;
                            game.xRoom -= 256;
                            player.X = 94;
                            player.Y = 124;
                        }
                        else if (direction == "stairup" && timer == 39)
                        {
                            game.roomIndex++;
                            game.xRoom += 256;
                            player.X = 6 * RoomParser.TILE_SIZE;
                            player.Y = 7 * RoomParser.TILE_SIZE + 120;
                        }
                    }
                    else if (timer > 20)
                    {
                        tint = Color.DarkSlateGray;
                    }
                    else if (timer > 10)
                    {
                        tint = Color.Gray;
                    }
                    else
                    {
                        tint = Color.White;
                    }
                }

                if (timer == 0)
                {
                    this.PlayGame();
                }
                timer--;
            }

            else 
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
                else if (direction == "right")
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
                else // stairup & stairdown
                {
                    if (timer > 50)
                    {
                        tint = Color.Gray;
                    }
                    else if (timer > 40)
                    {
                        tint = Color.DarkSlateGray;
                    }
                    else if (timer > 30)
                    {
                        tint = Color.Black;
                        if (direction == "stairdown" && timer == 39)
                        {
                            game.roomIndex--;
                            game.xRoom -= 256;
                            player.X = 94;
                            player.Y = 124;
                        }
                        else if (direction == "stairup" && timer == 39)
                        {
                            game.roomIndex++;
                            game.xRoom += 256;
                            player.X = 6 * RoomParser.TILE_SIZE;
                            player.Y = 7 * RoomParser.TILE_SIZE + 120;
                        }
                    }
                    else if (timer > 20)
                    {
                        tint = Color.DarkSlateGray;
                    }
                    else if (timer > 10)
                    {
                        tint = Color.Gray;
                    }
                    else
                    {
                        tint = Color.White;
                    }
                }

                if (timer == 0)
                {
                    this.PlayGame();
                }
                timer--;

            }
            
        }

        public void Draw()
        {
            if (direction == "stairup" || direction == "stairdown")
            {
                player.Draw(game.spriteBatch, Color.White);
                game.rooms[game.roomIndex].Draw(game.spriteBatch, tint);
                if (game.currentMode.Equals("hard"))
                {
                    game.cone.Draw(game.spriteBatch);
                }
            }
            else
            {
                if (game.currentMode.Equals("hard"))
                {
                    game.rooms[game.roomIndex].background.Draw(game.spriteBatch, Color.Black);
                }
                else
                {
                    game.rooms[game.roomIndex].background.Draw(game.spriteBatch, tint);
                }
            }
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 512, 120), Color.Black);
            game.spriteBatch.Draw(HUD, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 256, 56), Color.White);
        }
    }
}
