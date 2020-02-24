using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{

    class BoomerangProjectile :  IProjectile
    {
        public enum BoomerangState { thrown, returning, pocket};
        public BoomerangState State { get; private set; }
        public int VX { get; set; }
        public int VY { get; set; }
        protected ISprite sprite;
        protected IPlayer player;
        public Rectangle Hitbox { get; }

        public BoomerangProjectile(string direction, int xPos, int yPos, IPlayer incomingPlayer,
            int initialVel = 6)
        {
            this.sprite = ProjectileSpriteFactory.Instance.CreateBoomerang();
            VX = 0;
            VY = 0;
            X = xPos;
            Y = yPos;
            finalPositionX = X;
            finalPositionY = Y;
            Hitbox = sprite.Box;
            player = incomingPlayer;
            if (direction == "up")
            {
                this.VY = -initialVel;
                finalPosition = new Point(finalPositionX, finalPositionY -= 144);
            }
            else if (direction == "down")
            {
                this.VY = initialVel;
                finalPosition = new Point(finalPositionX, finalPositionY += 144);
            }
            else if (direction == "right")
            {
                this.VX = initialVel;
                finalPosition = new Point(finalPositionX += 144, finalPositionY);
            }
            else if (direction == "left")
            {
                this.VX = -initialVel;
                finalPosition = new Point(finalPositionX -= 144, finalPositionY);
            }
        }

        public virtual int X { get; protected set; }
        public virtual int Y { get; protected set; }

        private int finalPositionX;
        private int finalPositionY;
        private Point finalPosition;

        public virtual void Update()
        {

            if (State == BoomerangState.thrown)
            {
               
                if (sprite.Position.X == finalPosition.X && finalPosition.Y == sprite.Position.Y)
                {
                    State = BoomerangState.returning;
                }
            }
            else if (State == BoomerangState.returning)
            {
                int LinksXPos = this.player.xPos + 5;
                int LinksYPos = this.player.yPos + 5;
                this.VX = (LinksXPos - X) / 20;
                this.VY = (LinksYPos - Y) / 20;
            }
            X += VX;
            Y += VY;
            sprite.Position = new Point(X, Y);
            sprite.Update();
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb, Color.White);
        }
    }
}

