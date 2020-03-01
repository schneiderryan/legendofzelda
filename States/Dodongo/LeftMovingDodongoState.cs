using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class LeftMovingDodongoState : IEnemyState
	{
		private Dodongo dodongo;

		public LeftMovingDodongoState(Dodongo dodongo)
		{
			this.dodongo = dodongo;
		}


		public void ChangeDirection()
		{
			//dodongo.state = new RightMovingDodongoState(dodongo);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//dodongo.state = new KilledEnemyState(dodongo);
		}

		public void MoveUp()
		{
			dodongo.state = new UpMovingDodongoState(dodongo);
			dodongo.sprite = EnemySpriteFactory.Instance.CreateUpMovingDodongoSprite();
		}

		public void MoveDown()
		{
			dodongo.state = new DownMovingDodongoState(dodongo);
			dodongo.sprite = EnemySpriteFactory.Instance.CreateDownMovingDodongoSprite();
		}

		public void MoveRight()
		{
			dodongo.state = new RightMovingDodongoState(dodongo);
			dodongo.sprite = EnemySpriteFactory.Instance.CreateRightMovingDodongoSprite();
		}


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			dodongo.X -= 1;
			if (dodongo.X < 0)
			{
				dodongo.X += 800;
			}
			dodongo.sprite.Position = new Point(dodongo.X, dodongo.Y);
		}

		public void TakeDamage()
		{
			throw new System.NotImplementedException();
		}
	}
}