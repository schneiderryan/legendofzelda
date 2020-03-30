using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class BoomerangProjectile :  Projectile
    {
        public override double Damage => 0.5;
        public bool Returned => state is PocketBoomerangState;

        public IBoomerangState state;
        public Point finalPosition;
        public string direction;
        public readonly int velocity;
        public ICharacter source;

        public BoomerangProjectile(string direction, ICharacter source, int velocity = 5)
            : base(direction, source.X, source.Y, velocity)
        {
            OwningTeam = source.Team;
            sprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
            sprite.Position = new Point(X, Y);
            Hitbox = sprite.Box;
            this.direction = direction;
            this.velocity = velocity;
            this.source = source;
            state = new PocketBoomerangState(this);
        }

        public override void Update()
        {
            state.Update();
            base.Update();
        }

        public void BeginReturning()
        {
            if (state is ThrownBoomerangState)
            {
                state = new HoveringBoomerangState(this);
            }
        }

    }
}
