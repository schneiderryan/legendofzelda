using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class MusicLoop : IUpdateable
    {
        IList<(Song, float)> songs;
        int current;

        public MusicLoop()
        {
            current = 0;
            songs = new List<(Song, float)>()
            {
                (Sounds.GetDungeonSong(), 1),
                (Sounds.GetDungeonSong2(), 0.3f),
                (Sounds.GetDungeonSong3(), 0.2f),
            };
        }

        public void Play()
        {
            if (MediaPlayer.State == MediaState.Paused)
            {
                MediaPlayer.Resume();
            }
            else if (MediaPlayer.State == MediaState.Stopped)
            {
                MediaPlayer.Volume = songs[current].Item2;
                MediaPlayer.Play(songs[current].Item1);
            }
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
                Play();
            }
        }
    }
}
