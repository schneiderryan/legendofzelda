using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
	class OldMan : CollideableObject, INPC
	{
		private ISprite sprite;

		public OldMan()
		{
			sprite = EnemySpriteFactory.Instance.CreateOldManSprite();
			Hitbox = sprite.Box;
			X = 240;
			Y = 130;
			sprite.Position = new Point(X, Y);
		}

		public void Update()
		{
			sprite.Update();
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch);
		}
	}
}
