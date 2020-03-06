using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
	class TrapState : IEnemyState
	{
		protected Trap trap;

		public TrapState(Trap trap)
		{
			this.trap = trap;
		}

		public virtual void MoveUp()
		{
			trap.VY = -1;
			trap.VX = 0;
		}

		public virtual void MoveDown()
		{
			trap.VY = 1;
			trap.VX = 0;
		}

		public virtual void MoveRight()
		{
			trap.VY = 0;
			trap.VX = 1;
		}

		public virtual void MoveLeft()
		{
			trap.VY = 0;
			trap.VX = -1;
		}

		public void ChaseRight()
		{
			trap.VY = 0;
			trap.VX = 3;
		}

		public void ChaseUp()
		{
			trap.VY = -3;
			trap.VX = 0;
		}

		public void ChaseDown()
		{
			trap.VY = 3;
			trap.VX = 0;
		}

		public void ChaseLeft()
		{
			trap.VY = 0;
			trap.VX = -3;
		}

		public virtual void Update()
		{
			trap.Y += trap.VY;
			trap.X += trap.VX;
		}

	}
}
