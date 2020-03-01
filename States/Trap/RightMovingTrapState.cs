using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class RightMovingTrapState : ITrapState
	{
		private Trap trap;

		public RightMovingTrapState(Trap trap)
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
			
		}


		public void MoveLeft()
		{
			trap.state = new LeftMovingTrapState(trap);
			
		}

		public void Update()
		{
			//trap.X += 1;
			if (trap.X > 800)
			{
				trap.X -= 800;
			}
			trap.sprite.Position = new Point(trap.X, trap.Y);
		}


	}
}