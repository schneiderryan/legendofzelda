using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
{

	class RightMovingStalfoState : IStalfoState
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
			stalfo.xPos += 1;
			if (stalfo.xPos > 800)
			{
				stalfo.xPos -= 800;
			}
			stalfo.sprite.Position = new Point(stalfo.xPos, stalfo.yPos);
		}


	}
}