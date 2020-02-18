﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class LeftMovingKeeseState : IKeeseState
	{
		private Keese keese;

		public LeftMovingKeeseState(Keese keese)
		{
			this.keese = keese;
		}


		public void ChangeDirection()
		{
			//keese.state = new RightMovingkeeseState(keese);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//keese.state = new KilledEnemyState(keese);
		}

		public void MoveUp()
		{
			keese.state = new UpMovingKeeseState(keese);
			keese.sprite = EnemySpriteFactory.Instance.CreateUpMovingKeeseSprite();
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
			
		}

		public void Update()
		{
			keese.X -= 1;
			if (keese.X < 0)
			{
				keese.X += 800;
			}
			keese.sprite.Position = new Point(keese.X, keese.Y);
		}


	}
}