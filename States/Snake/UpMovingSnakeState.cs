using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;
using System;

namespace LegendOfZelda
{

	class UpMovingSnakeState : ISnakeState
	{
		private Snake snake;

		public UpMovingSnakeState(Snake snake)
		{
			this.snake = snake;
		}


		public void ChangeDirection()
		{
			//snake.state = new RightMovingSnakeState(snake);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//snake.state = new KilledEnemyState(snake);
		}

		public void MoveUp()
		{
			//nothing
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
			snake.state = new LeftMovingSnakeState(snake);
			snake.sprite = EnemySpriteFactory.Instance.CreateLeftMovingSnakeSprite();
		}

		public void Update()
		{

			snake.Y -= 1;

			if (snake.X < 0)
			{ 
				snake.X += 800;
			}
			
			snake.sprite.Position = new Point(snake.X, snake.Y);
		}


	}
}