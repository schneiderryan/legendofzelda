using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LegendOfZelda
{
    class RoomController : IController
    {
        static ICommand cmdLeft;
        static ICommand cmdRight;
        static ICommand cmdUp;
        static ICommand cmdDown;

        public RoomController(LegendOfZelda game)
        {
            cmdRight = new SwapRoomCommand(game, "next");
            cmdLeft = new SwapRoomCommand(game, "previous");
            cmdUp = new SwapRoomCommand(game, "up");
            cmdDown = new SwapRoomCommand(game, "down");
        }
        public void Update()
        {
            //still need to add logic here. Is there a way for me to use this controller so i don't have to pass the game object through the collision handler/detector? 
            //I need the game scope in order to change the roomIndex when Link hits the edge of a room through and open door

        }
    }
}