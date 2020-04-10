using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace LegendOfZelda
{
    public static class Sounds
    {
        private static SoundEffect attackEffect;

        private static SoundEffect enemyHit;
        private static SoundEffect enemyDie;

        private static SoundEffect linkHurt;
        private static SoundEffect linkDie;


        private static Song menusong;
        private static Song dungeonsong;
        


        public static void LoadAllSounds(ContentManager contentManager)
        {
            menusong = contentManager.Load<Song>("intro");
            dungeonsong = contentManager.Load<Song>("dungeonsong");
           

            attackEffect = contentManager.Load<SoundEffect>("LOZ_Sword_Slash");
            linkHurt = contentManager.Load<SoundEffect>("LOZ_Link_Hurt");
            linkDie = contentManager.Load<SoundEffect>("LOZ_Link_Die");
            enemyHit = contentManager.Load<SoundEffect>("LOZ_Enemy_Hit");
            enemyDie = contentManager.Load<SoundEffect>("LOZ_Enemy_Die");

        }

        public static SoundEffect GetEnemyDieSound()
        {
            return enemyDie;
        }

        public static SoundEffect GetEnemyHurtSound()
        {
            return enemyHit;
        }

        public static SoundEffect GetLinkDieSound()
        {
            return linkDie;
        }

        public static SoundEffect GetLinkHurtSound()
        {
            return linkHurt;
        }

        public static SoundEffect GetAttackSound()
        {
            return attackEffect;
        }

        public static Song GetMenuSong()
        {
            return menusong;
        }

        public static Song GetDungeonSong()
        {
            return dungeonsong;
        }


    }
}
