﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class LeftMovingGelState : IGelState
	{
		private Gel gel;

		public LeftMovingGelState(Gel gel)
		{
			this.gel = gel;
		}


		public void ChangeDirection()
		{
			//trap.state = new RightMovingGoriyaState(trap);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//trap.state = new KilledEnemyState(trap);
		}

		public void MoveUp()
		{
			gel.state = new UpMovingGelState(gel);
			
		}

		public void MoveDown()
		{
			gel.state = new DownMovingGelState(gel);
			
		}

		public void MoveRight()
		{
			gel.state = new RightMovingGelState(gel);
			
		}


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			gel.xPos -= 1;
			if (gel.xPos < 0)
			{
				gel.xPos += 800;
			}
			gel.sprite.Position = new Point(gel.xPos, gel.yPos);
		}


	}
}