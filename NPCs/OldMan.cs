using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
	class OldMan : CollideableObject, INPC
	{
		private ISprite sprite;
		public bool damaged;

		public OldMan()
		{
			sprite = EnemySpriteFactory.Instance.CreateOldManSprite();
			X = 240;
			Y = 130;
			sprite.Position = new Point(X, Y);
			Hitbox = sprite.Box;
		}

		public void Update()
		{
			sprite.Update();
		}

		public void Draw(SpriteBatch spriteBatch, Color color)
		{
			sprite.Draw(spriteBatch, color);
		}

		public void TakeDamage()
		{
			damaged = true;
		}
	}
}
