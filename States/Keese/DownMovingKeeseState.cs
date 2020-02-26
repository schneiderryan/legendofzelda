using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;
using System;

namespace LegendOfZelda
{

	class DownMovingKeeseState : IKeeseState
	{
		private Keese keese;

		public DownMovingKeeseState(Keese keese)
		{
			this.keese = keese;
		}


		public void ChangeDirection()
		{
			//keese.state = new RightMovingkeeseState(keese);
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
			//nothing to do 
		}

		public void MoveRight()
		{
			keese.state = new RightMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateRightMovingKeeseSprite();
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
			keese.Y += 1;
			if (direction == 1)
			{
				keese.X -= 1;
			}
			else if (direction == 2)
			{
				keese.X += 1;
			}
			if (keese.X > 800)
			{
				keese.X -= 800;
			}
			if (keese.X < 0)
			{
				keese.X += 800;
			}
			if (keese.Y > 480)
			{
				keese.Y -= 480;
			}
			keese.sprite.Position = new Point(keese.X, keese.Y);
		}


	}
}