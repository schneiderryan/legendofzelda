using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
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
			
			trap.Y += 1;
			if (trap.Y > 480)
			{
				trap.Y -= 480;
			}
			trap.sprite.Position = new Point(trap.X, trap.Y);
		}


	}
}