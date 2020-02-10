using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint0;


namespace Sprint0
{

	class RightMovingAquamentusState : IAquamentusState
	{
		private Aquamentus aquamentus;

		public RightMovingAquamentusState(Aquamentus aquamentus)
		{
			this.aquamentus = aquamentus;
		}

		public void BreathFireball()
		{
			aquamentus.fireball[0] = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			aquamentus.fireball[1] = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			aquamentus.fireball[3] = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
		}
		public void ChangeDirection()
		{
			//aquamentus.state = new RightMovingaquamentusState(aquamentus);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//aquamentus.state = new KilledEnemyState(aquamentus);
		}

		public void MoveUp()
		{
			
		}

		public void MoveDown()
		{
		
		}

		public void MoveRight()
		{
			
		}


		public void MoveLeft()
		{
			aquamentus.state = new LeftMovingAquamentusState(aquamentus);
			aquamentus.sprite = EnemySpriteFactory.Instance.CreateLeftMovingAquamentusSprite();
		}

		public void Update()
		{
			aquamentus.xPos += 1;
			if (aquamentus.xPos > 800)
			{
				aquamentus.xPos -= 800;
			}
			aquamentus.sprite.Position = new Point(aquamentus.xPos, aquamentus.yPos);
		}


	}
}