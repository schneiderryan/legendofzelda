using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda

{

	class DownMovingGoriyaState : IGoriyaState
	{
		private Goriya goriya;

		public DownMovingGoriyaState(Goriya goriya)
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
			//nothing to do 
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
			goriya.yPos += 1;
			if (goriya.yPos > 480)
			{
				goriya.yPos -= 480;
			}
			goriya.sprite.Position = new Point(goriya.xPos, goriya.yPos);
		}


	}
}