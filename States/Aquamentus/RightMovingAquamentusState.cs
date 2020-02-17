﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{    public class RightMovingAquamentusState : IAquamentusState
	{
		private Aquamentus aquamentus;
		private int changeDirection;
		private bool breathe;
		private int openMouth;

		public RightMovingAquamentusState(Aquamentus aquamentus)
		{

			this.aquamentus = aquamentus;
			
			this.changeDirection = aquamentus.changeDirection;
			this.openMouth = 0;

			if (this.changeDirection % 2 == 1)
			{
				aquamentus.sprite = EnemySpriteFactory.Instance.CreateRightMovingFireAquamentusSprite();
				this.aquamentus.BreatheFireball(aquamentus.xPos, aquamentus.yPos);
				breathe = true;
				
			}
			else
			{
				this.aquamentus.sprite = EnemySpriteFactory.Instance.CreateRightMovingAquamentusSprite();
			}
		}

		
			public void ChangeDirection()
		{
			//aquamentus.state = new RightMovingaquamentusState(aquamentus);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//aquamentus.state = new KilledEnemyState(aquamentus);
		}

		public void MoveUp()
		{
			
		}

		public void MoveDown()
		{
		
		}

		public void MoveRight()
		{
			
		}


		public void MoveLeft()
		{
			aquamentus.state = new LeftMovingAquamentusState(aquamentus);
		}

		public void Update()
		{
			if (breathe)
			{
				openMouth++;
				if (openMouth > 20)
				{
					aquamentus.sprite = EnemySpriteFactory.Instance.CreateRightMovingAquamentusSprite();
					openMouth = 0;
					breathe = false;
				}

			}
			aquamentus.xPos += 1;
			if (aquamentus.xPos > 800)
			{
				aquamentus.xPos -= 800;
			}
			aquamentus.sprite.Position = new Point(aquamentus.xPos, aquamentus.yPos);
			

		}

	}
}