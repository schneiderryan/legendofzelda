using System;


namespace LegendOfZelda
{
    class HoveringBoomerangState : IBoomerangState
    {
        private const int HOVER_TIME = 10;
        private int hoverTimer;
        private BoomerangProjectile boom;

        public HoveringBoomerangState(BoomerangProjectile boom)
        {
            this.boom = boom;
            hoverTimer = -HOVER_TIME;
        }

        public void Update()
        {
            hoverTimer = (hoverTimer + 1) % HOVER_TIME;
            if (hoverTimer < -HOVER_TIME / 2)
            {
                boom.VX = boom.VX == 0 ? 0 : 2 * Math.Sign(boom.VX);
                boom.VY = boom.VY == 0 ? 0 : 2 * Math.Sign(boom.VY);
            }
            else if (hoverTimer < 0)
            {
                boom.VX = boom.VX == 0 ? 0 : -2 * Math.Sign(boom.VX);
                boom.VY = boom.VY == 0 ? 0 : -2 * Math.Sign(boom.VY);
            }
            else
            {
                boom.state = new ReturningBoomerangState(boom);
            }
        }
    }
}
