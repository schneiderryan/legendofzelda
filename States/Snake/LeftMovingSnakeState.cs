using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;
using System;

namespace LegendOfZelda
{

	class LeftMovingSnakeState : ISnakeState
	{
		private Snake snake;

		public LeftMovingSnakeState(Snake snake)
		{
			this.snake = snake;
		}


		public void ChangeDirection()
		{
			//snake.state = new RightMovingsnakeState(snake);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//snake.state = new KilledEnemyState(snake);
		}

		public void MoveUp()
		{
			snake.state = new UpMovingSnakeState(snake);
			snake.sprite = EnemySpriteFactory.Instance.CreateUpMovingSnakeSprite();
		}

		public void MoveDown()
		{
			snake.state = new DownMovingSnakeState(snake);
			snake.sprite = EnemySpriteFactory.Instance.CreateDownMovingSnakeSprite();
		}

		public void MoveRight()
		{
			snake.state = new RightMovingSnakeState(snake);
			snake.sprite = EnemySpriteFactory.Instance.CreateRightMovingSnakeSprite();
		}


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			snake.X -= 1;

			if (snake.X < 0)
			{
				snake.X += 800;
			}
			snake.sprite.Position = new Point(snake.X, snake.Y);
		}


	}
}