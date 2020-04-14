using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;

namespace LegendOfZelda
{
	class Goriya : RandomMovingEnemy
	{
		public string direction;

		private int boomerangTimer;
		private bool canThrowBoomerang;
		private BoomerangProjectile boomerang;
		private ICollection<IProjectile> projectiles;
		private const int THROW_DELAY = 250;

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
			boomerangTimer = new Random().Next(180, THROW_DELAY);
			boomerang = new BoomerangProjectile(direction, this);
			currentHearts = 3;
		}

		public override void Update()
		{
			if (canThrowBoomerang)
			{
				boomerangTimer++;
				if (boomerangTimer >= THROW_DELAY)
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
			Util.CenterRelativeToEdge(Sprite.Box, direction, boomerang);
			projectiles.Add(boomerang);
			boomerang.Update();
			canThrowBoomerang = false;
		}

	}
}
