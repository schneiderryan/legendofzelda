
namespace LegendOfZelda
{

	class RightMovingGoriyaState : EnemyState
	{
		public RightMovingGoriyaState(IEnemy goriya)
			: base(goriya)
		{
			enemy.Sprite = EnemySpriteFactory.Instance.CreateRightMovingGoriyaSprite();
			(enemy as Goriya).direction = "right";
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
			// do nothing
		}

		public override void MoveLeft()
		{
			base.MoveLeft();
			enemy.State = new LeftMovingGoriyaState(enemy);
		}


	}
}
