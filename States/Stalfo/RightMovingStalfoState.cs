using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class RightMovingStalfoState : IEnemyState
	{
		private Stalfo stalfo;

		public RightMovingStalfoState(Stalfo stalfo)
		{
			this.stalfo = stalfo;
		}


		public void ChangeDirection()
		{
			//stalfo.state = new RightMovingstalfoState(stalfo);
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
			stalfo.state = new DownMovingStalfoState(stalfo);
			stalfo.sprite = EnemySpriteFactory.Instance.CreateDownMovingStalfoSprite();
		}

		public void MoveRight()
		{
			
		}


		public void MoveLeft()
		{
			stalfo.state = new LeftMovingStalfoState(stalfo);
			stalfo.sprite = EnemySpriteFactory.Instance.CreateLeftMovingStalfoSprite();
		}

		public void Update()
		{
			stalfo.X += 1;
			if (stalfo.X > 800)
			{
				stalfo.X -= 800;
			}
			stalfo.sprite.Position = new Point(stalfo.X, stalfo.Y);
		}


	}
}