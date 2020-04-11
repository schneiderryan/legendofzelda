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

        private static SoundEffect bossHurt;
        private static SoundEffect bossDie;

        private static SoundEffect keyAppearance;
        private static SoundEffect itemObtained;

        private static SoundEffect stairs;
        private static SoundEffect secret;
        private static SoundEffect lowHealth;
        private static SoundEffect doorUnlock;
        

        private static Song menusong;
        private static Song dungeonsong;
        


        public static void LoadAllSounds(ContentManager contentManager)
        {
            menusong = contentManager.Load<Song>("intro");
            dungeonsong = contentManager.Load<Song>("dungeonsong");
           
            itemObtained = contentManager.Load<SoundEffect>("LOZ_Get_Item");
            keyAppearance = contentManager.Load<SoundEffect>("LOZ_Key_Appear");
            attackEffect = contentManager.Load<SoundEffect>("LOZ_Sword_Slash");
            linkHurt = contentManager.Load<SoundEffect>("LOZ_Link_Hurt");
            linkDie = contentManager.Load<SoundEffect>("LOZ_Link_Die");
            enemyHit = contentManager.Load<SoundEffect>("LOZ_Enemy_Hit");
            enemyDie = contentManager.Load<SoundEffect>("LOZ_Enemy_Die");

            bossHurt = contentManager.Load<SoundEffect>("LOZ_Boss_Scream1");


            stairs = contentManager.Load<SoundEffect>("LOZ_Stairs");
            secret = contentManager.Load<SoundEffect>("LOZ_Secret");
            lowHealth = contentManager.Load<SoundEffect>("LOZ_LowHealth");
            doorUnlock = contentManager.Load<SoundEffect>("LOZ_Door_Unlock");

        }

        
        

        public static SoundEffect GetBossHurtSound()
        {
            return bossHurt;
        }
        public static SoundEffect GetKeyAppearedSound()
        {
            return keyAppearance;
        }

        public static SoundEffect GetItemObtainedSound()
        {
            return itemObtained;
        }
        
        public static SoundEffect GetSecretSound()
        {
            return secret;
        }
        public static SoundEffect GetLowHealthSound()
        {
            return lowHealth;
        }
        public static SoundEffect GetDoorUnlockSound()
        {
            return doorUnlock;
        }
        public static SoundEffect GetStairSound()
        {
            return stairs;
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
