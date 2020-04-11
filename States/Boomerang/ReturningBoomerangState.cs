using System;


namespace LegendOfZelda
{
    class ReturningBoomerangState : IBoomerangState
    {
        BoomerangProjectile boom;
        public ReturningBoomerangState(BoomerangProjectile boom)
        {
            this.boom = boom;
        }

        public void Update()
        {
            int dx = boom.source.Center.X - boom.Hitbox.Center.X;
            int dy = boom.source.Center.Y - boom.Hitbox.Center.Y;

            boom.VX = (Math.Abs(dx) > boom.Hitbox.Width) ?
                Util.SignOrZero(dx) * (boom.velocity - Math.Abs(boom.VY) / 2)
                :
                0;

            boom.VY = (Math.Abs(dy) > boom.Hitbox.Height) ?
                Util.SignOrZero(dy) * (boom.velocity - Math.Abs(boom.VX) / 2)
                :
                0;

            if (boom.VX == 0 && boom.VY == 0)
            {
                boom.state = new PocketBoomerangState(boom);
            }
        }
    }
}
