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
			if (VY > 0)
			{
				if (direction == 1)
				{
					X -= 1;
				}
				else if (direction == 2)
				{
					X += 1;
				}
			}
			else
			{
				if (direction == 1)
				{
					Y -= 1;
				}
				else if (direction == 2)
				{
					Y += 1;
				}
			}
			base.Update();
		}

	}
}