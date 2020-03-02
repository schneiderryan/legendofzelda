
namespace LegendOfZelda
{

	class UpMovingGoriyaState : EnemyState

	{
		public UpMovingGoriyaState(IEnemy goriya)
			: base(goriya)
		{
			enemy.Sprite = EnemySpriteFactory.Instance.CreateUpMovingGoriyaSprite();
			(enemy as Goriya).direction = "up";
		}

		public override void MoveUp()
		{
			// do nothing
		}

		public override void MoveDown()
		{
			base.MoveDown();
			enemy.State = new DownMovingGoriyaState(enemy);
		}

		public override void MoveRight()
		{
			base.MoveRight();
			enemy.State = new RightMovingGoriyaState(enemy);
		}

		public override void MoveLeft()
		{
			base.MoveLeft();
			enemy.State = new LeftMovingGoriyaState(enemy);
		}


	}
}
