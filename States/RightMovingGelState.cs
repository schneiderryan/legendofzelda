using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class RightMovingGelState : IGelState
	{
		private Gel gel;

		public RightMovingGelState(Gel goriya)
		{
			this.gel = goriya;
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
			
		}


		public void MoveLeft()
		{
			gel.state = new LeftMovingGelState(gel);
			;
		}

		public void Update()
		{
			gel.xPos += 1;
			if (gel.xPos > 800)
			{
				gel.xPos -= 800;
			}
			gel.sprite.Position = new Point(gel.xPos, gel.yPos);
		}


	}
}