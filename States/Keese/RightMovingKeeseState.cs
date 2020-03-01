using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;
using System;

namespace LegendOfZelda
{

	class RightMovingKeeseState : IEnemyState
	{
		private Keese keese;

		public RightMovingKeeseState(Keese keese)
		{
			this.keese = keese;
		}


		public void ChangeDirection()
		{
			//keese.state = new RightMovingKeeseState(keese);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//keese.state = new KilledEnemyState(keese);
		}

		public void MoveUp()
		{
			keese.state = new UpMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateUpMovingKeeseSprite();
		}

		public void MoveDown()
		{
			keese.state = new DownMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateDownMovingKeeseSprite();
		}

		public void MoveRight()
		{
			
		}


		public void MoveLeft()
		{
			keese.state = new LeftMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateLeftMovingKeeseSprite();
		}

		public void Update()
		{
			Random random = new Random();
			int direction = random.Next(0, 3);
			keese.X += 1;
			if (direction == 1)
			{
				keese.Y -= 1;
			}
			else if (direction == 2)
			{
				keese.Y += 1;
			}
			
			if (keese.Y < 0)
			{
				keese.Y += 480;
			}
			if (keese.Y > 480)
			{
				keese.Y -= 480;
			}

			if (keese.X > 800)
			{
				keese.X -= 800;
			}
			keese.sprite.Position = new Point(keese.X, keese.Y);
		}


	}
}