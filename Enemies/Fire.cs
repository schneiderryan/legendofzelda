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
			//Hitbox = new Rectangle(240, 130, Sprite.Box.Width, Sprite.Box.Height);
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			timer = 0;
			game = loz;
			currentHearts = 100;
			
		}
		
		public override void Update()
		{
			//Hitbox = new Rectangle(240, 130, Sprite.Box.Width, Sprite.Box.Height);
			//Sprite.Position = new Point(X, Y);
			
			if (game.OldManDamaged)
			{
				if (timer % 150 == 0)
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
					ICommand fire = new ShootFireballCommand(game.ProjectileManager, this, dir);
					fire.Execute();
				}
				timer++;
			}
			base.Update();
		}
		

	}
}
