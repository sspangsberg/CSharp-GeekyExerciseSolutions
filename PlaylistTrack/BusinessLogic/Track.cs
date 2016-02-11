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
    class Track : IComparable<Track>
    {
        #region Class Variables

        public String Artist { get; set; }
        public String SongName { get; set; }
        public int Seconds { get; set; }
        public int Minutes { get; set; }

        #endregion

        #region Class Constructor

        public Track(String artist, String songName, int minutes, int seconds)
        {
            Artist = artist;
            SongName = songName;
            Minutes = minutes;
            Seconds = seconds;
        }

        #endregion

        #region Class Methods

        public int CompareTo(Track other)
        {            
            int compare = this.Artist.CompareTo(other.Artist);

            if (compare == 0)
                compare = this.SongName.CompareTo(other.SongName);

            /*

            int totalSecsThis = (Minutes * 60) + Seconds;
            int totalSecsOther = (other.Minutes * 60) + other.Seconds;

            compare = totalSecsThis.CompareTo(totalSecsOther);
            
              
            */
            return compare;
        }

        public override string ToString()
        {
            return SongName + ": " + Artist + " (" + Minutes + ":" + String.Format("{0:00}", Seconds) + ")";
        }

        #endregion
    }
}
