using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class BreathingAqumentusState : AquamentusState
	{
		private int openMouth = 0;

		public BreathingAqumentusState(Aquamentus aquamentus) : base(aquamentus)
        {
            aquamentus.Sprite = EnemySpriteFactory.Instance.CreateMovingFireAquamentusSprite();
			aquamentus.Sprite.Position = new Point(aquamentus.X, aquamentus.Y);
			BreathFire();
        }

		public override void Update()
		{
			base.Update();
			openMouth++;
			if (openMouth > 20)
			{
				aquamentus.State = new NotBreathingAquamentusState(aquamentus);
			}
		}

		private void BreathFire()
		{
			IPlayer target = Util.FindClosestPlayer(aquamentus.Center, aquamentus.players);
			Vector2 v = Util.VelocityVectorToTarget(target.Center,
					aquamentus.Hitbox.Location, 3.5f);
			float shiftV = 1.25f;

			aquamentus.projectiles.Add(new FireballProjectile(aquamentus.X, aquamentus.Y, v.X, v.Y));
			v.Y -= shiftV;
			aquamentus.projectiles.Add(new FireballProjectile(aquamentus.X, aquamentus.Y, v.X, v.Y));
			v.Y += 2 * shiftV;
			aquamentus.projectiles.Add(new FireballProjectile(aquamentus.X, aquamentus.Y, v.X, v.Y));
		}
	}
}
