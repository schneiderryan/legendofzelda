
namespace LegendOfZelda
{
	class DownMovingSnakeState : IEnemyState
	{
		private Snake snake;

		public DownMovingSnakeState(Snake snake)
		{
			this.snake = snake;
			snake.Sprite = EnemySpriteFactory.Instance.CreateDownMovingSnakeSprite();
		}

		public void MoveUp()
		{
			snake.State = new UpMovingSnakeState(snake);
		}

		public void MoveDown()
		{
			// nothing to do
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
