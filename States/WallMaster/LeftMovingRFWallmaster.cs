using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class LeftMovingRFWallmasterState : IEnemyState
	{
		private RFWallmaster rfwallmaster;

		public LeftMovingRFWallmasterState(RFWallmaster rfwallmaster)
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
			rfwallmaster.state = new RightMovingRFWallmasterState(rfwallmaster);
			rfwallmaster.sprite = EnemySpriteFactory.Instance.CreateRightMovingRFWallmasterSprite();
		}


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			rfwallmaster.X -= 1;
			if (rfwallmaster.X < 0)
			{
				rfwallmaster.X += 800;
			}
			rfwallmaster.sprite.Position = new Point(rfwallmaster.X, rfwallmaster.Y);
		}


	}
}