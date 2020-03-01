using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class RightMovingDodongoState : IEnemyState
	{
		private Dodongo dodongo;

		public RightMovingDodongoState(Dodongo dodongo)
		{
			this.dodongo = dodongo;
		}


		public void ChangeDirection()
		{
			//dodongo.state = new RightMovingdodongoState(dodongo);
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
			
		}


		public void MoveLeft()
		{
			dodongo.state = new LeftMovingDodongoState(dodongo);
			dodongo.sprite = EnemySpriteFactory.Instance.CreateLeftMovingDodongoSprite();
		}

		public void Update()
		{
			dodongo.X += 1;
			if (dodongo.X > 800)
			{
				dodongo.X -= 800;
			}
			dodongo.sprite.Position = new Point(dodongo.X, dodongo.Y);
		}

		public void TakeDamage()
		{
			throw new System.NotImplementedException();
		}
	}
}