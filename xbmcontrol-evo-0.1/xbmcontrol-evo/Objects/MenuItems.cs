
using System;
using Gtk;
using Gdk;

namespace xbmcontrolevo
{
	
	
	public class MenuItems
	{
		private XbmControlEvo _parent;
		
		public MenuItems(XbmControlEvo parent)
		{
			_parent = parent;
		}
		
		public ImageMenuItem Seperator()
		{
			return new ImageMenuItem();
		}
		
		public ImageMenuItem Quit()
		{
			ImageMenuItem quit  = new ImageMenuItem("Quit");
			quit.Image 			= new Gtk.Image(Gtk.Stock.Quit, IconSize.Menu);;
			quit.Activated 		+= delegate { Application.Quit(); };
			
			return quit;
		}
		
		public ImageMenuItem PlayPause()
		{
			ImageMenuItem playPause;
				
			if (_parent.oXbmc.Status.IsPlaying())
			{
				playPause		= new ImageMenuItem("Pause");
				playPause.Image = new Gtk.Image(_parent.oImages.menu.pause);
			}
			else
			{
				playPause 		= new ImageMenuItem("Play");
				playPause.Image = new Gtk.Image(_parent.oImages.menu.play);
			}
			
			playPause.Activated	+= delegate { PlayPause(); };
			playPause.Activated += delegate { _parent.oXbmc.Controls.Play(); };
			
			return playPause;
		}
		
		public ImageMenuItem Play(string caller, string identifier)
		{
			ImageMenuItem play	= new ImageMenuItem("Play");
			play.Image 			= new Gtk.Image(_parent.oImages.menu.play);
			play.Activated 		+= delegate { _parent.oControls.AddToPlaylist(caller, identifier, true); };
		
			return play;
		}
		
		public ImageMenuItem Enque(string caller, string identifier)
		{
			ImageMenuItem enque		= new ImageMenuItem("Enque");
			enque.Image 			= new Gtk.Image(_parent.oImages.menu.plus);
			enque.Activated 		+= delegate { _parent.oControls.AddToPlaylist(caller, identifier, false); };
		
			return enque;
		}
		
		public ImageMenuItem Next()
		{
			ImageMenuItem next 	= new ImageMenuItem("Next");
			next.Image 			= new Gtk.Image(_parent.oImages.menu.next);
			next.Activated 		+= delegate { _parent.oXbmc.Controls.Next(); };
			
			return next;
		}
		
		public ImageMenuItem Previous()
		{
			ImageMenuItem previous 	= new ImageMenuItem("Previous");
			previous.Image 			= new Gtk.Image(_parent.oImages.menu.previous);
			previous.Activated 		+= delegate { _parent.oXbmc.Controls.Previous(); };
			
			return previous;
		}
		
		public ImageMenuItem Stop()
		{
			ImageMenuItem stop 	= new ImageMenuItem("Stop");
			stop.Image 			= new Gtk.Image(_parent.oImages.menu.stop);
			stop.Activated 		+= delegate { _parent.oXbmc.Controls.Stop(); };
			
			return stop;
		}
		
		public ImageMenuItem Mute()
		{
			Gtk.Image img		= new Gtk.Image(_parent.oImages.menu.mute);
			
			string text = (_parent.oXbmc.Status.IsMuted())? "Unmute" : "Mute" ;
			ImageMenuItem mute 	= new ImageMenuItem(text);
			
			mute.Image 			= img;
			mute.Activated 		+= delegate { _parent.oXbmc.Controls.ToggleMute(); };
			
			return mute;
		}
		
		public ImageMenuItem VolumeUp()
		{
			int currentVolume 	= _parent.oXbmc.Status.GetVolume();
			int newVolume		= ( (currentVolume+10) > 100 )? 100 : currentVolume+10 ;
			
			Gtk.Image img			= new Gtk.Image(_parent.oImages.menu.volume_up);
			ImageMenuItem volumeUp 	= new ImageMenuItem("Increase volume");
			volumeUp.Image 			= img;
			volumeUp.Activated 		+= delegate { _parent.oXbmc.Controls.SetVolume(newVolume); };
			
			return volumeUp;
		}
		
