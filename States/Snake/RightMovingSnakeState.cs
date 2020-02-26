﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;
using System;

namespace LegendOfZelda
{

	class RightMovingSnakeState : ISnakeState
	{
		private Snake snake;

		public RightMovingSnakeState(Snake snake)
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
			
		}


		public void MoveLeft()
		{
			snake.state = new LeftMovingSnakeState(snake);
			snake.sprite = EnemySpriteFactory.Instance.CreateLeftMovingSnakeSprite();
		}

		public void Update()
		{
			snake.X += 1;

			if (snake.X > 800)
			{
				snake.X -= 800;
			}
			snake.sprite.Position = new Point(snake.X, snake.Y);
		}


	}
}