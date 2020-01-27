using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class LineLoop : IPath
    {
        Point start;
        Point end;
        Vector2 velocity;
        Vector2 current;

        public Point Position { get; set; }

        public LineLoop(Point start, Point end, Vector2 velocity)
        {
            this.start = start;
            this.current = new Vector2(start.X, start.Y);
            this.Position = Vector2ToPoint(this.current);
            this.end = end;
            this.velocity = velocity;
        }

        public void Update()
        {
            current.X += velocity.X;
            current.Y += velocity.Y;

            Point val = Vector2ToPoint(current);
            if (val.X > end.X || val.Y > end.Y)
            {
                val = start;
                current.X = start.X;
                current.Y = start.Y;
            }
            Position = val;
        }

        private Point Vector2ToPoint(Vector2 v)
        {
            return new Point((int)v.X, (int)v.Y);
        }
    }
}
