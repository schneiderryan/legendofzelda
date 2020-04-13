using Microsoft.Xna.Framework;


namespace LegendOfZelda
{
    class PlayerWallCollision : ICollision
    {
        private IPlayer player;
        private Rectangle wall;
        private LegendOfZelda game;
        public PlayerWallCollision(IPlayer player, in Rectangle wall, LegendOfZelda game)
        {
            this.game = game;
            this.player = player;
            this.wall = wall;
        }

        public void Handle()
        {
            Rectangle collision = Rectangle.Intersect(player.Footbox, wall);
           

            if (wall.Y == 108)
            {
                game.state = new StairRoomState(game, Stairs.StairDirection.Up);
            }
                else
                    {
                        if (collision.Width > collision.Height)
                        {
                            if (collision.Y == player.Footbox.Y)
                            {
                                player.Y += collision.Height;
                            }
                            else
                            {
                                player.Y -= collision.Height;
                            }
                        }
                        else
                        {
                            if (collision.X == player.Footbox.X)
                            {
                                player.X += collision.Width;
                            }
                            else
                            {
                                player.X -= collision.Width;
                            }
                        }
                    }
            
        }
    }
}