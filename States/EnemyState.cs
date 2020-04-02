using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
	class EnemyState : IEnemyState
	{
		protected IEnemy enemy;

		public EnemyState(IEnemy enemy)
		{
			this.enemy = enemy;
		}

		public virtual void MoveUp()
		{
			enemy.VY = -1;
			enemy.VX = 0;
		}

		public virtual void MoveDown()
		{
			enemy.VY = 1;
			enemy.VX = 0;
		}

		public virtual void MoveRight()
		{
			enemy.VY = 0;
			enemy.VX = 1;
		}

		public virtual void MoveLeft()
		{
			enemy.VY = 0;
			enemy.VX = -1;
		}

		public virtual void Update()
		{
			enemy.Y += enemy.VY;
			enemy.X += enemy.VX;
		}

		public virtual void BeStill()
		{
			enemy.VX = 0;
			enemy.VY = 0;
		}

	}
}
