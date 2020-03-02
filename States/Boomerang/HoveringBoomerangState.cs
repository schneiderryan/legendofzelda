

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
            if (hoverTimer > 0)
            {
                boom.state = new ReturningBoomerangState(boom);
            }
        }
    }
}
