using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class DownMovingRFWallmasterState : IWallmasterState
	{
		private RFWallmaster lfwallmaster;

		public DownMovingRFWallmasterState(RFWallmaster lfwallmaster)
		{
			this.lfwallmaster = lfwallmaster;
		}


		public void ChangeDirection()
		{
			//lfwallmaster.state = new RightMovingRFWallmasterState(lfwallmaster);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//lfwallmaster.state = new KilledEnemyState(lfwallmaster);
		}

		public void MoveUp()
		{
			lfwallmaster.state = new UpMovingRFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateUpMovingRFWallmasterSprite();
		}

		public void MoveDown()
		{
			//nothing to do 
		}

		public void MoveRight()
		{
			lfwallmaster.state = new RightMovingRFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateRightMovingRFWallmasterSprite();
		}


		public void MoveLeft()
		{
			lfwallmaster.state = new LeftMovingRFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateLeftMovingRFWallmasterSprite();
		}

		public void Update()
		{
			lfwallmaster.yPos += 1;
			if (lfwallmaster.yPos > 480)
			{
				lfwallmaster.yPos -= 480;
			}
			lfwallmaster.sprite.Position = new Point(lfwallmaster.xPos, lfwallmaster.yPos);
		}


	}
}