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
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			timer = 0;
			game = loz;
			currentHearts = 100;
		}
		
		public override void Update()
		{
			if(currentHearts < 100)
			{
				if (timer % 200 == 0)
				{
					ICommand fire = new ShootFireballCommand(game.ProjectileManager, this, this.game.link);
					fire.Execute();
				}
				timer++;
			}
			base.Update();
		}

	}
}
