
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
			link.Sprite = PlayerSpriteFactory.Instance.CreateLeftStillLinkSprite();
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
					game.roomIndex = 1;
					link.X = game.GraphicsDevice.Viewport.Width/2;
					link.Y = game.GraphicsDevice.Viewport.Height / 2;
					game.xRoom = 515;
					game.yRoom = 826;
					enemy = new RFWallmaster();
				}
			}
			//base.Update();
		}

	}
}
