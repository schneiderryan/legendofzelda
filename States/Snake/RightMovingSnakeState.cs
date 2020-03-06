
namespace LegendOfZelda
{
	class RightMovingSnakeState : EnemyState
	{
		private IPlayer link;
		public RightMovingSnakeState(IEnemy snake, IPlayer gamelink) : base(snake)
		{
			this.enemy = snake;
			enemy.Sprite = EnemySpriteFactory.Instance.CreateRightMovingSnakeSprite();
			base.MoveRight();
			link = gamelink;
		}

		public override void MoveUp()
		{
			enemy.State = new UpMovingSnakeState(enemy,link);
		}

		public override void MoveDown()
		{
			enemy.State = new DownMovingSnakeState(enemy, link);
		}

		public override void MoveRight()
		{
			// do nothing
		}

		public override void MoveLeft()
		{
			enemy.State = new LeftMovingSnakeState(enemy, link);
		}

		public override void Update()
		{
			int linkYPos = link.Y;
			int linkXPos = link.X;
			if ((linkYPos < (enemy.Y + 10)) && (linkYPos > (enemy.Y - 10)))
			{
				if (linkXPos > enemy.X)
				{
					enemy.X += 4;
				}
			}
			base.Update();
		}

	}
}
