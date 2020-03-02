using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PocketBoomerangState : IBoomerangState
    {
        private BoomerangProjectile boom;

        public PocketBoomerangState(BoomerangProjectile boom)
        {
            this.boom = boom;
            boom.Returned = true;
        }

        public void Update()
        {
            SetTurnAroundPoint(boom.direction);
            boom.state = new ThrownBoomerangState(boom);
        }

        private void SetTurnAroundPoint(string direction)
        {
            if (direction == "up")
            {
                boom.finalPosition = new Point(boom.X, boom.Y - 144);
            }
            else if (direction == "down")
            {
                boom.finalPosition = new Point(boom.X, boom.Y + 144);
            }
            else if (direction == "right")
            {
                boom.finalPosition = new Point(boom.X + 144, boom.Y);
            }
            else // left
            {
                boom.finalPosition = new Point(boom.X - 144, boom.Y);
            }
        }

    }
}
