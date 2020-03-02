
namespace LegendOfZelda
{
	class RightMovingSnakeState : EnemyState
	{
		public RightMovingSnakeState(IEnemy snake) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateRightMovingSnakeSprite();
			base.MoveRight();
		}

		public override void MoveUp()
		{
			enemy.State = new UpMovingSnakeState(enemy);
		}

		public override void MoveDown()
		{
			enemy.State = new DownMovingSnakeState(enemy);
		}

		public override void MoveRight()
		{
			// do nothing
		}

		public override void MoveLeft()
		{
			enemy.State = new LeftMovingSnakeState(enemy);
		}

	}
}
