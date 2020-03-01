
namespace LegendOfZelda
{
	class DownMovingDodongoState : EnemyState
	{
		public DownMovingDodongoState(IEnemy enemy)
			: base(enemy)
		{
			enemy.Sprite = EnemySpriteFactory.Instance.CreateDownMovingDodongoSprite();
		}

		public override void MoveUp()
		{
			base.MoveUp();
			enemy.State = new UpMovingDodongoState(enemy);
		}

		public override void MoveDown()
		{
			// do nothing
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