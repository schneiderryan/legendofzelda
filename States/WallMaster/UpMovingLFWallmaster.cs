﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class UpMovingLFWallmasterState : IWallmasterState
	{
		private LFWallmaster lfwallmaster;

		public UpMovingLFWallmasterState(LFWallmaster lfwallmaster)
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
			//nothing
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
			lfwallmaster.state = new LeftMovingLFWallmasterState(lfwallmaster);
			lfwallmaster.sprite = EnemySpriteFactory.Instance.CreateLeftMovingLFWallmasterSprite();
		}

		public void Update()
		{
			lfwallmaster.yPos -= 1;
			if (lfwallmaster.yPos < 0)
			{
				lfwallmaster.yPos += 480;
			}

			lfwallmaster.sprite.Position = new Point(lfwallmaster.xPos, lfwallmaster.yPos);
		}


	}
}