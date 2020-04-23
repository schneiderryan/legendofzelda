using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class StairRoomState : IGameState
    {
        private LegendOfZelda game;
        private Color tint;
        private int tintTimer;
        private Stairs.StairDirection direction;
        private Texture2D HUDBackground;
        private bool changed;

        public StairRoomState(LegendOfZelda game, Stairs.StairDirection direction)
        {
            this.changed = false;
            this.direction = direction;
            this.game = game;
            this.tint = Color.White;
            this.tintTimer = 0;
            this.HUDBackground = Textures.GetHUDBackground();
        }

        public void ToStart()
        {
            //Nothing to do
        }

        public void NewGame()
        {
            //nothing to do
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
            //Nothing to do
        }

        public void SelectMode()
        {
            //Do nothing
        }

        public void OpenInventory()
        {
            //Nothing to do
        }

        public void CloseInventory()
        {
            //Nothing to do
        }
        public void ChangeRoom()
        {
            //Nothing to do
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
            if (tintTimer < 10)
            {
                tint = Color.Gray;
            }
            else if (tintTimer < 20)
            {
                tint = Color.DarkSlateGray;
            }
            else if (tintTimer < 30)
            {
                tint = Color.Black;
                if (direction == Stairs.StairDirection.Down && !changed)
                {
                    changed = true;
                    game.roomIndex--;
                    game.xRoom -= 256;
                    game.Link.X = 94;
                    game.Link.Y = 124;
                    game.rooms[game.roomIndex].Update();
                }
                else if (direction == Stairs.StairDirection.Up && !changed)
                {
                    changed = true;
                    game.roomIndex++;
                    game.xRoom += 256;
                    game.Link.X = 6 * RoomParser.TILE_SIZE;
                    game.Link.Y = 7 * RoomParser.TILE_SIZE + 120;
                    game.rooms[game.roomIndex].Update();
                }
            }

            else if (tintTimer < 40)
            {
                tint = Color.DarkSlateGray;
            }
            else if (tintTimer < 50)
            {
                tint = Color.Gray;
            }
            else
            {
                tint = Color.White;
                this.PlayGame();
            }

            tintTimer++;
        }

        public void Draw()
        {
            game.rooms[game.roomIndex].Draw(game.spriteBatch, tint);
            game.spriteBatch.Draw(HUDBackground, new Rectangle(0, 0, 512, 120), new Rectangle(0, 0, 512, 120), Color.Black);
            game.Link.Draw(game.spriteBatch, Color.White);
            if (game.currentMode.Equals("hard"))
            {
                game.cone.Draw(game.spriteBatch);
            }
        }
    }
}
