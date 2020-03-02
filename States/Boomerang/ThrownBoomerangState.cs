using System;


namespace LegendOfZelda
{
    class ThrownBoomerangState : IBoomerangState
    {
        private BoomerangProjectile boom;

        public ThrownBoomerangState(BoomerangProjectile boom)
        {
            this.boom = boom;
        }

        public void Update()
        {
            if (Math.Abs(boom.finalPosition.X - boom.X) <= Math.Abs(boom.VX)
                    && Math.Abs(boom.finalPosition.Y - boom.Y) <= Math.Abs(boom.VY))
            {
                boom.state = new HoveringBoomerangState(boom);
            }
        }
    }
}
