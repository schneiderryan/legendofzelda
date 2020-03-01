
namespace LegendOfZelda
{
	class LeftMovingSnakeState : IEnemyState
	{
		private Snake snake;

		public LeftMovingSnakeState(Snake snake)
		{
			this.snake = snake;
			snake.Sprite = EnemySpriteFactory.Instance.CreateLeftMovingSnakeSprite();
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
			snake.State = new RightMovingSnakeState(snake);
		}

		public void MoveLeft()
		{
			// do nothing
		}

		public void Update()
		{
			// nothing to do
		}

	}
}