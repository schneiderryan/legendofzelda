using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class UpMovingDodongoState : IEnemyState
	{
		private Dodongo dodongo;

		public UpMovingDodongoState(Dodongo dodongo)
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
			//nothing
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
			dodongo.state = new LeftMovingDodongoState(dodongo);
			dodongo.sprite = EnemySpriteFactory.Instance.CreateLeftMovingDodongoSprite();
		}

		public void Update()
		{
			dodongo.Y -= 1;
			if (dodongo.Y < 0)
			{
				dodongo.Y += 480;
			}
			
			dodongo.sprite.Position = new Point(dodongo.X, dodongo.Y);
		}

		public void TakeDamage()
		{
			throw new System.NotImplementedException();
		}
	}
}