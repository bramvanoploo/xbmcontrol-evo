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
    
    private Gtk.Action clearAction;
    
    private Gtk.Action openAction;
    
    private Gtk.Action saveAction;
    
    private Gtk.Action saveAsAction;
    
    private Gtk.Action aRefreshPlaylist;
    
    private Gtk.Action aRemoveSelected;
    
    private Gtk.Action aPlaySelected;
    
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
    
    private Gtk.Label labelMediaInfo;
    
    private Gtk.VBox vbox2;
    
    private Gtk.ComboBox cbPlaylistType;
    
    private Gtk.ScrolledWindow GtkScrolledWindow2;
    
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
    
    private Gtk.Button bRepeat;
    
    private Gtk.Button bShuffle;
    
    private Gtk.Button bPartyMode;
    
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
        this.clearAction = new Gtk.Action("clearAction", null, Mono.Unix.Catalog.GetString("Clear playlist"), "gtk-clear");
        w1.Add(this.clearAction, null);
        this.openAction = new Gtk.Action("openAction", null, null, "gtk-open");
        w1.Add(this.openAction, null);
        this.saveAction = new Gtk.Action("saveAction", null, null, "gtk-save");
        w1.Add(this.saveAction, null);
        this.saveAsAction = new Gtk.Action("saveAsAction", null, null, "gtk-save-as");
        w1.Add(this.saveAsAction, null);
        this.aRefreshPlaylist = new Gtk.Action("aRefreshPlaylist", null, null, "gtk-refresh");
        w1.Add(this.aRefreshPlaylist, null);
        this.aRemoveSelected = new Gtk.Action("aRemoveSelected", null, Mono.Unix.Catalog.GetString("Remove selected item"), "gtk-remove");
        w1.Add(this.aRemoveSelected, null);
        this.aPlaySelected = new Gtk.Action("aPlaySelected", null, Mono.Unix.Catalog.GetString("Play selected item"), "gtk-media-play");
        w1.Add(this.aPlaySelected, null);
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
        this.cbShareType.AppendText(Mono.Unix.Catalog.GetString("Music"));
        this.cbShareType.AppendText(Mono.Unix.Catalog.GetString("Video"));
        this.cbShareType.AppendText(Mono.Unix.Catalog.GetString("Pictures"));
        this.cbShareType.AppendText(Mono.Unix.Catalog.GetString("Files"));
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
        this.nbDataContainer.CurrentPage = 0;
        this.nbDataContainer.ShowBorder = false;
        this.nbDataContainer.Scrollable = true;
        // Notebook tab
        Gtk.Label w8 = new Gtk.Label();
        w8.Visible = true;
        this.nbDataContainer.Add(w8);
        this.labelMediaInfo = new Gtk.Label();
        this.labelMediaInfo.Name = "labelMediaInfo";
        this.labelMediaInfo.LabelProp = Mono.Unix.Catalog.GetString("Playing Now");
        this.nbDataContainer.SetTabLabel(w8, this.labelMediaInfo);
        this.labelMediaInfo.ShowAll();
        // Container child nbDataContainer.Gtk.Notebook+NotebookChild
        this.vbox2 = new Gtk.VBox();
        this.vbox2.Name = "vbox2";
        this.vbox2.Spacing = 6;
        // Container child vbox2.Gtk.Box+BoxChild
        this.cbPlaylistType = Gtk.ComboBox.NewText();
        this.cbPlaylistType.AppendText(Mono.Unix.Catalog.GetString("Music"));
        this.cbPlaylistType.AppendText(Mono.Unix.Catalog.GetString("Video"));
        this.cbPlaylistType.Name = "cbPlaylistType";
        this.cbPlaylistType.Active = 0;
        this.vbox2.Add(this.cbPlaylistType);
        Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.cbPlaylistType]));
        w9.Position = 0;
        w9.Expand = false;
        w9.Fill = false;
        // Container child vbox2.Gtk.Box+BoxChild
        this.GtkScrolledWindow2 = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
        this.GtkScrolledWindow2.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
        this.tvPlaylist = new Gtk.TreeView();
        this.tvPlaylist.CanFocus = true;
        this.tvPlaylist.Name = "tvPlaylist";
        this.GtkScrolledWindow2.Add(this.tvPlaylist);
        this.vbox2.Add(this.GtkScrolledWindow2);
        Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow2]));
        w11.Position = 1;
        // Container child vbox2.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><toolbar name='toolbar1'><toolitem name='clearAction' action='clearAction'/><toolitem name='aRefreshPlaylist' action='aRefreshPlaylist'/><toolitem name='aRemoveSelected' action='aRemoveSelected'/><toolitem name='aPlaySelected' action='aPlaySelected'/></toolbar></ui>");
        this.toolbar1 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
        this.toolbar1.TooltipMarkup = "Refresh playlist";
        this.toolbar1.Name = "toolbar1";
        this.toolbar1.ShowArrow = false;
        this.toolbar1.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
        this.toolbar1.IconSize = ((Gtk.IconSize)(3));
        this.vbox2.Add(this.toolbar1);
        Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox2[this.toolbar1]));
        w12.Position = 2;
        w12.Expand = false;
        w12.Fill = false;
        this.nbDataContainer.Add(this.vbox2);
        Gtk.Notebook.NotebookChild w13 = ((Gtk.Notebook.NotebookChild)(this.nbDataContainer[this.vbox2]));
        w13.Position = 1;
        // Notebook tab
        this.label3 = new Gtk.Label();
        this.label3.Name = "label3";
        this.label3.LabelProp = Mono.Unix.Catalog.GetString("Playlist");
        this.nbDataContainer.SetTabLabel(this.vbox2, this.label3);
        this.label3.ShowAll();
        // Notebook tab
        Gtk.Label w14 = new Gtk.Label();
        w14.Visible = true;
        this.nbDataContainer.Add(w14);
        this.label4 = new Gtk.Label();
        this.label4.Name = "label4";
        this.label4.LabelProp = Mono.Unix.Catalog.GetString("Configuration");
        this.nbDataContainer.SetTabLabel(w14, this.label4);
        this.label4.ShowAll();
        this.hpaned1.Add(this.nbDataContainer);
        this.vbox1.Add(this.hpaned1);
        Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox1[this.hpaned1]));
        w16.Position = 1;
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
        Gtk.Fixed.FixedChild w17 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.hsVolume]));
        w17.X = 730;
        w17.Y = 7;
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
        Gtk.Fixed.FixedChild w18 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.hsProgress]));
        w18.X = 300;
        w18.Y = 7;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.tbMute = new Gtk.ToggleButton();
        this.tbMute.TooltipMarkup = "Toggle Mute";
        this.tbMute.WidthRequest = 32;
        this.tbMute.HeightRequest = 32;
        this.tbMute.CanFocus = true;
        this.tbMute.Name = "tbMute";
        this.tbMute.UseUnderline = true;
        // Container child tbMute.Gtk.Container+ContainerChild
        Gtk.Alignment w19 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w20 = new Gtk.HBox();
        w20.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w21 = new Gtk.Image();
        w21.Pixbuf = Stetic.IconLoader.LoadIcon(this, "stock_volume-mute", Gtk.IconSize.Button, 20);
        w20.Add(w21);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w23 = new Gtk.Label();
        w20.Add(w23);
        w19.Add(w20);
        this.tbMute.Add(w19);
        this.fixed1.Add(this.tbMute);
        Gtk.Fixed.FixedChild w27 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.tbMute]));
        w27.X = 850;
        w27.Y = 5;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.bPrevious = new Gtk.Button();
        this.bPrevious.TooltipMarkup = "Previous";
        this.bPrevious.WidthRequest = 35;
        this.bPrevious.HeightRequest = 35;
        this.bPrevious.CanFocus = true;
        this.bPrevious.Name = "bPrevious";
        this.bPrevious.UseUnderline = true;
        // Container child bPrevious.Gtk.Container+ContainerChild
        Gtk.Alignment w28 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w29 = new Gtk.HBox();
        w29.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w30 = new Gtk.Image();
        w30.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-previous", Gtk.IconSize.LargeToolbar, 24);
        w29.Add(w30);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w32 = new Gtk.Label();
        w29.Add(w32);
        w28.Add(w29);
        this.bPrevious.Add(w28);
        this.fixed1.Add(this.bPrevious);
        Gtk.Fixed.FixedChild w36 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.bPrevious]));
        w36.X = 14;
        w36.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.tbPlay = new Gtk.ToggleButton();
        this.tbPlay.TooltipMarkup = "Play";
        this.tbPlay.WidthRequest = 35;
        this.tbPlay.HeightRequest = 35;
        this.tbPlay.CanFocus = true;
        this.tbPlay.Name = "tbPlay";
        this.tbPlay.UseUnderline = true;
        // Container child tbPlay.Gtk.Container+ContainerChild
        Gtk.Alignment w37 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w38 = new Gtk.HBox();
        w38.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w39 = new Gtk.Image();
        w39.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-play", Gtk.IconSize.LargeToolbar, 24);
        w38.Add(w39);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w41 = new Gtk.Label();
        w38.Add(w41);
        w37.Add(w38);
        this.tbPlay.Add(w37);
        this.fixed1.Add(this.tbPlay);
        Gtk.Fixed.FixedChild w45 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.tbPlay]));
        w45.X = 46;
        w45.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.tbStop = new Gtk.ToggleButton();
        this.tbStop.TooltipMarkup = "Stop";
        this.tbStop.WidthRequest = 35;
        this.tbStop.HeightRequest = 35;
        this.tbStop.CanFocus = true;
        this.tbStop.Name = "tbStop";
        this.tbStop.UseUnderline = true;
        // Container child tbStop.Gtk.Container+ContainerChild
        Gtk.Alignment w46 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w47 = new Gtk.HBox();
        w47.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w48 = new Gtk.Image();
        w48.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-stop", Gtk.IconSize.LargeToolbar, 24);
        w47.Add(w48);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w50 = new Gtk.Label();
        w47.Add(w50);
        w46.Add(w47);
        this.tbStop.Add(w46);
        this.fixed1.Add(this.tbStop);
        Gtk.Fixed.FixedChild w54 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.tbStop]));
        w54.X = 78;
        w54.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.bNext = new Gtk.Button();
        this.bNext.TooltipMarkup = "Next";
        this.bNext.WidthRequest = 35;
        this.bNext.HeightRequest = 35;
        this.bNext.CanFocus = true;
        this.bNext.Name = "bNext";
        this.bNext.UseUnderline = true;
        // Container child bNext.Gtk.Container+ContainerChild
        Gtk.Alignment w55 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w56 = new Gtk.HBox();
        w56.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w57 = new Gtk.Image();
        w57.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-next", Gtk.IconSize.LargeToolbar, 24);
        w56.Add(w57);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w59 = new Gtk.Label();
        w56.Add(w59);
        w55.Add(w56);
        this.bNext.Add(w55);
        this.fixed1.Add(this.bNext);
        Gtk.Fixed.FixedChild w63 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.bNext]));
        w63.X = 110;
        w63.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.bRepeat = new Gtk.Button();
        this.bRepeat.TooltipMarkup = "Toggle Repeat Modes";
        this.bRepeat.WidthRequest = 28;
        this.bRepeat.HeightRequest = 28;
        this.bRepeat.CanFocus = true;
        this.bRepeat.Name = "bRepeat";
        this.bRepeat.UseUnderline = true;
        // Container child bRepeat.Gtk.Container+ContainerChild
        Gtk.Alignment w64 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w65 = new Gtk.HBox();
        w65.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w66 = new Gtk.Image();
        w66.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-redo", Gtk.IconSize.Menu, 16);
        w65.Add(w66);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w68 = new Gtk.Label();
        w65.Add(w68);
        w64.Add(w65);
        this.bRepeat.Add(w64);
        this.fixed1.Add(this.bRepeat);
        Gtk.Fixed.FixedChild w72 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.bRepeat]));
        w72.X = 155;
        w72.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.bShuffle = new Gtk.Button();
        this.bShuffle.TooltipMarkup = "Toggle Shuffel Mode";
        this.bShuffle.WidthRequest = 28;
        this.bShuffle.HeightRequest = 28;
        this.bShuffle.CanFocus = true;
        this.bShuffle.Name = "bShuffle";
        this.bShuffle.UseUnderline = true;
        // Container child bShuffle.Gtk.Container+ContainerChild
        Gtk.Alignment w73 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w74 = new Gtk.HBox();
        w74.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w75 = new Gtk.Image();
        w75.Pixbuf = Stetic.IconLoader.LoadIcon(this, "stock_chart-toggle-legend", Gtk.IconSize.Menu, 16);
        w74.Add(w75);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w77 = new Gtk.Label();
        w74.Add(w77);
        w73.Add(w74);
        this.bShuffle.Add(w73);
        this.fixed1.Add(this.bShuffle);
        Gtk.Fixed.FixedChild w81 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.bShuffle]));
        w81.X = 180;
        w81.Y = 4;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.bPartyMode = new Gtk.Button();
        this.bPartyMode.TooltipMarkup = "Toggle Party Mode";
        this.bPartyMode.WidthRequest = 28;
        this.bPartyMode.HeightRequest = 28;
        this.bPartyMode.CanFocus = true;
        this.bPartyMode.Name = "bPartyMode";
        this.bPartyMode.UseUnderline = true;
        // Container child bPartyMode.Gtk.Container+ContainerChild
        Gtk.Alignment w82 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        Gtk.HBox w83 = new Gtk.HBox();
        w83.Spacing = 2;
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Image w84 = new Gtk.Image();
        w84.Pixbuf = Stetic.IconLoader.LoadIcon(this, "stock_filters", Gtk.IconSize.Menu, 16);
        w83.Add(w84);
        // Container child GtkHBox.Gtk.Container+ContainerChild
        Gtk.Label w86 = new Gtk.Label();
        w83.Add(w86);
        w82.Add(w83);
        this.bPartyMode.Add(w82);
        this.fixed1.Add(this.bPartyMode);
        Gtk.Fixed.FixedChild w90 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.bPartyMode]));
        w90.X = 205;
        w90.Y = 4;
        this.vbox1.Add(this.fixed1);
        Gtk.Box.BoxChild w91 = ((Gtk.Box.BoxChild)(this.vbox1[this.fixed1]));
        w91.Position = 2;
        w91.Expand = false;
        w91.Fill = false;
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
        this.clearAction.Activated += new System.EventHandler(this.aClearPlaylist_click);
        this.aRefreshPlaylist.Activated += new System.EventHandler(this.aRefreshPlaylist_activated);
        this.aRemoveSelected.Activated += new System.EventHandler(this.aRemoveSelected_activated);
        this.aPlaySelected.Activated += new System.EventHandler(this.aPlaySelected_activated);
        this.cbShareType.Changed += new System.EventHandler(this.cbShareBrowser_changed);
        this.tvShareBrowser.ButtonReleaseEvent += new Gtk.ButtonReleaseEventHandler(this.tvShareBrowser_release);
        this.cbPlaylistType.Changed += new System.EventHandler(this.cbPlaylistType_changed);
        this.tvPlaylist.ButtonReleaseEvent += new Gtk.ButtonReleaseEventHandler(this.tvPlaylist_buttonRelease);
        this.hsVolume.ValueChanged += new System.EventHandler(this.hsVolume_valueChanged);
        this.hsProgress.ChangeValue += new Gtk.ChangeValueHandler(this.hsProgress_changeValue);
        this.tbMute.Released += new System.EventHandler(this.tbMute_released);
        this.bPrevious.Released += new System.EventHandler(this.bPrevious_released);
        this.tbPlay.Released += new System.EventHandler(this.tbPlay_released);
        this.tbStop.Released += new System.EventHandler(this.tbStop_released);
        this.bNext.Released += new System.EventHandler(this.bNext_released);
        this.bRepeat.Activated += new System.EventHandler(this.bRepeat_click);
        this.bShuffle.Released += new System.EventHandler(this.bShuffle_release);
        this.bPartyMode.Released += new System.EventHandler(this.bPartyMode_released);
    }
}
