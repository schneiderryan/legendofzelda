

namespace LegendOfZelda
{

    internal class ResetCommand : ICommand
    {
        private LegendOfZelda game;

        public ResetCommand(LegendOfZelda game)
        {
            this.game = game;
        }

            public void Execute()
            {

                game.list[0] = new Gel();
                game.list[1] = new Goriya();
                game.list[2] = new Keese();
                game.list[3] = new Stalfo();
                game.list[4] = new Trap();
                game.list[5] = new LFWallmaster();
                game.list[6] = new RFWallmaster();
                game.list[7] = new Aquamentus();
                game.index = 0;

                game.currentIndex = 0;
                game.currentItem = game.items[game.currentIndex];
                game.enemy = new Gel();
                game.link = new GreenLink(game);
                game.keyboarda = new KeyboardController(game, game.binds);
            }

        }
    }
