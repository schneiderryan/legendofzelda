﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
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
			aquamentus.sprite = EnemySpriteFactory.Instance.CreateRightMovingFireAquamentusSprite();
			aquamentus.xFire0 = 400;
			aquamentus.yFire0 = 200;
			aquamentus.xFire1 = 400;
			aquamentus.yFire1 = 200;
			aquamentus.xFire2 = 400;
			aquamentus.yFire2 = 200;
			
			aquamentus.fireball0 = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			aquamentus.fireball0.Position = new Point(aquamentus.xFire0, aquamentus.yFire0);
			aquamentus.fireball1 = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			aquamentus.fireball1.Position = new Point(aquamentus.xFire1, aquamentus.yFire1);
			aquamentus.fireball2 = EnemySpriteFactory.Instance.CreateMovingFireballSprite();
			aquamentus.fireball2.Position = new Point(aquamentus.xFire2, aquamentus.yFire2);

			while (aquamentus.fireStep < 50)
			{
				aquamentus.xFire0--;
				aquamentus.xFire1--;
				aquamentus.xFire2--;
				aquamentus.yFire0++;
				aquamentus.yFire2--;
				aquamentus.fireStep++;

			}
			aquamentus.sprite = EnemySpriteFactory.Instance.CreateRightMovingAquamentusSprite();
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