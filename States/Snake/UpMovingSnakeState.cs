
namespace LegendOfZelda
{
	class UpMovingSnakeState : IEnemyState
	{
		private Snake snake;

		public UpMovingSnakeState(Snake snake)
		{
			this.snake = snake;
			snake.Sprite = EnemySpriteFactory.Instance.CreateUpMovingSnakeSprite();
		}

		public void MoveUp()
		{
			// nothing to do
		}

		public void MoveDown()
		{
			snake.State = new DownMovingSnakeState(snake);
		}

		public void MoveRight()
		{
			snake.State = new RightMovingSnakeState(snake);
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
