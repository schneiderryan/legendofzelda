using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System.Text;


namespace LegendOfZelda
{
    class MusicLoop : IUpdateable
    {
        IList<Song> songs;
        int current;

        public MusicLoop()
        {
            current = 0;
            songs = new List<Song>()
            {
                Sounds.GetDungeonSong(),
            };

        }

        public void Play()
        {
            MediaPlayer.Play(songs[current]);
        }

        public void Pause()
        {
            MediaPlayer.Pause();
        }

        public void Update()
        {
            if (MediaPlayer.State == MediaState.Stopped)
            {
                current = (current + 1) % songs.Count;
                MediaPlayer.Play(songs[current]);
            }
        }
    }
}
