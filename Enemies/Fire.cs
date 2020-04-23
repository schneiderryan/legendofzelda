using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
	class Fire : Enemy
	{
		private int timer;
		private LegendOfZelda game;
		private IDictionary<int, IPlayer> players;

		public Fire(LegendOfZelda loz, IDictionary<int, IPlayer> players)
		{
			game = loz;
			this.players = players;
			Sprite = EnemySpriteFactory.Instance.CreateFireSprite();
			Hitbox = Sprite.Box;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			timer = 0;
			currentHearts = 100;
		}
		
		public override void Update()
		{
			if (game.OldManDamaged)
			{
				if (timer % 150 == 0)
				{
					ICommand fire = new ShootFireballCommand(game.ProjectileManager, this, players.Values);
					fire.Execute();
				}
				timer++;
			}
			base.Update();
		}

	}
}
