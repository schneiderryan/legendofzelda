using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint0
{
    public class MouseController : IController
    {
        private ICommand[][] grid;
        private Viewport viewport;
        private ICommand quitCommand;

        public MouseController(Game1 game1)
        {
            this.viewport = game1.GraphicsDevice.Viewport;
            grid = new ICommand[2][]
            {
                new ICommand[2]
                {
                    new StaticSpriteCommand(game1),
                    new MoveSpriteCommand(game1)
                },
                new ICommand[2]
                {
                    new AnimatedSpriteCommand(game1),
                    new DancingSpriteCommand(game1)
                }
            };
            quitCommand = new QuitCommand(game1);
        }
        public void Update()
        {
            MouseState state = Mouse.GetState();
            if (state.LeftButton.HasFlag(ButtonState.Pressed))
            {
                int x = 2 * state.Position.X / viewport.Width;
                int y = 2 * state.Position.Y / viewport.Height;
                grid[x][y].Execute();
            }
            if (state.RightButton.HasFlag(ButtonState.Pressed))
            {
                quitCommand.Execute();
            }

        }
    }
}
