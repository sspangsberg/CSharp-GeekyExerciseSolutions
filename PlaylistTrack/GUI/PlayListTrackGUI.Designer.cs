namespace PlaylistTrack.GUI
{
    partial class PlayListTrackGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTracks = new System.Windows.Forms.ListBox();
            this.gbTrackData = new System.Windows.Forms.GroupBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbPlaylistTracks = new System.Windows.Forms.GroupBox();
            this.gbTrackData.SuspendLayout();
            this.gbPlaylistTracks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTracks
            // 
            this.lbTracks.FormattingEnabled = true;
            this.lbTracks.ItemHeight = 16;
            this.lbTracks.Location = new System.Drawing.Point(7, 58);
            this.lbTracks.Name = "lbTracks";
            this.lbTracks.Size = new System.Drawing.Size(234, 148);
            this.lbTracks.TabIndex = 0;
            // 
            // gbTrackData
            // 
            this.gbTrackData.Controls.Add(this.lblSeconds);
            this.gbTrackData.Controls.Add(this.lblMinutes);
            this.gbTrackData.Controls.Add(this.lblSongName);
            this.gbTrackData.Controls.Add(this.lblArtist);
            this.gbTrackData.Controls.Add(this.txtArtist);
            this.gbTrackData.Controls.Add(this.txtSeconds);
            this.gbTrackData.Controls.Add(this.txtSongName);
            this.gbTrackData.Controls.Add(this.txtMinutes);
            this.gbTrackData.Location = new System.Drawing.Point(255, 3);
            this.gbTrackData.Name = "gbTrackData";
            this.gbTrackData.Size = new System.Drawing.Size(504, 214);
            this.gbTrackData.TabIndex = 1;
            this.gbTrackData.TabStop = false;
            this.gbTrackData.Text = "Track Data";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(24, 59);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(457, 22);
            this.txtArtist.TabIndex = 2;
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(24, 115);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(457, 22);
            this.txtSongName.TabIndex = 3;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(88, 152);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(65, 22);
            this.txtMinutes.TabIndex = 4;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(259, 152);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(60, 22);
            this.txtSeconds.TabIndex = 5;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(21, 35);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(44, 17);
            this.lblArtist.TabIndex = 6;
            this.lblArtist.Text = "Artist:";
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(21, 95);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(86, 17);
            this.lblSongName.TabIndex = 7;
            this.lblSongName.Text = "Song Name:";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(21, 155);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(61, 17);
            this.lblMinutes.TabIndex = 8;
            this.lblMinutes.Text = "Minutes:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(186, 155);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(67, 17);
            this.lblSeconds.TabIndex = 9;
            this.lblSeconds.Text = "Seconds:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(255, 228);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 64);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 64);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(368, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 64);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(176, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbPlaylistTracks
            // 
            this.gbPlaylistTracks.Controls.Add(this.lbTracks);
            this.gbPlaylistTracks.Controls.Add(this.btnSearch);
            this.gbPlaylistTracks.Controls.Add(this.txtSearch);
            this.gbPlaylistTracks.Location = new System.Drawing.Point(2, 3);
            this.gbPlaylistTracks.Name = "gbPlaylistTracks";
            this.gbPlaylistTracks.Size = new System.Drawing.Size(248, 214);
            this.gbPlaylistTracks.TabIndex = 10;
            this.gbPlaylistTracks.TabStop = false;
            this.gbPlaylistTracks.Text = "Tracks";
            // 
            // PlayListTrackGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 308);
            this.Controls.Add(this.gbPlaylistTracks);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbTrackData);
            this.Name = "PlayListTrackGUI";
            this.Text = "PlayList";
            this.Load += new System.EventHandler(this.PlayListTrackGUI_Load);
            this.gbTrackData.ResumeLayout(false);
            this.gbTrackData.PerformLayout();
            this.gbPlaylistTracks.ResumeLayout(false);
            this.gbPlaylistTracks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTracks;
        private System.Windows.Forms.GroupBox gbTrackData;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbPlaylistTracks;
    }
}