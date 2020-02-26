using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class DownMovingDodongoState : IDodongoState
	{
		private Dodongo dodongo;

		public DownMovingDodongoState(Dodongo dodongo)
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
			//nothing to do 
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
			dodongo.Y += 1;
			if (dodongo.Y > 480)
			{
				dodongo.Y -= 480;
			}
			dodongo.sprite.Position = new Point(dodongo.X, dodongo.Y);
		}


	}
}