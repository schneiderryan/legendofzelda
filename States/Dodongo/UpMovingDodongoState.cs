
namespace LegendOfZelda
{
	class UpMovingDodongoState : EnemyState
	{
		public UpMovingDodongoState(IEnemy enemy)
			: base(enemy)
		{
			enemy.Sprite = EnemySpriteFactory.Instance.CreateUpMovingDodongoSprite();
		}

		public override void MoveUp()
		{
			// do nothing
		}

		public override void MoveDown()
		{
			base.MoveDown();
			enemy.State = new DownMovingDodongoState(enemy);
		}

		public override void MoveRight()
		{
			base.MoveRight();
			enemy.State = new RightMovingDodongoState(enemy);
		}

		public override void MoveLeft()
		{
			base.MoveLeft();
			enemy.State = new LeftMovingDodongoState(enemy);
		}
	}
}