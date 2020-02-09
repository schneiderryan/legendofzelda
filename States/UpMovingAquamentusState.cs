using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
{

	class UpMovingAquamentusState : IAquamentusState
	{
		private Aquamentus aquamentus;

		public UpMovingAquamentusState(Aquamentus aquamentus)
		{
			this.aquamentus = aquamentus;
		}


		public void ChangeDirection()
		{
			//aquamentus.state = new RightMovingAquamentusState(aquamentus);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//aquamentus.state = new KilledEnemyState(aquamentus);
		}

		public void MoveUp()
		{
			//nothing
		}

		public void MoveDown()
		{
			aquamentus.state = new DownMovingAquamentusState(aquamentus);
			aquamentus.sprite = EnemySpriteFactory.Instance.CreateDownMovingAquamentusSprite();
		}

		public void MoveRight()
		{
			aquamentus.state = new RightMovingAquamentusState(aquamentus);
			aquamentus.sprite = EnemySpriteFactory.Instance.CreateRightMovingAquamentusSprite();
		}


		public void MoveLeft()
		{
			aquamentus.state = new LeftMovingAquamentusState(aquamentus);
			aquamentus.sprite = EnemySpriteFactory.Instance.CreateLeftMovingAquamentusSprite();
		}

		public void Update()
		{
			aquamentus.yPos -= 1;
			if (aquamentus.yPos < 0)
			{
				aquamentus.yPos += 480;
			}
			
			aquamentus.sprite.Position = new Point(aquamentus.xPos, aquamentus.yPos);
		}


	}
}