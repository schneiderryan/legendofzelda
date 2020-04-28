using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;


namespace LegendOfZelda
{
    static class GameSetup
    {
        public static IController CreatePlayerMovementController(IPlayer player)
        {
            KeyboardController controller = new KeyboardController();
            ICommand cmd;

            cmd = new PlayerMoveLeftCommand(player);
            controller.Register(Keys.Left, cmd);
            controller.Register(Keys.A, cmd);

            cmd = new PlayerMoveRightCommand(player);
            controller.Register(Keys.Right, cmd);
            controller.Register(Keys.D, cmd);

            cmd = new PlayerMoveUpCommand(player);
            controller.Register(Keys.Up, cmd);
            controller.Register(Keys.W, cmd);

            cmd = new PlayerMoveDownCommand(player);
            controller.Register(Keys.Down, cmd);
            controller.Register(Keys.S, cmd);

            cmd = new PlayerStillCommand(player);
            controller.Register(Keys.None, cmd);

            return controller;
        }

        public static IController CreateSinglePressKeysController(LegendOfZelda game)
        {
            IDictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();
            ICommand cmd;

            cmd = new PlayerAttackCommand(game.Link);
            keyBinds.Add(Keys.Z, cmd);
            keyBinds.Add(Keys.N, cmd);

            //item Commands

            cmd = new PlayerUseCurrentItemCommand(game.Link, game.ProjectileManager);
            keyBinds.Add(Keys.D2, cmd);
            keyBinds.Add(Keys.NumPad2, cmd);
            keyBinds.Add(Keys.B, cmd);

            cmd = new ResetCommand(game);
            keyBinds.Add(Keys.R, cmd);

            cmd = new QuitCommand(game);
            keyBinds.Add(Keys.Q, cmd);

            cmd = new PauseGameCommand(game);
            keyBinds.Add(Keys.P, cmd);

            cmd = new InventoryTransitionCommand(game);
            keyBinds.Add(Keys.I, cmd);

            cmd = new ItemShopTransitionCommand(game);
            keyBinds.Add(Keys.E, cmd);

            cmd = new InventoryMoveCommand(game, "left", game.Link);
            keyBinds.Add(Keys.H, cmd);

            cmd = new InventoryMoveCommand(game, "right", game.Link);
            keyBinds.Add(Keys.J, cmd);

            cmd = new AddKeyCommand(game.Link);
            keyBinds.Add(Keys.K, cmd);

            cmd = new AddBombCommand(game.Link);
            keyBinds.Add(Keys.L, cmd);

            cmd = new AddRupeesCommand(game.Link);
            keyBinds.Add(Keys.M, cmd);


            cmd = new SelectItemCommand(game, "down");
            keyBinds.Add(Keys.Down, cmd);


            cmd = new SelectItemCommand(game, "up");
            keyBinds.Add(Keys.Up, cmd);


            cmd = new PurchaseItemCommand(game);
            keyBinds.Add(Keys.Enter, cmd);

           

            return new SinglePressKeyboardController(keyBinds);
        }

        public static IController CreateSimpleKeysController(LegendOfZelda game)
        {
            IDictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();
            ICommand cmd;

            cmd = new ResetCommand(game);
            keyBinds.Add(Keys.R, cmd);

            cmd = new QuitCommand(game);
            keyBinds.Add(Keys.Q, cmd);

            return new SinglePressKeyboardController(keyBinds);
        }

        public static IController CreateMenuKeysController(LegendOfZelda game)
        {
            IDictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();
            ICommand cmd;

            cmd = new QuitCommand(game);
            keyBinds.Add(Keys.Q, cmd);

            cmd = new SelectModeCommand(game, "down");
            keyBinds.Add(Keys.Down, cmd);
            keyBinds.Add(Keys.S, cmd);

            cmd = new SelectModeCommand(game, "up");
            keyBinds.Add(Keys.Up, cmd);
            keyBinds.Add(Keys.W, cmd);

            cmd = new StartGameCommand(game);
            keyBinds.Add(Keys.Enter, cmd);



            return new SinglePressKeyboardController(keyBinds);
        }

       

        public static IList<IRoom> GenerateRoomList(LegendOfZelda game)
        {
            IList<IRoom> list = new List<IRoom>()
            {
                new Room(game, "Rooms/Room0.csv"),
                new Room(game, "Rooms/Room1.csv"),
                new Room(game, "Rooms/Room2.csv"),
                new Room(game, "Rooms/Room3.csv"),
                new Room(game, "Rooms/Room4.csv"),
                new Room(game, "Rooms/Room5.csv"),
                new Room(game, "Rooms/Room6.csv"),
                new Room(game, "Rooms/Room7.csv"),
                new Room(game, "Rooms/Room8.csv"),
                new Room(game, "Rooms/Room9.csv"),
                new Room(game, "Rooms/Room10.csv"),
                new Room(game, "Rooms/Room11.csv"),
                new Room(game, "Rooms/Room12.csv"),
                new Room(game, "Rooms/Room13.csv"),
                new Room(game, "Rooms/Room14.csv"),
                new Room(game, "Rooms/Room15.csv"),
                new Room(game, "Rooms/Room16.csv"),
                new Room(game, "Rooms/Room17.csv"),
            };

            return list;
        }
    }
}
