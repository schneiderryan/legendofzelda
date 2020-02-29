using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;
using System;

namespace LegendOfZelda
{

	class DownMovingSnakeState : ISnakeState
	{
		private Snake snake;

		public DownMovingSnakeState(Snake snake)
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
			//nothing to do 
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
			int linkYPos = snake.game.link.Y;
			int linkXPos = snake.game.link.X;
			if ((linkYPos < (snake.Y + 10)) && (linkYPos > (snake.Y - 10)))
			{
				if (linkXPos < snake.X)
				{
					snake.X -= 4;
					MoveLeft();
				}
				else
				{
					snake.X += 4;
					MoveRight();
				}
			}
			else if ((linkXPos < (snake.X + 10)) && (linkXPos > (snake.X - 10)))
			{
				if (linkYPos < snake.Y)
				{
					snake.Y -= 4;
					MoveUp();
				}
				else
				{
					snake.Y += 4;
					MoveDown();
				}
			}
			else
			{
				snake.Y += 1;
			}
			

			if (snake.Y > 480)
			{
				snake.Y -= 480;
			}
			snake.sprite.Position = new Point(snake.X, snake.Y);
		}


	}
}