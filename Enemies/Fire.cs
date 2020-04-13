using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
	class Fire : Enemy
	{
		private int timer;
		private LegendOfZelda game;

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
			if (game.OldManDamaged)
			{
				if (timer % 150 == 0)
				{
					ICommand fire = new ShootFireballCommand(game.ProjectileManager, this, game.link);
					fire.Execute();
				}
				timer++;
			}
			base.Update();
		}
		

	}
}
