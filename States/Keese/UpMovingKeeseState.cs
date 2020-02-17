using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{    public class UpMovingKeeseState : IKeeseState
	{
		private Keese keese;

		public UpMovingKeeseState(Keese keese)
		{
			this.keese = keese;
		}


		public void ChangeDirection()
		{
			//keese.state = new RightMovingKeeseState(keese);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//keese.state = new KilledEnemyState(keese);
		}

		public void MoveUp()
		{
			//nothing
		}

		public void MoveDown()
		{
			keese.state = new DownMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateDownMovingKeeseSprite();
		}

		public void MoveRight()
		{
			keese.state = new RightMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateRightMovingKeeseSprite();
		}


		public void MoveLeft()
		{
			keese.state = new LeftMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateLeftMovingKeeseSprite();
		}

		public void Update()
		{
			keese.yPos -= 1;
			if (keese.yPos < 0)
			{
				keese.yPos += 480;
			}
			
			keese.sprite.Position = new Point(keese.xPos, keese.yPos);
		}


	}
}