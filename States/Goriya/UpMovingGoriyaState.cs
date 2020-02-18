using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{

	class UpMovingGoriyaState : IGoriyaState
	{
		private Goriya goriya;
		


		public UpMovingGoriyaState(Goriya goriya)
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
			//nothing
		}

		public void MoveDown()
		{
			goriya.state = new DownMovingGoriyaState(goriya);
			goriya.sprite = EnemySpriteFactory.Instance.CreateDownMovingGoriyaSprite();
		}

		public void MoveRight()
		{
			goriya.state = new RightMovingGoriyaState(goriya);
			goriya.sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
		}


		public void MoveLeft()
		{
			goriya.state = new LeftMovingGoriyaState(goriya);
			goriya.sprite = EnemySpriteFactory.Instance.CreateLeftMovingGoriyaSprite();
		}

		public void Update()
		{
			goriya.boomerangTimer++;
			if(goriya.boomerangTimer == 30)
			{
				goriya.ThrowBoomerang(goriya.X, goriya.Y);
				goriya.boomerangTimer++;
			}
			goriya.Y -= 1;
			if (goriya.Y < 0)
			{
				goriya.Y += 480;
			}
			
			goriya.sprite.Position = new Point(goriya.X, goriya.Y);
		}


	}
}