﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LegendOfZelda;


namespace LegendOfZelda
{

	class UpMovingStalfoState : IStalfoState
	{
		private Stalfo stalfo;

		public UpMovingStalfoState(Stalfo stalfo)
		{
			this.stalfo = stalfo;
		}


		public void ChangeDirection()
		{
			//stalfo.state = new RightMovingStalfoState(stalfo);
			//add up and down directions based on a random number
		}

		public void BeKilled()
		{
			//stalfo.state = new KilledEnemyState(stalfo);
		}

		public void MoveUp()
		{
			//nothing
		}

		public void MoveDown()
		{
			stalfo.state = new DownMovingStalfoState(stalfo);
			stalfo.sprite = EnemySpriteFactory.Instance.CreateDownMovingStalfoSprite();
		}

		public void MoveRight()
		{
			stalfo.state = new RightMovingStalfoState(stalfo);
			stalfo.sprite = EnemySpriteFactory.Instance.CreateRightMovingStalfoSprite();
		}


		public void MoveLeft()
		{
			stalfo.state = new LeftMovingStalfoState(stalfo);
			stalfo.sprite = EnemySpriteFactory.Instance.CreateLeftMovingStalfoSprite();
		}

		public void Update()
		{
			stalfo.yPos -= 1;
			if (stalfo.yPos < 0)
			{
				stalfo.yPos += 480;
			}
			
			stalfo.sprite.Position = new Point(stalfo.xPos, stalfo.yPos);
		}


	}
}