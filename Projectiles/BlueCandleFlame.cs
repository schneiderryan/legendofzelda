using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class BlueCandleFlame : Projectile
    {
        int timer;

        public bool Done => timer < 0;

        public BlueCandleFlame(int x = 0, int y = 0)
            : base(x, y, 0, 0, Team.Link)
        {
            sprite = DespawnEffectSpriteFactory.GetBlueCandleFlame();
            X = x;
            Y = y;
            timer = 60;
            Hitbox = sprite.Box;
        }

        public override double Damage => 1;

        public override void Update()
        {
            base.Update();
            timer--;
        }
    }
}
