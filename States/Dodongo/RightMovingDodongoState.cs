
namespace LegendOfZelda
{

	class RightMovingDodongoState : EnemyState

	{
		public RightMovingDodongoState(IEnemy enemy)
			: base(enemy)
		{
			enemy.Sprite = EnemySpriteFactory.Instance.CreateRightMovingDodongoSprite();
		}

		public override void MoveUp()
		{
			base.MoveUp();
			enemy.State = new UpMovingDodongoState(enemy);
		}

		public override void MoveDown()
		{
			base.MoveDown();
			enemy.State = new DownMovingDodongoState(enemy);
		}

		public override void MoveRight()
		{
			// do nothing
		}

		public override void MoveLeft()
		{
			base.MoveLeft();
			enemy.State = new LeftMovingDodongoState(enemy);
		}


	}
}