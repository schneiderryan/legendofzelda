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

		public void BreathFireball()
		{
			aquamentus.fireball[0] = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			aquamentus.fireball[0].Position = new Point(aquamentus.xFire0, aquamentus.yFire0);
			aquamentus.fireball[1] = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			aquamentus.fireball[1].Position = new Point(aquamentus.xFire1, aquamentus.yFire1);
			aquamentus.fireball[2] = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			aquamentus.fireball[2].Position = new Point(aquamentus.xFire2, aquamentus.yFire2);

			while(aquamentus.fireStep < 50)
			{
				aquamentus.xFire0--;
				aquamentus.xFire1--;
				aquamentus.xFire2--;
				aquamentus.yFire0++;
				
				aquamentus.yFire2--;

			}
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
			
		}

		public void MoveDown()
		{
			
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
			aquamentus.fireStep++;
			aquamentus.xPos -= 1;
			if (aquamentus.xPos < 0)
			{
				aquamentus.xPos += 800;
			}
			aquamentus.sprite.Position = new Point(aquamentus.xPos, aquamentus.yPos);
		}


	}
}