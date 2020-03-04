using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
	class Fire : Enemy
	{
		private int timer;
		private LegendOfZelda game;
		private string dir;
		public Fire(LegendOfZelda loz)
		{
			Sprite = EnemySpriteFactory.Instance.CreateFireSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			timer = 0;
			game = loz;
			Name = "Fire";
		}
		
		public override void Update()
		{
			if(timer%10==0)
			{
				int linkXPos = game.link.X;
				int linkYPos = game.link.Y;
				if(linkYPos>Y)
				{
					if(linkXPos<(X+10)&& linkXPos>(X-10))
					{
						dir = "down";
					}
					else if(linkXPos>X)
					{
						dir = "rightdown"; 
					}
					else
					{
						dir = "leftdown";
					}
				}
				ICommand fire = new BreatheFireballCommand(game.projectiles, this);
				fire.Execute();
			}
			timer++;

			base.Update();
		}
		

	}
}
