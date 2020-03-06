using Microsoft.Xna.Framework;
using System;

namespace LegendOfZelda
{
	class Keese : RandomMovingEnemy
	{
		private Random random;
		public Keese()
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingKeeseSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			random = new Random();
			currentHearts = 1;
		}

		public override void Update()
		{
			int direction = random.Next(0, 3);
			int velocity = random.Next(0, 3);
			if (VY > 0)
			{
				if (direction == 1)
				{
					X -= velocity;
				}
				else if (direction == 2)
				{
					X += velocity;
				}
			}
			else
			{
				if (direction == 1)
				{
					Y -= velocity;
				}
				else if (direction == 2)
				{
					Y += velocity;
				}
			}
			base.Update();
		}

	}
}