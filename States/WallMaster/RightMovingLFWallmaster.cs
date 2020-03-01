using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class RightMovingLFWallmasterState : IEnemyState
	{
		private LFWallmaster lfwallmaster;

		public RightMovingLFWallmasterState(LFWallmaster lfwallmaster)
		{
			this.lfwallmaster = lfwallmaster;
		}


		public void ChangeDirection()
		{
			//lfwallmaster.state = new RightMovinglfwallmasterState(lfwallmaster);
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
			
		}


		public void MoveLeft()
		{
			lfwallmaster.state = new LeftMovingLFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateLeftMovingLFWallmasterSprite();
		}

		public void Update()
		{
			lfwallmaster.X += 1;
			if (lfwallmaster.X > 800)
			{
				lfwallmaster.X -= 800;
			}
			lfwallmaster.sprite.Position = new Point(lfwallmaster.X, lfwallmaster.Y);
		}


	}
}