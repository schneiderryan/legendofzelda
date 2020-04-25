
namespace LegendOfZelda
{
	class DraggingRFWallmasterState : EnemyState
	{
		private IPlayer link;
		private LegendOfZelda game;

		public DraggingRFWallmasterState(IEnemy wallmaster, IPlayer gamelink, LegendOfZelda game) : base(wallmaster)
		{
			this.enemy = wallmaster;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateDraggingRFWallmasterSprite();
			link = gamelink;
			link.State = new GrabbedLinkState(link);
			this.game = game;
		}

		public override void Update()
		{
			if (link.X > enemy.X)
			{
				enemy.X++;
			}
			else if (link.X < enemy.X)
			{
				enemy.X--;
			}
			else if (link.Y > enemy.Y)
			{
				enemy.Y++;
			}
			else if (link.Y < enemy.Y)
			{
				enemy.Y--;
			}
			else
			{
				enemy.X = link.X;
				enemy.Y = link.Y;
				link.State = new GrabbedLinkState(link);
				if (enemy.X > 10)
				{
					enemy.X--;
					link.X--;
				}
				else
				{
					game.rooms[game.roomIndex].Players.Remove(link.ID);
					game.roomIndex = 1;
					game.rooms[game.roomIndex].Players.Add(link.ID, link);
					game.rooms[game.roomIndex].Update();
					link.X = game.GraphicsDevice.Viewport.Width/2;
					link.Y = game.GraphicsDevice.Viewport.Height / 2;
					game.xRoom = 515;
					game.yRoom = 826;
					enemy.State = new EnemyState(enemy);
					link.BeStill();
				}
			}
		}

	}
}
