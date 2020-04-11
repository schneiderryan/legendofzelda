using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class NotBreathingAquamentusState : AquamentusState
    {
		private int fireTimer;

		public NotBreathingAquamentusState(Aquamentus aquamentus) : base(aquamentus)
		{
			aquamentus.Sprite = EnemySpriteFactory.Instance.CreateMovingAquamentusSprite();
			aquamentus.Sprite.Position = new Point(aquamentus.X, aquamentus.Y);
			fireTimer = 120; // ~2sec
		}

		public override void Update()
		{
			base.Update();
			fireTimer--;
			if (fireTimer < 0)
			{
				aquamentus.State = new BreathingAqumentusState(aquamentus);
			}
		}
	}
}
