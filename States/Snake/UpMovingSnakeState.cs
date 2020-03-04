
namespace LegendOfZelda
{
	class UpMovingSnakeState : EnemyState
	{
		private IPlayer link;
		public UpMovingSnakeState(IEnemy snake, IPlayer gamelink) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateUpMovingSnakeSprite();
			base.MoveUp();
			link = gamelink;
		}

		public override void MoveUp()
		{
			// nothing to do
		}

		public override void MoveDown()
		{
			enemy.State = new DownMovingSnakeState(enemy,link);
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
				if (linkXPos < enemy.Y)
				{
					enemy.Y -= 4;
				}
			}
			base.Update();
		}
	}
}
