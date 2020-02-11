using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


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
			//nothing to do 
		}

		public void MoveRight()
		{
			//goriya.state = new MovingRightGoriyaState(link);
			//goriya.sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
		}


		public void MoveLeft()
		{
			//goriya.state = new MovingLeftGoriyaState(link);
			//goriya.sprite = EnemySpriteFactory.Instance.CreateLeftMovingGoriyaSprite();
		}

		public void Update()
		{

		}


	}
}