﻿namespace LegendOfZelda
{
    public class BreatheFireballCommand : ICommand
    {
        
        private IEnemy aquamentus;

        public BreatheFireballCommand(LegendOfZelda game, IEnemy aquamentus)
        {
            this.aquamentus = aquamentus;
           
        }

        public void Execute()
        {
            aquamentus.UseProjectile(new FireballProjectile("leftup", aquamentus.xPos, aquamentus.yPos+10));
            aquamentus.UseProjectile(new FireballProjectile("left", aquamentus.xPos, aquamentus.yPos));
            aquamentus.UseProjectile(new FireballProjectile("leftdown", aquamentus.xPos, aquamentus.yPos-10));
        }
    }
}