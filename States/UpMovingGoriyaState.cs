using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
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
			//goriya.state = new RightMovingGoriyaState(goriya);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//goriya.state = new KilledEnemyState(goriya);
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
			goriya.yPos -= 1;
			if (goriya.yPos < 0)
			{
				goriya.yPos += 480;
			}
			
			goriya.sprite.Position = new Point(goriya.xPos, goriya.yPos);
		}


	}
}