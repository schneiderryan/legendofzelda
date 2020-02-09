using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
{

	class LeftMovingAquamentusState : IAquamentusState
	{
		private Aquamentus aquamentus;

		public LeftMovingAquamentusState(Aquamentus aquamentus)
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
			aquamentus.state = new UpMovingAquamentusState(aquamentus);
			aquamentus.sprite = EnemySpriteFactory.Instance.CreateUpMovingAquamentusSprite();
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
			
		}

		public void Update()
		{
			aquamentus.xPos -= 1;
			if (aquamentus.xPos < 0)
			{
				aquamentus.xPos += 800;
			}
			aquamentus.sprite.Position = new Point(aquamentus.xPos, aquamentus.yPos);
		}


	}
}