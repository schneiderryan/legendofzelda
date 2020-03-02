
namespace LegendOfZelda
{

	class UpMovingSnakeState : EnemyState

	{
		public UpMovingSnakeState(IEnemy snake) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateUpMovingSnakeSprite();
			base.MoveUp();
		}

		public override void MoveUp()
		{
			// nothing to do
		}

		public override void MoveDown()
		{
			enemy.State = new DownMovingSnakeState(enemy);
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
