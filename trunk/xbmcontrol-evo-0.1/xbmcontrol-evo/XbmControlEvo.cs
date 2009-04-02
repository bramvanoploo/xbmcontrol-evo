
using System;
using System.IO;
using System.Reflection;
using Gtk;
using Glade;
using XBMC;
using xbmcontrolevo;

namespace xbmcontrolevo
{		
	public class XbmControlEvo
	{

		public static void Main (string[] args)
		{
			new XbmControlEvo (args);
		}
		
		//Objects
		public XBMC_Communicator oXbmc;
		public ShareBrowser oShareBrowser;
		public FileBrowser oFileBrowser;
		public ContextMenu oContextMenu;
		public MenuItems oMenuItems;
		public Controls oControls;
		public Playlist oPlaylist;
		public HelperFunctions oHelper;
		public StatusUpdate oStatusUpdate;
		public SysTrayIcon oSysTrayIcon;
		public GenreBrowser oGenreBrowser;
		public ArtistBrowser oArtistBrowser;
		public AlbumBrowser oAlbumBrowser;
		public Configuration oConfiguration;
		public Images oImages;
		
		//Settings
		public string theme;
		private bool isConnected;
		public string appDir;
		public string interfaceDir;
		public bool DEBUG;
		
		public XbmControlEvo (string[] args)
		{
			DEBUG = true;
			Application.Init();
			theme 		= "default";
			isConnected = false;
			appDir		= Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
			interfaceDir= appDir + "/Interface/";
			
			Glade.XML wMainWindowXml = new Glade.XML (interfaceDir + theme + ".glade", null, null);
			wMainWindowXml.Autoconnect(this);

			InitObjects();
			XbmcConnect();
			Application.Run();
		}
		
		//Window
		[Glade.Widget] internal Window MainWindow;
		
		//[Widget] Gtk.Image ibPrevious;
		
		//ComboBox
		[Glade.Widget] internal ComboBox cbShares;
		[Glade.Widget] internal ComboBox cbPlaylist;
		
		//NoteBook
		[Glade.Widget] internal Notebook nbLeft;
		[Glade.Widget] internal Notebook nbRight;
		
		//ToggleButton
		[Glade.Widget] internal ToggleButton tbMute;
		[Glade.Widget] internal ToggleButton bStop;
		
		//HScale
		[Glade.Widget] internal HScale hsProgress;
		[Glade.Widget] internal HScale hsVolume;
		
		//Image
		[Glade.Widget] internal Image iConnectionStatus;
		[Glade.Widget] internal Image ibPrevious;
		[Glade.Widget] internal Image ibPlay;
		[Glade.Widget] internal Image ibStop;
		[Glade.Widget] internal Image ibNext;
		
		//Label
		[Glade.Widget] internal Label lStatus;
		
		//Entry
		[Glade.Widget] internal Entry eArtistsFilter;
		[Glade.Widget] internal Entry eAlbumsFilter;
		[Glade.Widget] internal Entry eIpAddress;
		[Glade.Widget] internal Entry eUsername;
		[Glade.Widget] internal Entry ePassword;
		
		//SpinButton
		[Glade.Widget] internal SpinButton sbUpdateInterval;
		[Glade.Widget] internal SpinButton sbConnectionTimeout;
		
		//CheckButton
		[Glade.Widget] internal CheckButton chbShowInSystemTray;
		[Glade.Widget] internal CheckButton chbShowInTaskbar;
		
		//TreeView
		[Glade.Widget] internal TreeView tvShares;
		[Glade.Widget] internal TreeView tvGenres;
		[Glade.Widget] internal TreeView tvArtists;
		[Glade.Widget] internal TreeView tvAlbums;
		[Glade.Widget] internal TreeView tvSongs;
		[Glade.Widget] internal TreeView tvVideos;
		[Glade.Widget] internal TreeView tvPlaylist;
		[Glade.Widget] internal TreeView tvFiles;
		
		
		/// <summary>
	    ///  Initialise objects
	    /// </summary>
		private void InitObjects ()
		{
			oImages			= new Images(this);
			oHelper			= new HelperFunctions(this);
			oConfiguration 	= new Configuration(this);
			oXbmc 			= new XBMC_Communicator();
			oShareBrowser 	= new ShareBrowser(this);
			oFileBrowser	= new FileBrowser(this);
			oMenuItems		= new MenuItems(this);
			oContextMenu	= new ContextMenu(this);
			oSysTrayIcon 	= new SysTrayIcon(this);
			oControls		= new Controls(this);
			oPlaylist		= new Playlist(this);
			oGenreBrowser	= new GenreBrowser(this);
			oArtistBrowser 	= new ArtistBrowser(this);
			oAlbumBrowser	= new AlbumBrowser(this);
			oStatusUpdate	= new StatusUpdate(this);
		}
		
