
namespace LegendOfZelda
{

	class LeftMovingGoriyaState : EnemyState

	{
		public LeftMovingGoriyaState(IEnemy goriya)
			: base(goriya)
		{
			enemy.Sprite = EnemySpriteFactory.Instance.CreateLeftMovingGoriyaSprite();
			(enemy as Goriya).direction = "left";
		}

		public override void MoveUp()
		{
			base.MoveUp();
			enemy.State = new UpMovingGoriyaState(enemy);
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
			// do nothing
		}


	}
}