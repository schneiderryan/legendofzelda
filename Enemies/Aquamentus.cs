using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
	class Aquamentus : RandomMovingEnemy
	{
		public bool Breathed { get; set; }
		public LegendOfZelda game;

		public int CurrentStep => currentStep;
		
		public Aquamentus(LegendOfZelda game)
			: base(10)
		{
			this.game = game;
			Sprite = EnemySpriteFactory.Instance.CreateMovingAquamentusSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new LeftMovingAquamentusState(this);
			Breathed = false;
			attackTimer = 100;
		}

	}
}
