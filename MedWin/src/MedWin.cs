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
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;

        /// <summary>
        /// Initializes a new instance of the <see cref="MedWin"/> class.
        /// </summary>
        public MedWin()
        {
            // Initialize components container
            this.components = new System.ComponentModel.Container();

            // Create context menu and menu items
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();

            // Add menu items to context menu
            this.contextMenu.MenuItems.AddRange(
                        new System.Windows.Forms.MenuItem[] { this.menuItem1, this.menuItem2 });

            // Configure menu item 1 (Play/Pause)
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Play/Pause";
            this.menuItem1.Click += new System.EventHandler(this.menuPlay_Click);

            // Configure menu item 2 (Exit)
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Exit";
            this.menuItem2.Click += new System.EventHandler(this.menuExit_Click);

            // Create and configure notify icon
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            notifyIcon.Icon = new Icon("1326.ico");
            notifyIcon.ContextMenu = this.contextMenu;
            notifyIcon.Text = "MedWin media controller";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);

            // Initialize form components
            InitializeComponent();
        }

        /// <summary>
        /// Handles the DoubleClick event of the notifyIcon control.
        /// Restores the window if it is minimized.
        /// </summary>
        /// <param name="Sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void notifyIcon1_DoubleClick(object Sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Activate();
        }

        /// <summary>
        /// Handles the Click event of the menuPlay control.
        /// Toggles play/pause of the media.
        /// </summary>
        /// <param name="Sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void menuPlay_Click(object Sender, EventArgs e)
        {
            MediaControl.PlayPauseMedia();
        }

        /// <summary>
        /// Handles the Click event of the menuItem2 control.
        /// Exits the application.
        /// </summary>
        /// <param name="Sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void menuExit_Click(object Sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the btnUp control.
        /// Increases the volume.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            MediaControl.VolUp(this.Handle);
        }

        /// <summary>
        /// Handles the Click event of the btnDown control.
        /// Decreases the volume.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            MediaControl.VolDown(this.Handle);
        }

        /// <summary>
        /// Handles the Click event of the btnMute control.
        /// Mutes or unmutes the volume.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnMute_Click(object sender, EventArgs e)
        {
            MediaControl.VolMute(this.Handle);
        }

        /// <summary>
        /// Handles the Click event of the btnPlay control.
        /// Toggles play/pause of the media.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            MediaControl.PlayPauseMedia();
        }

        /// <summary>
        /// Handles the Click event of the btnNext control.
        /// Skips to the next track.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            MediaControl.NextTrack();
        }

        /// <summary>
        /// Handles the Click event of the btnPrv control.
        /// Goes back to the previous track.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnPrv_Click(object sender, EventArgs e)
        {
            MediaControl.PreviousTrack();
        }
    }
}
