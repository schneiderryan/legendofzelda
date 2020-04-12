using System;


namespace LegendOfZelda
{
	abstract class AquamentusState : IEnemyState
	{
		protected Aquamentus aquamentus;

		public AquamentusState(Aquamentus aquamentus)
		{
			this.aquamentus = aquamentus;
		}

		public virtual void MoveDown()
		{
			// do nothing
		}

		public virtual void MoveLeft()
		{
			aquamentus.VX = -1;
			aquamentus.VY = 0;
		}

		public virtual void MoveRight()
		{
			aquamentus.VX = 1;
			aquamentus.VY = 0;
		}

		public virtual void MoveUp()
		{
			// do nothing
		}

		public virtual void BeStill()
		{
			// do nothing
		}

		public virtual void Update()
		{
			// slow aquamentus down
			if (new Random().Next(0, 2) == 0)
			{
				aquamentus.X += aquamentus.VX;
				aquamentus.Y += aquamentus.VY;
			}
		}

		public void Knockback(int amountX, int amountY)
		{
			// do nothing
		}
	}
}
