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
				goriya.ThrowBoomerang(goriya.xPos, goriya.yPos);
				goriya.boomerangTimer++;
			}
			goriya.yPos -= 1;
			if (goriya.yPos < 0)
			{
				goriya.yPos += 480;
			}
			
			goriya.sprite.Position = new Point(goriya.xPos, goriya.yPos);
		}


	}
}