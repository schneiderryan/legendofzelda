using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;
using System;

namespace LegendOfZelda
{

	class UpMovingKeeseState : IEnemyState
	{
		private Keese keese;

		public UpMovingKeeseState(Keese keese)
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
			//nothing
		}

		public void MoveDown()
		{
			keese.state = new DownMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateDownMovingKeeseSprite();
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
			keese.Y -= 1;
			if (direction==1)
			{ 
				keese.X -= 1;
			}
			else if(direction ==2)
			{				
				keese.X += 1;
			}
			if (keese.Y < 0)
			{
				keese.Y += 480;
			}
			if (keese.X > 800)
			{
				keese.X -= 800;
			}
			if (keese.X < 0)
			{ 
				keese.X += 800;
			}
			
			keese.sprite.Position = new Point(keese.X, keese.Y);
		}


	}
}