		private void XbmcConnect ()
		{
			oStatusUpdate.Stop();
			if (oConfiguration.values.ipAddress != "")
			{
				oXbmc.SetIp(oConfiguration.values.ipAddress);
		        oXbmc.SetConnectionTimeout(Convert.ToInt32(oConfiguration.values.connectionTimeout) * 1000);
		        oXbmc.SetCredentials(oConfiguration.values.username, oConfiguration.values.password);
				this.isConnected = (oXbmc.Status.WebServerEnabled()) ? true : false ;
				
				if (IsConnected())
				{
					if (!oStatusUpdate.IsRunning()) 
						oStatusUpdate.Start();
					SetStartupvalues();
					oStatusUpdate = new StatusUpdate(this);
				}
				else
				{
					oStatusUpdate.Stop();
					oHelper.Messagebox("Could not connect to XBMC with the current configuration.");
					nbRight.CurrentPage = 3;
				}
			}
			else
			{
				oStatusUpdate.Stop();
				oHelper.Messagebox("Configure XBMControl to connect with XBMC.");
				nbRight.CurrentPage = 3;
			}
		}

		public void SetConnected (bool connected)
		{
			this.isConnected = connected;
		}
		
		public bool IsConnected ()
		{
			return this.isConnected;
		}
		
		private void SetStartupvalues ()
		{
			cbShares.Active 			= 0;
			cbPlaylist.Active 			= 0;
			MainWindow.SkipTaskbarHint 	= oConfiguration.values.showInTaskbar;
			
			if (oConfiguration.values.showInSystemTray)
				oSysTrayIcon.Show();
			else
				oSysTrayIcon.Hide();
			
			this.ApplyTheme();
		}
		
		protected void ApplyTheme ()
		{
			MainWindow.Icon	= oImages.menu.icon;
			ibPrevious			= new Image(oImages.button.previous);
			ibPlay				= new Image(oImages.button.play);
			ibStop				= new Image(oImages.button.stop);
			ibNext				= new Image(oImages.button.next);
		}
		
