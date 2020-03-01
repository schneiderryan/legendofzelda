
namespace LegendOfZelda
{

	class DownMovingSnakeState : EnemyState

	{
		public DownMovingSnakeState(IEnemy snake) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateDownMovingSnakeSprite();
			base.MoveDown();
		}

		public override void MoveUp()
		{
			enemy.State = new UpMovingSnakeState(enemy);
		}

		public override void MoveDown()
		{
			// nothing to do
		}

		public override void MoveRight()
		{
			enemy.State = new RightMovingSnakeState(enemy);
		}

		public override void MoveLeft()
		{
			enemy.State = new LeftMovingSnakeState(enemy);
		}

	}
}
