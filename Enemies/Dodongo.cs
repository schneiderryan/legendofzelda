using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
	class Dodongo : RandomMovingEnemy
	{
		public Dodongo()
		{
			//dodongos eat bombs then they explode and the enemy is hurt but not dead yet, takes 3 bombs 
			Sprite = EnemySpriteFactory.Instance.CreateDownMovingDodongoSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new DownMovingDodongoState(this);
			attackTimer = 100;
		}
	}
}