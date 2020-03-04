
namespace LegendOfZelda
{
	class DownMovingSnakeState : EnemyState
	{
		private IPlayer link;
		public DownMovingSnakeState(IEnemy snake, IPlayer gamelink) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateDownMovingSnakeSprite();
			base.MoveDown();
			link = gamelink;
		}

		public override void MoveUp()
		{
			enemy.State = new UpMovingSnakeState(enemy,link);
		}

		public override void MoveDown()
		{
			// nothing to do
		}

		public override void MoveRight()
		{
			enemy.State = new RightMovingSnakeState(enemy,link);
		}

		public override void MoveLeft()
		{
			enemy.State = new LeftMovingSnakeState(enemy,link);
		}

		public override void Update()
		{
			int linkYPos = link.Y;
			int linkXPos = link.X;
			if ((linkXPos < (enemy.X + 10)) && (linkXPos > (enemy.X - 10)))
			{
				if (linkXPos > enemy.Y)
				{
					enemy.Y += 4;
				}
			}
			base.Update();
		}

	}
}
