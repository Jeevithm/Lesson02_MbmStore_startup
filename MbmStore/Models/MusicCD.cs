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
        private List<string> tracks = new List<string>();


        public List<string> Tracks
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

        public void AddTrack (string track)
        {
            tracks.Add(track);
        }

     
    }
}