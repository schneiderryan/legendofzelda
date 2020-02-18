using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class DownMovingStalfoState : IStalfoState
	{
		private Stalfo stalfo;

		public DownMovingStalfoState(Stalfo stalfo)
		{
			this.stalfo = stalfo;
		}


		public void ChangeDirection()
		{
			//stalfo.state = new RightMovingStalfoState(stalfo);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//stalfo.state = new KilledEnemyState(stalfo);
		}

		public void MoveUp()
		{
			stalfo.state = new UpMovingStalfoState(stalfo);
			stalfo.sprite = EnemySpriteFactory.Instance.CreateUpMovingStalfoSprite();
		}

		public void MoveDown()
		{
			//nothing to do 
		}

		public void MoveRight()
		{
			stalfo.state = new RightMovingStalfoState(stalfo);
			stalfo.sprite = EnemySpriteFactory.Instance.CreateRightMovingStalfoSprite();
		}


		public void MoveLeft()
		{
			stalfo.state = new LeftMovingStalfoState(stalfo);
			stalfo.sprite = EnemySpriteFactory.Instance.CreateLeftMovingStalfoSprite();
		}

		public void Update()
		{
			stalfo.Y += 1;
			if (stalfo.Y > 480)
			{
				stalfo.Y -= 480;
			}
			stalfo.sprite.Position = new Point(stalfo.X, stalfo.Y);
		}


	}
}