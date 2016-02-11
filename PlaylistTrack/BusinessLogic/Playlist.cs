#region Imports

//C# imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Project imports

#endregion

namespace PlaylistTrack.BusinessLogic
{
    class Playlist
    {
        #region Class Variables

        public String PlaylistName { get; set; }
        private List<Track> tracks = new List<Track>();

        public List<Track> Tracks
        {
            get { return tracks; }
        }

        #endregion

        #region Class Constructor

        public Playlist(String playlistName)
        {
            PlaylistName = playlistName;
        }

        #endregion

        #region Class Methods

        public void AddTrack(Track t)
        {
            tracks.Add(t);
        }

        public void RemoveTrack(Track t)
        {
            tracks.Remove(t);
        }       


        public Track FindShortestTrack()
        {            
            if (tracks.Count > 0)
            {
                
                Track shortest = tracks[0];
                
                for (int i = 0; i < tracks.Count; i++)
                {
                    Track tmp = tracks[i];
                    int totalSecs = (tmp.Minutes * 60) + tmp.Seconds;
                    int bestCandidateTotalSecs = (shortest.Minutes * 60) + shortest.Seconds;

                    if (totalSecs < bestCandidateTotalSecs)
                        shortest = tracks[i];
                }
                
                return shortest as Track;
            }

            return null;
        }

        #endregion
    }
}
