using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        private List<Track> tracks = new List<Track>();


        public List<Track> Tracks
        {
            get
            {
                return tracks;
            }
        }

        public MusicCD (string artist, string title, decimal price, short released, string imageUrl) : base(title, price, imageUrl)
        {
            Artist = artist;   
            Released = released;
        }

        public void AddTrack (Track track)
        {
            Tracks.Add(track);
        }

        public TimeSpan GetPlayingTime()
        {
            TimeSpan result = new TimeSpan(0, 0, 0);
            foreach (Track track in tracks)
            {
                result = track.Length + result;
            }

            return result;
        }


    }
}