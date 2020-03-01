using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class LeftMovingLFWallmasterState : IEnemyState
	{
		private LFWallmaster lfwallmaster;

		public LeftMovingLFWallmasterState(LFWallmaster lfwallmaster)
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
			lfwallmaster.state = new DownMovingLFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateDownMovingLFWallmasterSprite();
		}

		public void MoveRight()
		{
			lfwallmaster.state = new RightMovingLFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateRightMovingLFWallmasterSprite();
		}


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			lfwallmaster.X -= 1;
			if (lfwallmaster.X < 0)
			{
				lfwallmaster.X += 800;
			}
			lfwallmaster.sprite.Position = new Point(lfwallmaster.X, lfwallmaster.Y);
		}


	}
}