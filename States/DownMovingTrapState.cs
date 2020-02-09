using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
{

	class DownMovingTrapState : ITrapState
	{
		private Trap trap;

		public DownMovingTrapState(Trap trap)
		{
			this.trap = trap;
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
			trap.state = new UpMovingTrapState(trap);
			
		}

		public void MoveDown()
		{
			//nothing to do 
		}

		public void MoveRight()
		{
			trap.state = new RightMovingTrapState(trap);
			
		}


		public void MoveLeft()
		{
			trap.state = new LeftMovingTrapState(trap);
			
		}

		public void Update()
		{
			trap.yPos += 1;
			if (trap.yPos > 480)
			{
				trap.yPos -= 480;
			}
			trap.sprite.Position = new Point(trap.xPos, trap.yPos);
		}


	}
}