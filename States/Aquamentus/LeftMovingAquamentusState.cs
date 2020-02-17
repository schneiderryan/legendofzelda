using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class LeftMovingAquamentusState : IAquamentusState
	{
		private Aquamentus aquamentus;
		private int changeDirection;
		private bool breathe;
		private int openMouth;

		public LeftMovingAquamentusState(Aquamentus aquamentus)
		{
			this.aquamentus = aquamentus;
			this.changeDirection = aquamentus.changeDirection;
			this.openMouth = 0;

			if(this.changeDirection%2 == 1)
			{
				aquamentus.sprite = EnemySpriteFactory.Instance.CreateLeftMovingFireAquamentusSprite();
				this.aquamentus.BreatheFireball(aquamentus.xPos, aquamentus.yPos);
				breathe = true;
			}
			else
			{
				aquamentus.sprite = EnemySpriteFactory.Instance.CreateLeftMovingAquamentusSprite();
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

		public void MoveDown()
		{
			//aquamentus.state = new KilledEnemyState(aquamentus);
		}

		public void MoveUp()
		{
			//aquamentus.state = new KilledEnemyState(aquamentus);
		}


		public void MoveRight()
		{
			aquamentus.state = new RightMovingAquamentusState(aquamentus);
			
		}


		public void MoveLeft()
		{
			
		}

		public void Update()
		{
			if (breathe)
			{
				openMouth++;
				
				if (openMouth >20)
				{
					breathe = false;
					aquamentus.sprite = EnemySpriteFactory.Instance.CreateLeftMovingAquamentusSprite();
					openMouth = 0;
				}
				
			}

			aquamentus.xPos -= 1;
			if (aquamentus.xPos < 0)
			{
				aquamentus.xPos += 800;
			}
			aquamentus.sprite.Position = new Point(aquamentus.xPos, aquamentus.yPos);
			

		}


	}
}