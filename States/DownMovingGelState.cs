using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
{

	class DownMovingGelState : IGelState
	{
		private Gel gel;

		public DownMovingGelState(Gel goriya)
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
			gel.yPos += 1;
			if (gel.yPos > 480)
			{
				gel.yPos -= 480;
			}
			gel.sprite.Position = new Point(gel.xPos, gel.yPos);
		}


	}
}