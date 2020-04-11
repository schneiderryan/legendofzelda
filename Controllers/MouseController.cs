using Microsoft.Xna.Framework.Input;


namespace LegendOfZelda
{
    class MouseController : IController
    {
        int delay;
        LegendOfZelda game;

        public MouseController(LegendOfZelda game)
        {
            delay = 0;
            this.game = game;
        }
        public void Update()
        {
            delay++;

            MouseState state = Mouse.GetState();
            if (state.LeftButton.HasFlag(ButtonState.Pressed) & (delay > 30))
            {
                delay = 0;
            }
            if (state.RightButton.HasFlag(ButtonState.Pressed) & (delay > 30))
            {
                delay = 0;
            }

        }
    }
}