		public ImageMenuItem VolumeDown()
		{
			int currentVolume 	= _parent.oXbmc.Status.GetVolume();
			int newVolume		= ( (currentVolume-10) < 0 )? 0 : currentVolume-10 ;
			
			Gtk.Image img				= new Gtk.Image(_parent.oImages.menu.volume_down);
			ImageMenuItem volumeDown 	= new ImageMenuItem("Decrease volume");
			volumeDown.Image 			= img;
			volumeDown.Activated 		+= delegate { _parent.oXbmc.Controls.SetVolume(newVolume); };
			
			return volumeDown;
		}
		
		public ImageMenuItem ShowSongInfo(string caller)
		{
			ImageMenuItem config 	= new ImageMenuItem("Show info");
			config.Image 			= new Gtk.Image(_parent.oImages.menu.info);
			if (caller == "sharebrowser")
				config.Activated += delegate { _parent.oShareBrowser.ShowSongInfoPopup(); };
			else if (caller == "playlist")
				config.Activated += delegate { _parent.oPlaylist.ShowSongInfoPopup(); };
			
			return config;
		}
		
		public ImageMenuItem Configuration()
		{
			ImageMenuItem config 	= new ImageMenuItem("Configuration");
			config.Image 			= new Gtk.Image(_parent.oImages.menu.configure);
			config.Activated 		+= delegate { Application.Quit(); };
			
			return config;
		}
		
		public ImageMenuItem CollapseAll()
		{
			Gtk.Image img			= new Gtk.Image(_parent.oImages.menu.collapse);
			ImageMenuItem collapse 	= new ImageMenuItem("Collapse All");
			collapse.Image 			= img;
			collapse.Activated 		+= delegate { _parent.oShareBrowser.CollapseAll(); };
			
			return collapse;
		}
		
		public ImageMenuItem PlayPlaylistEntry()
		{
			ImageMenuItem playEntry 	= new ImageMenuItem("Play");
			playEntry.Image 			= new Gtk.Image(_parent.oImages.menu.play);
			playEntry.Activated 		+= delegate { _parent.oPlaylist.PlaySelectedItem(); };
			
			return playEntry;
		}
		
		public ImageMenuItem RemovePlaylistEntry()
		{
			ImageMenuItem removeEntry 	= new ImageMenuItem("Remove");
			removeEntry.Image 			= new Gtk.Image(_parent.oImages.menu.minus);
			removeEntry.Activated 		+= delegate { _parent.oPlaylist.RemoveSelectedItems(); };
			
			return removeEntry;
		}
		
		public ImageMenuItem ClearPlaylist()
		{
			ImageMenuItem clearPlaylist	= new ImageMenuItem("Clear");
			clearPlaylist.Image 		= new Gtk.Image(_parent.oImages.menu.clear);
			clearPlaylist.Activated 	+= delegate { _parent.oPlaylist.Clear(); };
			
			return clearPlaylist;
		}
		
		/*
		public ImageMenuItem SaveSelectedFile()
		{
			ImageMenuItem saveAs 	= new ImageMenuItem("Save As");
			saveAs.Image 			= new Gtk.Image(Gtk.Stock.SaveAs, IconSize.Menu);
			saveAs.Activated 		+= delegate { _parent.oShareBrowser.SaveSelectedFile(); };
			
			return saveAs;
		}
		*/
		
		public ImageMenuItem RefreshPlaylist()
		{
			ImageMenuItem refreshPlaylist	= new ImageMenuItem("Refresh");
			refreshPlaylist.Image 			= new Gtk.Image(_parent.oImages.menu.refresh);
			refreshPlaylist.Activated 		+= delegate { _parent.oPlaylist.Populate(); };
			
			return refreshPlaylist;
		}
		
		public ImageMenuItem RefreshShares()
		{
			ImageMenuItem refreshShares		= new ImageMenuItem("Refresh shares list");
			refreshShares.Image 			= new Gtk.Image(_parent.oImages.menu.refresh);
			refreshShares.Activated 		+= delegate { _parent.oShareBrowser.Populate(); };
			refreshShares.Activated 		+= delegate { _parent.oFileBrowser.Clear(); };
			
			return refreshShares;
		}
	}
}
