using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
	class OldMan : NPC
	{
		private ISprite sprite;
		public bool damaged;
		protected int attackTimer { get; set; }
		private LegendOfZelda game; 

		public OldMan(LegendOfZelda game)
		{
			sprite = EnemySpriteFactory.Instance.CreateOldManSprite();
			X = 240;
			Y = 130;
			sprite.Position = new Point(X, Y);
			Hitbox = sprite.Box;
			this.game = game;
			attackTimer = 50;
		}

		public override void Update()
		{
			if(game.OldManDamaged)
			{
				damaged = true;
				if (attackTimer != 0)
				{
					attackTimer--;
				}
				if(attackTimer==0)
				{
					System.Diagnostics.Debug.WriteLine("OldMan should be done being damaged.");
					damaged = false;
				}
			}
			sprite.Update();
		}

		public override  void Draw(SpriteBatch spriteBatch, Color color)
		{
			Color hurt1 = new Color(83, 68, 198);
			if (damaged)
			{
				sprite.Draw(spriteBatch, hurt1);
			}
			else
			{
				sprite.Draw(spriteBatch, color);
			}
		}

		public void TakeDamage()
		{
			//damaged = true;
		}
	}
}
