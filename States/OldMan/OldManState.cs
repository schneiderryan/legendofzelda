using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class OldManState : IEnemyState
	{
		private OldMan oldman;

		public OldManState(OldMan oldman)
		{
			this.oldman = oldman;
		}


		public void ChangeDirection()
		{
			//oldman.state = new RightMovingOldManState(oldman);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//oldman.state = new KilledEnemyState(oldman);
		}

		public void MoveUp()
		{
			//nothing to do, old man doesn't move
		}

		public void MoveDown()
		{
			//nothing to do, old man doesn't move
		}

		public void MoveRight()
		{
			//nothing to do, old man doesn't move
		}


		public void MoveLeft()
		{
			//nothing to do, old man doesn't move
		}

		public void Update()
		{
			/*
			oldman.Y += 0;
			if (oldman.Y > 480)
			{
				oldman.Y -= 480;
			}
			oldman.sprite.Position = new Point(oldman.X, oldman.Y);
			*/
		}


	}
}