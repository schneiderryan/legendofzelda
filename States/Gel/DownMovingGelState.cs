﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class DownMovingGelState : IEnemyState
	{
		private Gel gel;

		public DownMovingGelState(Gel goriya)
		{
			this.gel = goriya;
		}


		public void ChangeDirection()
		{
			
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
			//nothing to do 
		}

		public void MoveRight()
		{
			gel.state = new RightMovingGelState(gel);
			
		}


		public void MoveLeft()
		{
			gel.state = new LeftMovingGelState(gel);
			
		}

		public void Update()
		{
			gel.Y += 1;
			if (gel.Y > 480)
			{
				gel.Y -= 480;
			}
			gel.sprite.Position = new Point(gel.X, gel.Y);
		}

		public void TakeDamage()
		{
			throw new System.NotImplementedException();
		}
	}
}