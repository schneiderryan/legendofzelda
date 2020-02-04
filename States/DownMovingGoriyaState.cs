﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
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