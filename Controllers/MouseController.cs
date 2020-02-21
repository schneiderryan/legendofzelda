using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LegendOfZelda
{
    class MouseController : IController
    {
        ICommand cmdLeft;
        ICommand cmdRight;
        int delay;

        public MouseController(LegendOfZelda game)
        {
            delay = 0;
            cmdLeft = new SwapRoomCommand(game, "next");
            cmdRight = new SwapRoomCommand(game, "previous");

        }
        public void Update()
        {
            delay++;

            MouseState state = Mouse.GetState();
            if (state.LeftButton.HasFlag(ButtonState.Pressed) & (delay > 30))
            {
                delay = 0;
                cmdLeft.Execute();
            }
            if (state.RightButton.HasFlag(ButtonState.Pressed) & (delay > 30))
            {
                delay = 0;
                cmdRight.Execute();
            }

        }
    }
}