using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

	class RightMovingAquamentusState : IEnemyState
	{
		private Aquamentus aquamentus;
		private int openMouth;

		public RightMovingAquamentusState(Aquamentus aquamentus)
		{
			this.aquamentus = aquamentus;
			this.openMouth = 0;

			if (aquamentus.CurrentStep % 2 == 1)
			{
				aquamentus.Sprite = EnemySpriteFactory.Instance.CreateMovingFireAquamentusSprite();
				ICommand fire = new BreatheFireballCommand(aquamentus.game.projectiles, this.aquamentus);
				fire.Execute();
				aquamentus.Breathed = true;
			}
			else
			{
				this.aquamentus.Sprite = EnemySpriteFactory.Instance.CreateMovingAquamentusSprite();
			}
		}

		public void MoveDown()
		{
			// do nothing
		}

		public void MoveLeft()
		{
			aquamentus.State = new LeftMovingAquamentusState(aquamentus);
		}

		public void MoveRight()
		{
			// do nothing
		}

		public void MoveUp()
		{
			// do nothing
		}

		public void Update()
		{
			if (aquamentus.Breathed)
			{
				openMouth++;
				if (openMouth > 20)
				{
					aquamentus.Sprite = EnemySpriteFactory.Instance.CreateMovingAquamentusSprite();
					openMouth = 0;
					aquamentus.Breathed = false;
				}
			}
			aquamentus.X += 1;
			aquamentus.Sprite.Position = new Point(aquamentus.X, aquamentus.Y);
		}

		
	}
}