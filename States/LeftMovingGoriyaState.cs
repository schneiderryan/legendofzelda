using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
{

	class LeftMovingGoriyaState : IGoriyaState
	{
		private Goriya goriya;

		public LeftMovingGoriyaState(Goriya goriya)
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
			goriya.state = new RightMovingGoriyaState(goriya);
			goriya.sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
		}


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			goriya.xPos -= 1;
			if (goriya.xPos < 0)
			{
				goriya.xPos += 800;
			}
			goriya.sprite.Position = new Point(goriya.xPos, goriya.yPos);
		}


	}
}