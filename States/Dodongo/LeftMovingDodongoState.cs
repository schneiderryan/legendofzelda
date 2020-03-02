
namespace LegendOfZelda
{
	class LeftMovingDodongoState : EnemyState
	{
		public LeftMovingDodongoState(IEnemy enemy)
			: base(enemy)
		{
			enemy.Sprite = EnemySpriteFactory.Instance.CreateLeftMovingDodongoSprite();
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
			base.MoveRight();
			enemy.State = new RightMovingDodongoState(enemy);
		}

		public override void MoveLeft()
		{
			// do nothing
		}
	}
}
