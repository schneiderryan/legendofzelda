using System.Collections.Generic;

namespace LegendOfZelda
{
	class RightMovingSnakeState : EnemyState
	{
		private IDictionary<int, IPlayer> players;

		public RightMovingSnakeState(IEnemy snake, IDictionary<int, IPlayer> players) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateRightMovingSnakeSprite();
			base.MoveRight();
			this.players = players;
		}

		public override void MoveUp()
		{
			enemy.State = new UpMovingSnakeState(enemy, players);
		}

		public override void MoveDown()
		{
			enemy.State = new DownMovingSnakeState(enemy, players);
		}

		public override void MoveRight()
		{
			// do nothing
		}

		public override void MoveLeft()
		{
			enemy.State = new LeftMovingSnakeState(enemy, players);
		}

		public override void Update()
		{
			foreach (IPlayer player in players.Values)
			{
				int linkYPos = player.Y;
				int linkXPos = player.X;
				if ((linkYPos < (enemy.Y + 10)) && (linkYPos > (enemy.Y - 10)))
				{
					if (linkXPos > enemy.X && enemy.VX != 0 && enemy.VY != 0)
					{
						enemy.X += 4;
					}
				}
			}
			base.Update();
		}

	}
}
