
namespace LegendOfZelda
{
	class RightMovingSnakeState : IEnemyState
	{
		private Snake snake;

		public RightMovingSnakeState(Snake snake)
		{
			this.snake = snake;
			snake.Sprite = EnemySpriteFactory.Instance.CreateRightMovingSnakeSprite();
		}

		public void MoveUp()
		{
			snake.State = new UpMovingSnakeState(snake);
		}

		public void MoveDown()
		{
			snake.State = new DownMovingSnakeState(snake);
		}

		public void MoveRight()
		{
			// do nothing
		}

		public void MoveLeft()
		{
			snake.State = new LeftMovingSnakeState(snake);
		}

		public void Update()
		{
			// nothing to do
		}

	}
}
