using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{    public class RightMovingRFWallmasterState : IWallmasterState
	{
		private RFWallmaster rfwallmaster;

		public RightMovingRFWallmasterState(RFWallmaster rfwallmaster)
		{
			this.rfwallmaster = rfwallmaster;
		}


		public void ChangeDirection()
		{
			//rfwallmaster.state = new RightMovingrfwallmasterState(rfwallmaster);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//rfwallmaster.state = new KilledEnemyState(rfwallmaster);
		}

		public void MoveUp()
		{
			rfwallmaster.state = new UpMovingRFWallmasterState(rfwallmaster);
			rfwallmaster.sprite = EnemySpriteFactory.Instance.CreateUpMovingRFWallmasterSprite();
		}

		public void MoveDown()
		{
			rfwallmaster.state = new DownMovingRFWallmasterState(rfwallmaster);
			rfwallmaster.sprite = EnemySpriteFactory.Instance.CreateDownMovingRFWallmasterSprite();
		}

		public void MoveRight()
		{
			
		}


		public void MoveLeft()
		{
			rfwallmaster.state = new LeftMovingRFWallmasterState(rfwallmaster);
			rfwallmaster.sprite = EnemySpriteFactory.Instance.CreateLeftMovingRFWallmasterSprite();
		}

		public void Update()
		{
			rfwallmaster.xPos += 1;
			if (rfwallmaster.xPos > 800)
			{
				rfwallmaster.xPos -= 800;
			}
			rfwallmaster.sprite.Position = new Point(rfwallmaster.xPos, rfwallmaster.yPos);
		}


	}
}