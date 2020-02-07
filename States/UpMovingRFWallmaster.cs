using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
{

	class UpMovingRFWallmasterState : IWallmasterState
	{
		private RFWallmaster rfwallmaster;

		public UpMovingRFWallmasterState(RFWallmaster rfwallmaster)
		{
			this.rfwallmaster = rfwallmaster;
		}


		public void ChangeDirection()
		{
			//rfwallmaster.state = new RightMovingRFWallmasterState(rfwallmaster);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//rfwallmaster.state = new KilledEnemyState(rfwallmaster);
		}

		public void MoveUp()
		{
			//nothing
		}

		public void MoveDown()
		{
			rfwallmaster.state = new DownMovingRFWallmasterState(rfwallmaster);
			rfwallmaster.sprite = EnemySpriteFactory.Instance.CreateDownMovingRFWallmasterSprite();
		}

		public void MoveRight()
		{
			rfwallmaster.state = new RightMovingRFWallmasterState(rfwallmaster);
			rfwallmaster.sprite = EnemySpriteFactory.Instance.CreateRightMovingRFWallmasterSprite();
		}


		public void MoveLeft()
		{
			rfwallmaster.state = new LeftMovingRFWallmasterState(rfwallmaster);
			rfwallmaster.sprite = EnemySpriteFactory.Instance.CreateLeftMovingRFWallmasterSprite();
		}

		public void Update()
		{
			rfwallmaster.yPos -= 1;
			if (rfwallmaster.yPos < 0)
			{
				rfwallmaster.yPos += 480;
			}
			
			rfwallmaster.sprite.Position = new Point(rfwallmaster.xPos, rfwallmaster.yPos);
		}


	}
}