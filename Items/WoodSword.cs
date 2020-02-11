using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class WoodSword : IItem
    {
        public enum SwordState { OnPlayer, OnGround, Thrown }
        public SwordState State { get; protected set; }

        protected const float VELOCITY = 12f;
        protected ISprite sprite;
        protected ISprite upSprite;
        protected ISprite rightSprite;
        protected IProjectile thrownSword;

        public WoodSword()
        {
            upSprite = ItemSpriteFactory.GetWoodSwordUp();
            rightSprite = ItemSpriteFactory.GetWoodSwordRight();
            sprite = upSprite;
            State = SwordState.OnPlayer;
        }

        public void ThrowLeft(Vector2 position)
        {
            State = SwordState.Thrown;
            sprite = rightSprite;
            sprite.Effects = SpriteEffects.FlipHorizontally;
            thrownSword = new Projectile(sprite, position, new Vector2(-VELOCITY, 0));
        }

        public void ThrowRight(Vector2 position)
        {
            State = SwordState.Thrown;
            sprite = rightSprite;
            sprite.Effects = SpriteEffects.None;
            thrownSword = new Projectile(sprite, position, new Vector2(VELOCITY, 0));
        }

        public void ThrowUp(Vector2 position)
        {
            State = SwordState.Thrown;
            sprite = upSprite;
            sprite.Effects = SpriteEffects.None;
            thrownSword = new Projectile(sprite, position, new Vector2(0, -VELOCITY));
        }

        public void ThrowDown(Vector2 position)
        {
            State = SwordState.Thrown;
            sprite = upSprite;
            sprite.Effects = SpriteEffects.FlipVertically;
            thrownSword = new Projectile(sprite, position, new Vector2(0, VELOCITY));
        }

        public void BeOnGround()
        {
            State = SwordState.OnGround;
        }

        public void BeOnPlayer()
        {
            State = SwordState.OnPlayer;
        }

        public void Draw(SpriteBatch sb)
        {
            if (State == SwordState.OnGround)
            {
                sprite.Draw(sb, Color.White);
            }
            else if (State == SwordState.Thrown)
            {
                thrownSword.Draw(sb);
            }
        }

        public void Update()
        {
            if (State == SwordState.Thrown)
            {
                thrownSword.Update();
            }
        }
    }
}
