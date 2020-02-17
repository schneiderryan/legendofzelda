using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class LeftMovingTrapState : ITrapState
	{
		private Trap trap;

		public LeftMovingTrapState(Trap trap)
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
			trap.state = new DownMovingTrapState(trap);
			
		}

		public void MoveRight()
		{
			trap.state = new RightMovingTrapState(trap);
			
		}


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			trap.X -= 1;
			if (trap.X < 0)
			{
				trap.X += 800;
			}
			trap.sprite.Position = new Point(trap.X, trap.Y);
		}


	}
}