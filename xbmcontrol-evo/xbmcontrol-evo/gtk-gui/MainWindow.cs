// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action XBMControlAction;
    
    private Gtk.Action QuitAction;
    
    private Gtk.Action XBMCAction;
    
    private Gtk.Action PlaylistAction;
    
    private Gtk.Action HelpAction;
    
    private Gtk.Action UpdateMusicLibraryAction;
    
    private Gtk.Action UpdateVideoLibraryAction;
    
    private Gtk.Action UpdateLibraryAction;
    
    private Gtk.Action MusicAction;
    
    private Gtk.Action VideoAction;
    
    private Gtk.Action RestartAction;
    
    private Gtk.Action RebootAction;
    
    private Gtk.Action ShutdownAction;
    
    private Gtk.Action ConfigurationAction;
    
    private Gtk.Action newAction;
    
    private Gtk.Action openAction;
    
    private Gtk.Action saveAction;
    
    private Gtk.Action saveAsAction;
    
    private Gtk.Action refreshPlaylist;
    
    private Gtk.VBox vbox1;
    
    private Gtk.MenuBar menubar1;
    
    private Gtk.HPaned hpaned1;
    
    private Gtk.Notebook nbBrowser;
    
    private Gtk.VBox vbox3;
    
    private Gtk.ComboBox cbShareType;
    
    private Gtk.ScrolledWindow GtkScrolledWindow;
    
    private Gtk.TreeView tvShareBrowser;
    
    private Gtk.Label label2;
    
    private Gtk.Notebook nbDataContainer;
    
    private Gtk.Label label1;
    
    private Gtk.VBox vbox2;
    
    private Gtk.ScrolledWindow GtkScrolledWindow1;
    
    private Gtk.TreeView tvPlaylist;
    
    private Gtk.Toolbar toolbar1;
    
    private Gtk.Label label3;
    
    private Gtk.Label label4;
    
    private Gtk.Fixed fixed1;
    
    private Gtk.HScale hsVolume;
    
    private Gtk.HScale hsProgress;
    
    private Gtk.ToggleButton tbMute;
    
    private Gtk.Button bPrevious;
    
    private Gtk.ToggleButton tbPlay;
    
    private Gtk.ToggleButton tbStop;
    
    private Gtk.Button bNext;
    
    private Gtk.Button button1;
    
    private Gtk.Button button2;
    
    private Gtk.Button button3;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.XBMControlAction = new Gtk.Action("XBMControlAction", Mono.Unix.Catalog.GetString("XBMControl"), null, null);
        this.XBMControlAction.ShortLabel = Mono.Unix.Catalog.GetString("XBMControl");
        w1.Add(this.XBMControlAction, null);
        this.QuitAction = new Gtk.Action("QuitAction", Mono.Unix.Catalog.GetString("_Quit"), null, "gtk-disconnect");
        this.QuitAction.ShortLabel = Mono.Unix.Catalog.GetString("_Quit");
        w1.Add(this.QuitAction, null);
        this.XBMCAction = new Gtk.Action("XBMCAction", Mono.Unix.Catalog.GetString("XBMC"), null, null);
        this.XBMCAction.ShortLabel = Mono.Unix.Catalog.GetString("XBMC");
        w1.Add(this.XBMCAction, null);
        this.PlaylistAction = new Gtk.Action("PlaylistAction", Mono.Unix.Catalog.GetString("Playlist"), null, null);
        this.PlaylistAction.ShortLabel = Mono.Unix.Catalog.GetString("Playlist");
        w1.Add(this.PlaylistAction, null);
        this.HelpAction = new Gtk.Action("HelpAction", Mono.Unix.Catalog.GetString("Help"), null, null);
        this.HelpAction.ShortLabel = Mono.Unix.Catalog.GetString("Help");
        w1.Add(this.HelpAction, null);
        this.UpdateMusicLibraryAction = new Gtk.Action("UpdateMusicLibraryAction", Mono.Unix.Catalog.GetString("Update music library"), null, null);
        this.UpdateMusicLibraryAction.ShortLabel = Mono.Unix.Catalog.GetString("Update music library");
        w1.Add(this.UpdateMusicLibraryAction, null);
        this.UpdateVideoLibraryAction = new Gtk.Action("UpdateVideoLibraryAction", Mono.Unix.Catalog.GetString("Update video library"), null, null);
        this.UpdateVideoLibraryAction.ShortLabel = Mono.Unix.Catalog.GetString("Update video library");
        w1.Add(this.UpdateVideoLibraryAction, null);
        this.UpdateLibraryAction = new Gtk.Action("UpdateLibraryAction", Mono.Unix.Catalog.GetString("Update Library"), null, null);
        this.UpdateLibraryAction.ShortLabel = Mono.Unix.Catalog.GetString("Library");
        w1.Add(this.UpdateLibraryAction, null);
        this.MusicAction = new Gtk.Action("MusicAction", Mono.Unix.Catalog.GetString("Music"), null, "gtk-harddisk");
        this.MusicAction.ShortLabel = Mono.Unix.Catalog.GetString("Update music library");
        w1.Add(this.MusicAction, null);
        this.VideoAction = new Gtk.Action("VideoAction", Mono.Unix.Catalog.GetString("Video"), null, "gtk-harddisk");
        this.VideoAction.ShortLabel = Mono.Unix.Catalog.GetString("Update video library");
        w1.Add(this.VideoAction, null);
        this.RestartAction = new Gtk.Action("RestartAction", Mono.Unix.Catalog.GetString("Restart"), null, "gtk-refresh");
        this.RestartAction.ShortLabel = Mono.Unix.Catalog.GetString("Restart");
        w1.Add(this.RestartAction, null);
        this.RebootAction = new Gtk.Action("RebootAction", Mono.Unix.Catalog.GetString("Reboot"), null, "gtk-refresh");
        this.RebootAction.ShortLabel = Mono.Unix.Catalog.GetString("Reboot");
        w1.Add(this.RebootAction, null);
        this.ShutdownAction = new Gtk.Action("ShutdownAction", Mono.Unix.Catalog.GetString("Shutdown"), null, "gtk-quit");
        this.ShutdownAction.ShortLabel = Mono.Unix.Catalog.GetString("Shutdown");
        w1.Add(this.ShutdownAction, null);
        this.ConfigurationAction = new Gtk.Action("ConfigurationAction", Mono.Unix.Catalog.GetString("Configuration"), null, "gtk-edit");
        this.ConfigurationAction.ShortLabel = Mono.Unix.Catalog.GetString("_Preferences");
        w1.Add(this.ConfigurationAction, null);
        this.newAction = new Gtk.Action("newAction", null, null, "gtk-new");
        w1.Add(this.newAction, null);
        this.openAction = new Gtk.Action("openAction", null, null, "gtk-open");
        w1.Add(this.openAction, null);
        this.saveAction = new Gtk.Action("saveAction", null, null, "gtk-save");
        w1.Add(this.saveAction, null);
        this.saveAsAction = new Gtk.Action("saveAsAction", null, null, "gtk-save-as");
        w1.Add(this.saveAsAction, null);
        this.refreshPlaylist = new Gtk.Action("refreshPlaylist", null, null, "gtk-refresh");
        w1.Add(this.refreshPlaylist, null);
        this.UIManager.InsertActionGroup(w1, 0);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("XBMControl Evo");
        this.WindowPosition = ((Gtk.WindowPosition)(1));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='XBMControlAction' action='XBMControlAction'><menuitem name='ConfigurationAction' action='ConfigurationAction'/><menuitem name='QuitAction' action='QuitAction'/></menu><menu name='XBMCAction' action='XBMCAction'><menu name='UpdateLibraryAction' action='UpdateLibraryAction'><menuitem name='MusicAction' action='MusicAction'/><menuitem name='VideoAction' action='VideoAction'/></menu><menuitem name='RestartAction' action='RestartAction'/><menuitem name='RebootAction' action='RebootAction'/><menuitem name='ShutdownAction' action='ShutdownAction'/></menu><menu name='PlaylistAction' action='PlaylistAction'/><menu name='HelpAction' action='HelpAction'/></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.vbox1.Add(this.menubar1);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hpaned1 = new Gtk.HPaned();
        this.hpaned1.CanFocus = true;
        this.hpaned1.Name = "hpaned1";
        this.hpaned1.Position = 300;
        // Container child hpaned1.Gtk.Paned+PanedChild
        this.nbBrowser = new Gtk.Notebook();
        this.nbBrowser.WidthRequest = 300;
        this.nbBrowser.CanFocus = true;
        this.nbBrowser.Name = "nbBrowser";
        this.nbBrowser.CurrentPage = 0;
        // Container child nbBrowser.Gtk.Notebook+NotebookChild
        this.vbox3 = new Gtk.VBox();
        this.vbox3.Name = "vbox3";
        this.vbox3.Spacing = 6;
        // Container child vbox3.Gtk.Box+BoxChild
        this.cbShareType = Gtk.ComboBox.NewText();
        this.cbShareType.AppendText(Mono.Unix.Catalog.GetString("music"));
        this.cbShareType.AppendText(Mono.Unix.Catalog.GetString("video"));
        this.cbShareType.AppendText(Mono.Unix.Catalog.GetString("pictures"));
        this.cbShareType.AppendText(Mono.Unix.Catalog.GetString("files"));
        this.cbShareType.Name = "cbShareType";
        this.cbShareType.Active = 0;
        this.vbox3.Add(this.cbShareType);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox3[this.cbShareType]));
        w3.Position = 0;
        w3.Expand = false;
        w3.Fill = false;
        // Container child vbox3.Gtk.Box+BoxChild
        this.GtkScrolledWindow = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow.Name = "GtkScrolledWindow";
        this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
        this.tvShareBrowser = new Gtk.TreeView();
        this.tvShareBrowser.CanFocus = true;
        this.tvShareBrowser.Name = "tvShareBrowser";
        this.GtkScrolledWindow.Add(this.tvShareBrowser);
        this.vbox3.Add(this.GtkScrolledWindow);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.GtkScrolledWindow]));
        w5.Position = 1;
        this.nbBrowser.Add(this.vbox3);
        // Notebook tab
        this.label2 = new Gtk.Label();
        this.label2.Name = "label2";
        this.label2.LabelProp = Mono.Unix.Catalog.GetString("Shares");
        this.nbBrowser.SetTabLabel(this.vbox3, this.label2);
        this.label2.ShowAll();
        this.hpaned1.Add(this.nbBrowser);
        Gtk.Paned.PanedChild w7 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.nbBrowser]));
        w7.Resize = false;
        w7.Shrink = false;
        // Container child hpaned1.Gtk.Paned+PanedChild
        this.nbDataContainer = new Gtk.Notebook();
        this.nbDataContainer.CanFocus = true;
        this.nbDataContainer.Name = "nbDataContainer";
        this.nbDataContainer.CurrentPage = 1;
        // Notebook tab
        Gtk.Label w8 = new Gtk.Label();
        w8.Visible = true;
        this.nbDataContainer.Add(w8);
        this.label1 = new Gtk.Label();
        this.label1.Name = "label1";
        this.label1.LabelProp = Mono.Unix.Catalog.GetString("Info");
        this.nbDataContainer.SetTabLabel(w8, this.label1);
        this.label1.ShowAll();
        // Container child nbDataContainer.Gtk.Notebook+NotebookChild
        this.vbox2 = new Gtk.VBox();
        this.vbox2.Name = "vbox2";
        this.vbox2.Spacing = 6;
        // Container child vbox2.Gtk.Box+BoxChild
        this.GtkScrolledWindow1 = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
        this.GtkScrolledWindow1.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
        this.tvPlaylist = new Gtk.TreeView();
        this.tvPlaylist.CanFocus = true;
        this.tvPlaylist.Name = "tvPlaylist";
        this.GtkScrolledWindow1.Add(this.tvPlaylist);
        this.vbox2.Add(this.GtkScrolledWindow1);
        Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow1]));
        w10.Position = 0;
        // Container child vbox2.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><toolbar name='toolbar1'><toolitem name='newAction' action='newAction'/><toolitem name='openAction' action='openAction'/><toolitem name='saveAction' action='saveAction'/><toolitem name='saveAsAction' action='saveAsAction'/><toolitem name='refreshPlaylist' action='refreshPlaylist'/></toolbar></ui>");
        this.toolbar1 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
        this.toolbar1.Name = "toolbar1";
        this.toolbar1.ShowArrow = false;
        this.toolbar1.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
        this.toolbar1.IconSize = ((Gtk.IconSize)(3));
        this.vbox2.Add(this.toolbar1);
        Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox2[this.toolbar1]));
        w11.Position = 1;
        w11.Expand = false;
        w11.Fill = false;
        this.nbDataContainer.Add(this.vbox2);
        Gtk.Notebook.NotebookChild w12 = ((Gtk.Notebook.NotebookChild)(this.nbDataContainer[this.vbox2]));
        w12.Position = 1;
        // Notebook tab
        this.label3 = new Gtk.Label();
        this.label3.Name = "label3";
        this.label3.LabelProp = Mono.Unix.Catalog.GetString("Playlist");
        this.nbDataContainer.SetTabLabel(this.vbox2, this.label3);
        this.label3.ShowAll();
        // Notebook tab
        Gtk.Label w13 = new Gtk.Label();
        w13.Visible = true;
        this.nbDataContainer.Add(w13);
        this.label4 = new Gtk.Label();
        this.label4.Name = "label4";
        this.label4.LabelProp = Mono.Unix.Catalog.GetString("Configuration");
        this.nbDataContainer.SetTabLabel(w13, this.label4);
        this.label4.ShowAll();
        this.hpaned1.Add(this.nbDataContainer);
        this.vbox1.Add(this.hpaned1);
        Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox1[this.hpaned1]));
        w15.Position = 1;
        // Container child vbox1.Gtk.Box+BoxChild
        this.fixed1 = new Gtk.Fixed();
        this.fixed1.HeightRequest = 55;
        this.fixed1.Name = "fixed1";
        this.fixed1.HasWindow = false;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.hsVolume = new Gtk.HScale(null);
        this.hsVolume.TooltipMarkup = "Volume";
        this.hsVolume.WidthRequest = 120;
        this.hsVolume.CanFocus = true;
        this.hsVolume.Name = "hsVolume";
        this.hsVolume.Adjustment.Upper = 100;
        this.hsVolume.Adjustment.PageIncrement = 10;
        this.hsVolume.Adjustment.StepIncrement = 1;
        this.hsVolume.Adjustment.Value = 51.8987341772152;
        this.hsVolume.DrawValue = false;
        this.hsVolume.Digits = 0;
        this.hsVolume.ValuePos = ((Gtk.PositionType)(2));
        this.fixed1.Add(this.hsVolume);
        Gtk.Fixed.FixedChild w16 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.hsVolume]));
        w16.X = 730;
        w16.Y = 7;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.hsProgress = new Gtk.HScale(null);
        this.hsProgress.TooltipMarkup = "Progress";
        this.hsProgress.WidthRequest = 420;
        this.hsProgress.CanFocus = true;
        this.hsProgress.Name = "hsProgress";
        this.hsProgress.Adjustment.Upper = 100;
        this.hsProgress.Adjustment.PageIncrement = 10;
        this.hsProgress.Adjustment.StepIncrement = 1;
        this.hsProgress.DrawValue = false;
        this.hsProgress.Digits = 0;
        this.hsProgress.ValuePos = ((Gtk.PositionType)(2));
        this.fixed1.Add(this.hsProgress);
        Gtk.Fixed.FixedChild w17 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.hsProgress]));
        w17.X = 300;
        w17.Y = 7;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.tbMute = new Gtk.ToggleButton();
        this.tbMute.TooltipMarkup = "Toggle Mute";
        this.tbMute.WidthRequest = 30;
        this.tbMute.HeightRequest = 30;
        this.tbMute.CanFocus = true;
        this.tbMute.Name = "tbMute";
        this.tbMute.UseUnderline = true;
        this.tbMute.Active = true;
        this.tbMute.Label = Mono.Unix.Catalog.GetString("M");
        this.fixed1.Add(this.tbMute);
        Gtk.Fixed.FixedChild w18 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.tbMute]));
        w18.X = 850;
        w18.Y = 5;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.bPrevious = new Gtk.Button();
        this.bPrevious.TooltipMarkup = "Previous";
        this.bPrevious.WidthRequest = 35;
        this.bPrevious.HeightRequest = 35;
        this.bPrevious.CanFocus = true;
        this.bPrevious.Name = "bPrevious";
        this.bPrevious.UseUnderline = true;
        this.bPrevious.Label = Mono.Unix.Catalog.GetString("|<");
        this.fixed1.Add(this.bPrevious);
        Gtk.Fixed.FixedChild w19 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.bPrevious]));
        w19.X = 15;
        w19.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.tbPlay = new Gtk.ToggleButton();
        this.tbPlay.TooltipMarkup = "Play";
        this.tbPlay.WidthRequest = 35;
        this.tbPlay.HeightRequest = 35;
        this.tbPlay.CanFocus = true;
        this.tbPlay.Name = "tbPlay";
        this.tbPlay.UseUnderline = true;
        this.tbPlay.Label = Mono.Unix.Catalog.GetString(">");
        this.fixed1.Add(this.tbPlay);
        Gtk.Fixed.FixedChild w20 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.tbPlay]));
        w20.X = 50;
        w20.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.tbStop = new Gtk.ToggleButton();
        this.tbStop.TooltipMarkup = "Stop";
        this.tbStop.WidthRequest = 35;
        this.tbStop.HeightRequest = 35;
        this.tbStop.CanFocus = true;
        this.tbStop.Name = "tbStop";
        this.tbStop.UseUnderline = true;
        this.tbStop.Label = Mono.Unix.Catalog.GetString("[ ]");
        this.fixed1.Add(this.tbStop);
        Gtk.Fixed.FixedChild w21 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.tbStop]));
        w21.X = 85;
        w21.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.bNext = new Gtk.Button();
        this.bNext.TooltipMarkup = "Next";
        this.bNext.WidthRequest = 35;
        this.bNext.HeightRequest = 35;
        this.bNext.CanFocus = true;
        this.bNext.Name = "bNext";
        this.bNext.UseUnderline = true;
        this.bNext.Label = Mono.Unix.Catalog.GetString(">|");
        this.fixed1.Add(this.bNext);
        Gtk.Fixed.FixedChild w22 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.bNext]));
        w22.X = 120;
        w22.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.button1 = new Gtk.Button();
        this.button1.TooltipMarkup = "Toggle Repeat Mode";
        this.button1.WidthRequest = 25;
        this.button1.HeightRequest = 25;
        this.button1.CanFocus = true;
        this.button1.Name = "button1";
        this.button1.UseUnderline = true;
        this.button1.Label = Mono.Unix.Catalog.GetString("r");
        this.fixed1.Add(this.button1);
        Gtk.Fixed.FixedChild w23 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
        w23.X = 170;
        w23.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.button2 = new Gtk.Button();
        this.button2.TooltipMarkup = "Toggle Shuffel Mode";
        this.button2.WidthRequest = 25;
        this.button2.HeightRequest = 25;
        this.button2.CanFocus = true;
        this.button2.Name = "button2";
        this.button2.UseUnderline = true;
        this.button2.Label = Mono.Unix.Catalog.GetString("s");
        this.fixed1.Add(this.button2);
        Gtk.Fixed.FixedChild w24 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
        w24.X = 195;
        w24.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.button3 = new Gtk.Button();
        this.button3.TooltipMarkup = "Toggle Party Mode";
        this.button3.WidthRequest = 25;
        this.button3.HeightRequest = 25;
        this.button3.CanFocus = true;
        this.button3.Name = "button3";
        this.button3.UseUnderline = true;
        this.button3.Label = Mono.Unix.Catalog.GetString("p");
        this.fixed1.Add(this.button3);
        Gtk.Fixed.FixedChild w25 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.button3]));
        w25.X = 220;
        w25.Y = 4;
        this.vbox1.Add(this.fixed1);
        Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.vbox1[this.fixed1]));
        w26.Position = 2;
        w26.Expand = false;
        w26.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 898;
        this.DefaultHeight = 636;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.QuitAction.Activated += new System.EventHandler(this.OnExit);
        this.MusicAction.Activated += new System.EventHandler(this.click_UpdateMusicLibrary);
        this.VideoAction.Activated += new System.EventHandler(this.click_UpdateVideoLibrary);
        this.refreshPlaylist.Activated += new System.EventHandler(this.click_RefreshPlaylist);
        this.cbShareType.Changed += new System.EventHandler(this.change_cbShareBrowser);
        this.tvShareBrowser.ButtonReleaseEvent += new Gtk.ButtonReleaseEventHandler(this.tvShareBrowser_release);
        this.hsVolume.ValueChanged += new System.EventHandler(this.hsVolume_valueChanged);
        this.hsProgress.ChangeValue += new Gtk.ChangeValueHandler(this.hsProgress_changeValue);
        this.tbMute.Released += new System.EventHandler(this.tbMute_released);
        this.bPrevious.Released += new System.EventHandler(this.bPrevious_released);
        this.tbPlay.Released += new System.EventHandler(this.tbPlay_released);
        this.tbStop.Released += new System.EventHandler(this.tbStop_released);
        this.bNext.Released += new System.EventHandler(this.bNext_released);
    }
}
