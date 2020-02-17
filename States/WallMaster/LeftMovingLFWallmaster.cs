using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{    public class LeftMovingLFWallmasterState : IWallmasterState
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
			lfwallmaster.xPos -= 1;
			if (lfwallmaster.xPos < 0)
			{
				lfwallmaster.xPos += 800;
			}
			lfwallmaster.sprite.Position = new Point(lfwallmaster.xPos, lfwallmaster.yPos);
		}


	}
}