using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class RightMovingGoriyaState : IEnemyState
	{
		private Goriya goriya;

		public RightMovingGoriyaState(Goriya goriya)
		{
			this.goriya = goriya;
		}


		public void ChangeDirection()
		{
			//trap.state = new RightMovingGoriyaState(trap);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//trap.state = new KilledEnemyState(trap);
		}

		public void MoveUp()
		{
			goriya.state = new UpMovingGoriyaState(goriya);
			goriya.sprite = EnemySpriteFactory.Instance.CreateUpMovingGoriyaSprite();
		}

		public void MoveDown()
		{
			goriya.state = new DownMovingGoriyaState(goriya);
			goriya.sprite = EnemySpriteFactory.Instance.CreateDownMovingGoriyaSprite();
		}

		public void MoveRight()
		{
			
		}


		public void MoveLeft()
		{
			goriya.state = new LeftMovingGoriyaState(goriya);
			goriya.sprite = EnemySpriteFactory.Instance.CreateLeftMovingGoriyaSprite();
		}

		public void TakeDamage()
		{

		}
		public void Update()
		{
			goriya.boomerangTimer++;
			if (goriya.boomerangTimer == 250)
			{
				goriya.ThrowBoomerang(goriya.X, goriya.Y, 4, 0);
				goriya.boomerangTimer = 0;
			}

			goriya.X += 1;
			if (goriya.X > 800)
			{
				goriya.X -= 800;
			}
			goriya.sprite.Position = new Point(goriya.X, goriya.Y);
		}


	}
}