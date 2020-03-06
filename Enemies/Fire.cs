using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
	class Fire : Enemy
	{
		private int timer;
		private LegendOfZelda game;
		private string dir;
		public Fire(LegendOfZelda loz, int xPos, int yPos)
		{
			Sprite = EnemySpriteFactory.Instance.CreateFireSprite();
			Hitbox = Sprite.Box;
			//X = 400;
			//Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			timer = 0;
			game = loz;
			currentHearts = 100;
		}
		
		public override void Update()
		{
			if(currentHearts<100)
			{
				if (timer % 200 == 0)
				{
					int linkXPos = game.link.X;
					int linkYPos = game.link.Y;
					if (linkYPos > Y)
					{
						if (linkXPos < (X + 10) && linkXPos > (X - 10))
						{
							dir = "down";
						}
						else if (linkXPos > X)
						{
							dir = "rightdown";
						}
						else
						{
							dir = "leftdown";
						}
					}
					ICommand fire = new ShootFireballCommand(game.projectiles, this, dir);
					fire.Execute();
				}
				timer++;
			}
			//currentHearts = 100;
			base.Update();
		}
		

	}
}
