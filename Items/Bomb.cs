
namespace LegendOfZelda
{
    public class Bomb : Item
    {
        public enum BombState { Ready, Exploding, Done };
        public BombState State { get; private set; }

        public Bomb()
        {
            sprite = ItemSpriteFactory.GetBomb();
            sprite.Scale = 2;
            State = BombState.Ready;
        }

        public void Detonate()
        {
            // Real explosion doesn't look like this, but this is good for now
            sprite = ItemSpriteFactory.GetExplodingBomb();
            sprite.Scale = 4;
            State = BombState.Exploding;
        }

        public override void Update()
        {
            base.Update();
            if (State == BombState.Exploding
                && (sprite as AnimateOnceSprite).AnimationEnded)
            {
                State = BombState.Done;
            }
        }
    }
}
