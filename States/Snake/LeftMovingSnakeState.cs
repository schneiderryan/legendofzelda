
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


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			int linkYPos = snake.game.link.Y;
			int linkXPos = snake.game.link.X;
			if ((linkYPos < (snake.Y + 10)) && (linkYPos > (snake.Y - 10)))
			{
				if(linkXPos < snake.X)
				{
					snake.X -= 4;
					snake.state = this;
				}
				else
				{
					snake.X += 4;
					MoveRight();
				}
			}
			else
			{
				snake.X -= 1;
			}
			if (snake.X < 0)
			{
				snake.X += 800;
			}
			snake.sprite.Position = new Point(snake.X, snake.Y);
		}

		
	}
}