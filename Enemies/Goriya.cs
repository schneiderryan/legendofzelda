using Microsoft.Xna.Framework;
using System.Collections.Generic;

using static LegendOfZelda.BoomerangProjectile;


namespace LegendOfZelda
{
	class Goriya : RandomMovingEnemy
	{
		public string direction;

		private int boomerangTimer;
		private BoomerangState boomerangState;
		private BoomerangProjectile boomerang;
		private IList<IProjectile> projectiles;

		public Goriya(LegendOfZelda game)
		{
			this.projectiles = game.projectiles;
			Sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
			direction = "right";
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new RightMovingGoriyaState(this);
			boomerangState = BoomerangState.Pocket;
			currentHearts = 2;
		}

		public override void Update()
		{
			if (boomerangState == BoomerangState.Pocket)
			{
				boomerangTimer++;
				if (boomerangTimer == 250)
				{
					ThrowBoomerang();
					boomerangTimer = 0;
				}
				base.Update();
			}
			Sprite.Update();
		}

		private void ThrowBoomerang()
		{
			boomerang = new BoomerangProjectile(direction, this);
			projectiles.Add(boomerang);
			boomerangState = BoomerangState.Thrown;
		}



	}
}
