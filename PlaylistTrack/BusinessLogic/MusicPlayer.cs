#region Imports

//C# imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

//Project imports

#endregion

namespace PlaylistTrack.BusinessLogic
{
    class MusicPlayer
    {
        #region Class Methods

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);
                

        public void Open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }


        public void PlayMP3()
        {
            /*
            //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "My MP3 file.mp3";
            wplayer.Controls.Play();

            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);
             * */
        }


        public void Stop()
        {
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            command = "close MyMp3";
            mciSendString(command, null, 0, 0);
        }

        #endregion
    }
}
