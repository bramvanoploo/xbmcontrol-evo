
using System;
using GLib;
using Gtk;

namespace xbmcontrolevo
{
	
	public class StatusUpdate
	{
		private XbmControlEvo _parent;
		private bool firstRun;
		private string pathNowPlaying;
		
		public StatusUpdate(XbmControlEvo parent)
		{
			_parent 		= parent;
			firstRun 		= true;
			pathNowPlaying	= null;
			
			Start();
		}

		public void Start()
		{
			GLib.Timeout.Add(1000, new GLib.TimeoutHandler(Update) );
		}

		public bool Update()
		{
			if (_parent.oXbmc.Status.IsConnected())
			{
				_parent._iConnectionStatus.SetFromStock("gtk-yes", IconSize.Menu);
				_parent._iConnectionStatus.TooltipText	= "Connected to XBMC";
				_parent._lStatus.Text = "Connected to XBMC";
				
				bool showDefaults = (!_parent.oXbmc.Status.IsNotPlaying())? true : false;
				_parent.oXbmc.Controls.SetResponseFormat();

				if (!_parent._hsVolume.HasGrab) SetPbVolumePosition();
				if (!_parent._hsProgress.HasGrab) SetPbProgressPosition();
				_parent._hsProgress.TooltipText = _parent.oXbmc.NowPlaying.Get("time");
				_parent._hsVolume.TooltipText	= _parent.oXbmc.Status.GetVolume() + "%";
				
				SetButtonStatus();

				/*
				if ((_parent.oNowPlaying.GetInfoNowShowing() != _parent.oXbmc.NowPlaying.Get("filename") || _parent.oXbmc.Status.NewMediaPlaying() || firstRun) 
				    	&& _parent._nbDataContainer.CurrentPage == 0)
				{
					//_parent._fixedNowPlaying.Visible = false;
					//_parent._imgLoading.Visible = true;
					//_parent.oNowPlaying.ShowData();
					//_parent._imgLoading.Visible = false;
					//_parent._fixedNowPlaying.Visible = true;
					
					firstRun = false;
				}
				*/
				
				if (pathNowPlaying != _parent.oXbmc.NowPlaying.Get("filename"))
				{
					pathNowPlaying = _parent.oXbmc.NowPlaying.Get("filename");
					_parent.oPlaylist.Populate();
				}
				
				//_parent.oNowPlaying.ShowProgress(showDefaults);
				
				
				return true;
			}
			else
			{
				_parent._iConnectionStatus.SetFromStock("gtk-no", IconSize.Menu);
				_parent._iConnectionStatus.TooltipText	= "Click this icon to connect to XBMC";
				_parent._lStatus.Text = "Connection to XBMC lost";

				return false;
			}
		}
		
		private void SetPbVolumePosition()
		{
			_parent._hsVolume.Value = Convert.ToDouble(_parent.oXbmc.Status.GetVolume());
		}
		
		private void SetPbProgressPosition()
		{
			_parent._hsProgress.Value = Convert.ToDouble(_parent.oXbmc.Status.GetProgress());
			//_parent.oHelper.Messagebox(Convert.ToDouble(_parent.oXbmc.Status.GetProgress()).ToString());
		}
		
		private void SetButtonStatus()
		{
			/*
			if (_parent.oXbmc.Status.IsPlaying())
			{
				_parent._tbPlay.Active 		= true;
				_parent._tbPlay.TooltipText = "Pause";
				_parent._tbPlay.Image		= new Gtk.Image(Gtk.Stock.MediaPause, Gtk.IconSize.LargeToolbar);
			}
			else
			{
				_parent._tbPlay.Active 		= false;
				_parent._tbPlay.TooltipText = "Play";
				_parent._tbPlay.Image		= new Gtk.Image(Gtk.Stock.MediaPlay, Gtk.IconSize.LargeToolbar);
			}
			*/
			
			_parent._tbMute.Active 	= (_parent.oXbmc.Status.IsMuted())? true : false ;
			_parent._bStop.Active 	= (_parent.oXbmc.Status.IsNotPlaying())? true : false ;
			_parent._ibPlay.Pixbuf	= (_parent.oXbmc.Status.IsPlaying())? new Gdk.Pixbuf("Interface/" + _parent.theme + "/buttons/pause_32.png") : new Gdk.Pixbuf("Interface/" + _parent.theme + "/buttons/play_32.png") ;
		}
	}
}
