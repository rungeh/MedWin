using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedWin
{
    public partial class MedWin : Form
    {
        public MedWin()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MediaControl.VolUp(this.Handle);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MediaControl.VolDown(this.Handle);
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            MediaControl.VolMute(this.Handle);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MediaControl.PlayPauseMedia();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MediaControl.NextTrack();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            MediaControl.PreviousTrack();
        }
    }
}
