
namespace LegendOfZelda
{
	class LeftMovingSnakeState : EnemyState
	{
		public LeftMovingSnakeState(IEnemy snake) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateLeftMovingSnakeSprite();
			base.MoveLeft();
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
			enemy.State = new RightMovingSnakeState(enemy);
		}

		public override void MoveLeft()
		{
			// do nothing
		}

	}
}