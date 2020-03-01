using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
	class OldMan : CollideableObject, INPC
	{
		private ISprite sprite;

		public OldMan(int x, int y)
		{
			sprite = EnemySpriteFactory.Instance.CreateOldManSprite();
			Hitbox = sprite.Box;
			X = x;
			Y = y;
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