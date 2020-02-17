using Microsoft.Xna.Framework;



namespace LegendOfZelda
{

	class UpMovingGelState : IGelState
	{
		private Gel gel;

		public UpMovingGelState(Gel gel)
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
			//nothing
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
			gel.state = new LeftMovingGelState(gel);
			
		}

		public void Update()
		{
			gel.Y -= 1;
			if (gel.X < 0)
			{
				gel.Y += 480;
			}
			
			gel.sprite.Position = new Point(gel.X, gel.Y);
		}


	}
}