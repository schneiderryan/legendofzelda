using System.Collections.Generic;


namespace LegendOfZelda
{
	class DownMovingSnakeState : EnemyState
	{
		private IDictionary<int, IPlayer> players;
		public DownMovingSnakeState(IEnemy snake, IDictionary<int, IPlayer> players) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateDownMovingSnakeSprite();
			base.MoveDown();
			this.players = players;
		}

		public override void MoveUp()
		{
			enemy.State = new UpMovingSnakeState(enemy, players);
		}

		public override void MoveDown()
		{
			// nothing to do
		}

		public override void MoveRight()
		{
			enemy.State = new RightMovingSnakeState(enemy, players);
		}

		public override void MoveLeft()
		{
			enemy.State = new LeftMovingSnakeState(enemy, players);
		}

		public override void Update()
		{
			foreach (IPlayer player in players.Values)
			{
				int linkXPos = player.X;
				if ((linkXPos < (enemy.X + 10)) && (linkXPos > (enemy.X - 10)))
				{
					if (linkXPos > enemy.Y && enemy.VX != 0 && enemy.VY != 0)
					{
						enemy.Y += 4;
					}
				}
			}
			base.Update();
		}

	}
}
