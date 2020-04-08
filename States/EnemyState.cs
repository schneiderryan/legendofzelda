

namespace LegendOfZelda
{
	class EnemyState : IEnemyState
	{
		protected IEnemy enemy;

		private int knockbackX = 0;
		private int knockbackY = 0;
		private int knockbackTimer = 0;
		private const int KNOCKBACK_TIME = 10;

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
			if (knockbackTimer > 0)
			{
				enemy.X += knockbackX;
				enemy.Y += knockbackY;
				knockbackTimer -= 1;
			}
			enemy.Y += enemy.VY;
			enemy.X += enemy.VX;
		}

		public virtual void BeStill()
		{
			enemy.VX = 0;
			enemy.VY = 0;
		}

		public void Knockback(int amountX, int amountY)
		{
			knockbackX = amountX / KNOCKBACK_TIME;
			knockbackY = amountY / KNOCKBACK_TIME;
			knockbackTimer = KNOCKBACK_TIME;
		}
	}
}
