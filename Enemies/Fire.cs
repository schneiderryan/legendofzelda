using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
	class Fire : Enemy
	{
		public Fire()
		{
			Sprite = EnemySpriteFactory.Instance.CreateFireSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
		}

	}
}