		protected void on_MainWindow_delete_event (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
		
		protected void on_cbShares_changed (object o, EventArgs args)
		{
			if (this.IsConnected())
			{
				try
				{
					this.oShareBrowser.SetCurrentShareType(this.cbShares.Active);
					this.oShareBrowser.Populate();
				}
				catch (Exception e)
				{
					oHelper.Messagebox(e.Message);
				}
			}
		}
		
		protected void on_tvShares_button_release_event (object o, Gtk.ButtonReleaseEventArgs args)
		{
			if (this.IsConnected())
			{
				if (args.Event.Button == 1)
					oShareBrowser.ExpandSelectedDirectory();
				else if (args.Event.Button == 3)
					oShareBrowser.ShowContextMenu();
			}
		}
		
		protected void on_tvArtists_button_release_event (object o, Gtk.ButtonReleaseEventArgs args)
		{
			if (this.IsConnected())
			{
				if (args.Event.Button == 1)
					oArtistBrowser.ExpandeSelectedItem();
				else if (args.Event.Button == 3)
					oArtistBrowser.ShowContextMenu();
			}
		}
		
		protected void on_tvAlbums_button_release_event (object o, Gtk.ButtonReleaseEventArgs args)
		{
			if (this.IsConnected())
			{
				if (args.Event.Button == 1)
					oAlbumBrowser.GetAlbumSongs();
				else if (args.Event.Button == 3)
					oAlbumBrowser.ShowContextMenu();
			}
		}
		
		protected void on_tvFiles_button_release_event (object o, Gtk.ButtonReleaseEventArgs args)
		{
			if (this.IsConnected())
				if (args.Event.Button == 3) oFileBrowser.ShowContextMenu();
		}
		
		protected void on_tvPlaylist_button_release_event (object o, Gtk.ButtonReleaseEventArgs args)
		{
			if (this.IsConnected())
				if (args.Event.Button == 3) oPlaylist.ShowContextMenu();
		}
		
		protected void on_hsVolume_value_changed (object o, EventArgs args)
		{
			if (this.IsConnected())
			{
				if (hsVolume.HasFocus)
				{
					oXbmc.Controls.SetVolume(Convert.ToInt32(hsVolume.Value));
					hsVolume.TooltipText = Math.Floor((double) hsVolume.Value).ToString()+"%";
				}
			}
		}
		
		protected void on_hsProgress_value_changed (object o, EventArgs args)
		{
			if (this.IsConnected())
				if (hsProgress.HasFocus) oXbmc.Controls.SeekPercentage(Convert.ToInt32(hsProgress.Value));
		}
		
		protected void on_cbPlaylist_changed (object o, EventArgs args)
		{
			if (this.IsConnected()) oPlaylist.SetCurrentPlaylistType(cbPlaylist.Active.ToString());
		}
		
		protected void on_nbLeft_switch_page (object o, Gtk.SwitchPageArgs args)
		{
			if (this.IsConnected())
			{
				if (args.PageNum == 0)
					oShareBrowser.Populate();
				else if (args.PageNum == 1)
					oGenreBrowser.Populate();
				else if (args.PageNum == 2)
					oArtistBrowser.Populate();
				else if (args.PageNum == 3)
					oAlbumBrowser.Populate();
			}
		}
		
		protected void on_nbRight_switch_page (object o, Gtk.SwitchPageArgs args)
		{
			if (this.IsConnected())
			{
				if (args.PageNum == 2) 
					oPlaylist.SelectNowPlayingEntry();	
			}
		}
		
		protected void on_eArtistsFilter_changed (object o, EventArgs args)
		{
			if (this.IsConnected()) oArtistBrowser.Populate(eArtistsFilter.Text);
		}
		
		protected void on_eAlbumsFilter_changed (object o, EventArgs args)
		{
			if (this.IsConnected()) oAlbumBrowser.Populate(eAlbumsFilter.Text);
		}
		
		protected void on_tbMute_released (object o, EventArgs args)
		{
			if (this.IsConnected()) oXbmc.Controls.ToggleMute();
		}
		
		protected void on_bPrevious_released (object o, EventArgs args)
		{
			if (this.IsConnected()) oXbmc.Controls.Previous();
		}
		
		protected void on_bPlay_released (object o, EventArgs args)
		{
			if (this.IsConnected()) oXbmc.Controls.Play();
		}
		
		protected void on_bStop_released (object o, EventArgs args)
		{
			if (this.IsConnected()) oXbmc.Controls.Stop();
		}
		
		protected void on_bNext_released (object o, EventArgs args)
		{
			if (this.IsConnected()) oXbmc.Controls.Next();
		}
		
		protected void on_bPlaylistClear_clicked (object o, EventArgs args)
		{
			if (this.IsConnected()) oPlaylist.Clear();
		}
		
		protected void on_bPlaylistRemove_clicked (object o, EventArgs args)
		{
			if (this.IsConnected()) oPlaylist.RemoveSelectedItems();
		}
		
		protected void on_bPlaylistRefresh_clicked (object o, EventArgs args)
		{
			if (this.IsConnected()) oPlaylist.Refresh();
		}
		
		protected void on_iConnectionStatus_button_release_event (object o, Gtk.ButtonReleaseEventArgs args)
		{
			if (!IsConnected())
			{
				iConnectionStatus.SetFromStock("gtk-connect", IconSize.Menu);
				oStatusUpdate.Start();
			}
			
			oHelper.Messagebox("test");
		}
		
		protected void on_bConfigurationSave_released (object o, EventArgs args)
		{
			this.oConfiguration.Save();
			this.XbmcConnect();
			if (IsConnected()) nbRight.CurrentPage = 0;
		}
	}
}