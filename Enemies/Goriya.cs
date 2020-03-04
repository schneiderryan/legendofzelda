using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
	class Goriya : RandomMovingEnemy
	{
		public string direction;

		private int boomerangTimer;
		private bool canThrowBoomerang;
		private BoomerangProjectile boomerang;
		private ICollection<IProjectile> projectiles;

		public Goriya(ICollection<IProjectile> projectiles)
		{
			this.projectiles = projectiles;
			Sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
			direction = "right";
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new RightMovingGoriyaState(this);
			canThrowBoomerang = true;
			boomerang = new BoomerangProjectile(direction, this);
			currentHearts = 2;
			attackTimer = 50;
		}

		public override void Update()
		{
			if (canThrowBoomerang)
			{
				boomerangTimer++;
				if (boomerangTimer == 250)
				{
					ThrowBoomerang();
					boomerangTimer = 0;
				}
				base.Update();
			}
			else
			{
				// if count = 0 then the room got cleared
				canThrowBoomerang = boomerang.Returned || projectiles.Count == 0;
				Sprite.Update();
			}
		}

		private void ThrowBoomerang()
		{
			boomerang = new BoomerangProjectile(direction, this);
			Projectile.CenterProjectile(Sprite.Box, direction, boomerang);
			projectiles.Add(boomerang);
			canThrowBoomerang = false;
		}

	}
}
