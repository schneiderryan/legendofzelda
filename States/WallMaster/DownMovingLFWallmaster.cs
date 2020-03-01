using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class DownMovingLFWallmasterState : IEnemyState
	{
		private LFWallmaster lfwallmaster;

		public DownMovingLFWallmasterState(LFWallmaster lfwallmaster)
		{
			this.lfwallmaster = lfwallmaster;
		}


		public void ChangeDirection()
		{
			//lfwallmaster.state = new RightMovingLFWallmasterState(lfwallmaster);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//lfwallmaster.state = new KilledEnemyState(lfwallmaster);
		}

		public void MoveUp()
		{
			lfwallmaster.state = new UpMovingLFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateUpMovingLFWallmasterSprite();
		}

		public void MoveDown()
		{
			//nothing to do 
		}

		public void MoveRight()
		{
			lfwallmaster.state = new RightMovingLFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateRightMovingLFWallmasterSprite();
		}


		public void MoveLeft()
		{
			lfwallmaster.state = new LeftMovingLFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateLeftMovingLFWallmasterSprite();
		}

		public void Update()
		{
			lfwallmaster.Y += 1;
			if (lfwallmaster.Y > 480)
			{
				lfwallmaster.Y -= 480;
			}
			lfwallmaster.sprite.Position = new Point(lfwallmaster.X, lfwallmaster.Y);
		}


	}
}