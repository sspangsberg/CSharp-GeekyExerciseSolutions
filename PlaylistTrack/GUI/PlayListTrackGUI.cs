using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlaylistTrack.BusinessLogic;

namespace PlaylistTrack.GUI
{
    public partial class PlayListTrackGUI : Form
    {
        public PlayListTrackGUI()
        {
            InitializeComponent();

            Setup();
        }

        private void Setup()
        {
            Track t1 = new Track("The Beatles", "Yellow Submarine", 2, 09);
            Track t2 = new Track("Metallica", "Nothing Else Matters", 6, 45);
            Track t3 = new Track("No band name", "The short song", 1, 45);


            Playlist pl = new Playlist("Misc songs");
            pl.AddTrack(t1);
            pl.AddTrack(t2);
            pl.AddTrack(t3);
            pl.Tracks.Sort();

            foreach (Track t in pl.Tracks)
            {
                lbTracks.Items.Add(t);
            }
        }

        private void PlayListTrackGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Search();
        }


        private void Search()
        {
            Track foundObject = null;

            foreach (Track t in lbTracks.Items)
            {
                if (txtSearch.Text.Trim() != "" && t.Artist.IndexOf(txtSearch.Text) != -1)
                {
                    foundObject = t;
                    break;
                }
            }

            if (foundObject != null)
                lbTracks.SelectedItem = foundObject;
        }
    }
}
