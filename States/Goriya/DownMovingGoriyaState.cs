
namespace LegendOfZelda
{

	class DownMovingGoriyaState : EnemyState

	{
		public DownMovingGoriyaState(IEnemy goriya)
			: base(goriya)
		{
			enemy.Sprite = EnemySpriteFactory.Instance.CreateDownMovingGoriyaSprite();
			(enemy as Goriya).direction = "down";
		}

		public override void MoveUp()
		{
			base.MoveUp();
			enemy.State = new UpMovingGoriyaState(enemy);
		}

		public override void MoveDown()
		{
			// do nothing
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
