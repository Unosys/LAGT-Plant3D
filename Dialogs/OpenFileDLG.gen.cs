// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open File*", Parent = typeof(PropertyEditorFieldsDLG))]
    public partial class OpenFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  Pane ExplorerPanePANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  ToolBar CommandModuleTB;
        public  PushButton HelpPB;
        public  CheckBox PreviewPaneCK;
        public  CustomWin ViewsWIN;
        public  PushButton ViewSliderPB;
        public  PushButton OrganizePB;
        public  PushButton NewFolderPB;
        public  Pane ControlHostPANE;
        public  TreeView NamespaceTreeControlTV;
        public  ScrollBar VerticalScrollBar1SB;
        public  TreeViewItem FavoritesTVI;
        public  TreeViewItem DownloadsTVI;
        public  TreeViewItem RecentPlacesTVI;
        public  TreeViewItem A360DriveTVI;
        public  Pane ShellFolderViewPANE;
        public  ListBox ListBoxLB;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  ScrollBar HorizontalScrollBarSB;
        public  ScrollBar VerticalScrollBar2SB;
        public  Header HeaderCTL;
        public  CustomWin NameWIN;
        public  PushButton FilterDropdown1PB;
        public  CustomWin DateModifiedWIN;
        public  PushButton FilterDropdown2PB;
        public  CustomWin TypeWIN;
        public  ListBoxItem EnLBI;
        public  Image Image1IMG;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  TextField TextField3TF;
        public  ListBoxItem EnUSLBI;
        public  Image Image2IMG;
        public  TextField TextField4TF;
        public  TextField TextField5TF;
        public  TextField TextField6TF;
        public  ListBoxItem SetupLBI;
        public  Image Image3IMG;
        public  TextField TextField7TF;
        public  TextField TextField8TF;
        public  TextField TextField9TF;
        public  ListBoxItem SupportLBI;
        public  Image Image4IMG;
        public  TextField TextField10TF;
        public  TextField TextField11TF;
        public  TextField TextField12TF;
        public  ListBoxItem SymbolLibraryLBI;
        public  Image Image5IMG;
        public  TextField TextField13TF;
        public  TextField TextField14TF;
        public  TextField TextField15TF;
        public  ListBoxItem UPILBI;
        public  Image Image6IMG;
        public  TextField TextField16TF;
        public  TextField TextField17TF;
        public  TextField TextField18TF;
        public  ListBoxItem UserDataCacheLBI;
        public  Image Image7IMG;
        public  TextField TextField19TF;
        public  TextField TextField20TF;
        public  TextField TextField21TF;
        public  ListBoxItem AcDataSyncConfigurationxmlLBI;
        public  Image Image8IMG;
        public  TextField TextField22TF;
        public  TextField TextField23TF;
        public  TextField TextField24TF;
        public  ListBoxItem AdMigratorxmlLBI;
        public  Image Image9IMG;
        public  TextField TextField25TF;
        public  TextField TextField26TF;
        public  TextField TextField27TF;
        public  ListBoxItem AecbEnumsxmlLBI;
        public  Image Image10IMG;
        public  TextField TextField28TF;
        public  TextField TextField29TF;
        public  TextField TextField30TF;
        public  ListBoxItem ATPToP3dClassMappingxmlLBI;
        public  Image Image11IMG;
        public  TextField TextField31TF;
        public  TextField TextField32TF;
        public  TextField TextField33TF;
        public  ListBoxItem ATPtoP3DGeometryMappingxmlLBI;
        public  Image Image12IMG;
        public  TextField TextField34TF;
        public  TextField TextField35TF;
        public  TextField TextField36TF;
        public  ListBoxItem ATPToP3dMiscMappingxmlLBI;
        public  Image Image13IMG;
        public  TextField TextField37TF;
        public  TextField TextField38TF;
        public  TextField TextField39TF;
        public  ListBoxItem ATPToP3dUtilityMappingxmlLBI;
        public  Image Image14IMG;
        public  TextField TextField40TF;
        public  TextField TextField41TF;
        public  TextField TextField42TF;
        public  StaticText FileNameST;
        public  ComboBox FileNameTextField;
        public  PopupList FileNamePL;
        public  PushButton DropDownButtonPB;
        public  PushButton Open;
        public  PushButton CancelPB;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  Pane Pane8PANE;
        public  CustomWin RebarBand1WIN;
        public  Pane Pane9PANE;
        public  ToolBar ToolBar1TB;
        public  PushButton BackToAdMigratorxmlPB;
        public  PushButton ForwardPB;
        public  PushButton RecentPagesPB;
        public  CustomWin RebarBand2WIN;
        public  Pane Pane10PANE;
        public  CustomWin CustomWinWIN;
        public  Pane Pane11PANE;
        public  ToolBar AddressCProgramFilesAutodeskAutoCAD2016PLNT3DTB;
        public  CustomWin DesktopWIN;
        public  CustomWin AutoCAD2016WIN;
        public  CustomWin PLNT3DWIN;
        public  ToolBar ToolBar2TB;
        public  PushButton PreviousLocationsPB;
        public  PushButton RefreshPLNT3DPB;
        public  CustomWin RebarBand3WIN;
        public  Pane Pane12PANE;
        public  Pane Pane13PANE;
        public  Pane Pane14PANE;
        public  Pane SearchPLNT3DPANE;
        public  TextField TextField43TF;
        public  PushButton SearchPB;
        public  TitleBar OpenFileCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public OpenFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            ExplorerPanePANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExplorerPanePANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            CommandModuleTB = new ToolBar()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[ToolBar]Command Module|$FolderBandModuleInner",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommandModuleTB);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[ToolBar]Command Module|$FolderBandModuleInner/[PushButton]Help|$HelpButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            PreviewPaneCK = new CheckBox()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[ToolBar]Command Module|$FolderBandModuleInner/[CheckBox]Preview pane|$PreviewButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewPaneCK);

            ViewsWIN = new CustomWin()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[ToolBar]Command Module|$FolderBandModuleInner/[CustomWin]Views|$ViewControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewsWIN);

            ViewSliderPB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[ToolBar]Command Module|$FolderBandModuleInner/[CustomWin]Views|$ViewControl/[PushButton]View Slider|$SplitMenuButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewSliderPB);

            OrganizePB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[ToolBar]Command Module|$FolderBandModuleInner/[PushButton]Organize|${7DDC1264-7E4D-4F74-BBC0-D191987C8D0F}",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrganizePB);

            NewFolderPB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[ToolBar]Command Module|$FolderBandModuleInner/[PushButton]New folder|${E44616AD-6DF1-4B94-85A4-E465AE8A19DB}",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewFolderPB);

            ControlHostPANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Control Host|$ProperTreeHost",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ControlHostPANE);

            NamespaceTreeControlTV = new TreeView()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Control Host|$ProperTreeHost/[TreeView]Namespace Tree Control|$100",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NamespaceTreeControlTV);

            VerticalScrollBar1SB = new ScrollBar()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Control Host|$ProperTreeHost/[TreeView]Namespace Tree Control|$100/[ScrollBar]Vertical Scroll Bar|$Vertical ScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar1SB);

            FavoritesTVI = new TreeViewItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Control Host|$ProperTreeHost/[TreeView]Namespace Tree Control|$100/[TreeViewItem]Favorites",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FavoritesTVI);

            DownloadsTVI = new TreeViewItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Control Host|$ProperTreeHost/[TreeView]Namespace Tree Control|$100/[TreeViewItem]Favorites/[TreeViewItem]Downloads",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DownloadsTVI);

            RecentPlacesTVI = new TreeViewItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Control Host|$ProperTreeHost/[TreeView]Namespace Tree Control|$100/[TreeViewItem]Favorites/[TreeViewItem]Recent Places",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecentPlacesTVI);

            A360DriveTVI = new TreeViewItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Control Host|$ProperTreeHost/[TreeView]Namespace Tree Control|$100/[TreeViewItem]Favorites/[TreeViewItem]A360 Drive",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(A360DriveTVI);

            ShellFolderViewPANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShellFolderViewPANE);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ScrollBar]Horizontal Scroll Bar|$HorizontalScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            VerticalScrollBar2SB = new ScrollBar()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ScrollBar]Vertical Scroll Bar|$VerticalScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar2SB);

            HeaderCTL = new Header()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[Header]Header",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            NameWIN = new CustomWin()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[Header]Header/[CustomWin]Name|$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            FilterDropdown1PB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[Header]Header/[CustomWin]Name|$System.ItemNameDisplay/[PushButton]Filter dropdown|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterDropdown1PB);

            DateModifiedWIN = new CustomWin()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[Header]Header/[CustomWin]Date modified|$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModifiedWIN);

            FilterDropdown2PB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[Header]Header/[CustomWin]Date modified|$System.DateModified/[PushButton]Filter dropdown|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterDropdown2PB);

            TypeWIN = new CustomWin()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[Header]Header/[CustomWin]Type|$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TypeWIN);

            EnLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnLBI);

            Image1IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            EnUSLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en-US|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnUSLBI);

            Image2IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en-US|$1/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            TextField4TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en-US|$1/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            TextField5TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en-US|$1/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            TextField6TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]en-US|$1/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            SetupLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Setup|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SetupLBI);

            Image3IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Setup|$2/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            TextField7TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Setup|$2/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField7TF);

            TextField8TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Setup|$2/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField8TF);

            TextField9TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Setup|$2/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField9TF);

            SupportLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Support|$3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SupportLBI);

            Image4IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Support|$3/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image4IMG);

            TextField10TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Support|$3/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField10TF);

            TextField11TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Support|$3/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField11TF);

            TextField12TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]Support|$3/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField12TF);

            SymbolLibraryLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]SymbolLibrary|$4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolLibraryLBI);

            Image5IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]SymbolLibrary|$4/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image5IMG);

            TextField13TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]SymbolLibrary|$4/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField13TF);

            TextField14TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]SymbolLibrary|$4/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField14TF);

            TextField15TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]SymbolLibrary|$4/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField15TF);

            UPILBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UPI|$5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UPILBI);

            Image6IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UPI|$5/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image6IMG);

            TextField16TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UPI|$5/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField16TF);

            TextField17TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UPI|$5/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField17TF);

            TextField18TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UPI|$5/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField18TF);

            UserDataCacheLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UserDataCache|$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserDataCacheLBI);

            Image7IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UserDataCache|$6/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image7IMG);

            TextField19TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UserDataCache|$6/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField19TF);

            TextField20TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UserDataCache|$6/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField20TF);

            TextField21TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]UserDataCache|$6/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField21TF);

            AcDataSyncConfigurationxmlLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AcDataSyncConfiguration*|$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcDataSyncConfigurationxmlLBI);

            Image8IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AcDataSyncConfiguration*|$7/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image8IMG);

            TextField22TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AcDataSyncConfiguration*|$7/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField22TF);

            TextField23TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AcDataSyncConfiguration*|$7/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField23TF);

            TextField24TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AcDataSyncConfiguration*|$7/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField24TF);

            AdMigratorxmlLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AdMigrator*|$8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdMigratorxmlLBI);

            Image9IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AdMigrator*|$8/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image9IMG);

            TextField25TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AdMigrator*|$8/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField25TF);

            TextField26TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AdMigrator*|$8/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField26TF);

            TextField27TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AdMigrator*|$8/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField27TF);

            AecbEnumsxmlLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AecbEnums*|$9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AecbEnumsxmlLBI);

            Image10IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AecbEnums*|$9/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image10IMG);

            TextField28TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AecbEnums*|$9/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField28TF);

            TextField29TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AecbEnums*|$9/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField29TF);

            TextField30TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]AecbEnums*|$9/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField30TF);

            ATPToP3dClassMappingxmlLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dClassMapping*|$10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ATPToP3dClassMappingxmlLBI);

            Image11IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dClassMapping*|$10/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image11IMG);

            TextField31TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dClassMapping*|$10/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField31TF);

            TextField32TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dClassMapping*|$10/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField32TF);

            TextField33TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dClassMapping*|$10/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField33TF);

            ATPtoP3DGeometryMappingxmlLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPtoP3DGeometryMapping*|$11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ATPtoP3DGeometryMappingxmlLBI);

            Image12IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPtoP3DGeometryMapping*|$11/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image12IMG);

            TextField34TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPtoP3DGeometryMapping*|$11/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField34TF);

            TextField35TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPtoP3DGeometryMapping*|$11/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField35TF);

            TextField36TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPtoP3DGeometryMapping*|$11/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField36TF);

            ATPToP3dMiscMappingxmlLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dMiscMapping*|$12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ATPToP3dMiscMappingxmlLBI);

            Image13IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dMiscMapping*|$12/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image13IMG);

            TextField37TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dMiscMapping*|$12/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField37TF);

            TextField38TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dMiscMapping*|$12/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField38TF);

            TextField39TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dMiscMapping*|$12/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField39TF);

            ATPToP3dUtilityMappingxmlLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dUtilityMapping*|$13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ATPToP3dUtilityMappingxmlLBI);

            Image14IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dUtilityMapping*|$13/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image14IMG);

            TextField40TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dUtilityMapping*|$13/[TextField]$System.ItemNameDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField40TF);

            TextField41TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dUtilityMapping*|$13/[TextField]$System.DateModified",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField41TF);

            TextField42TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Shell Folder View|$listview/[ListBox]#1/[ListBoxItem]ATPToP3dUtilityMapping*|$13/[TextField]$System.ItemTypeText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField42TF);

            FileNameST = new StaticText()
            {
                Tag = "[StaticText]File name:|$1090",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameST);

            FileNameTextField = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$1148",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTextField);

            FileNamePL = new PopupList()
            {
                Tag = "[PopupList]File name:|$1136",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNamePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]File name:|$1136/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            Open = new PushButton()
            {
                Tag = "[PushButton]Open|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            RebarBand1WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[1]",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RebarBand1WIN);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[1]/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            ToolBar1TB = new ToolBar()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[1]/[Pane]#1/[ToolBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar1TB);

            BackToAdMigratorxmlPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[1]/[Pane]#1/[ToolBar]#1/[PushButton]Back to AdMigrator*|$Item 256",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackToAdMigratorxmlPB);

            ForwardPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[1]/[Pane]#1/[ToolBar]#1/[PushButton]Forward|$Item 257",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ForwardPB);

            RecentPagesPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[1]/[Pane]#1/[ToolBar]#1/[PushButton]Recent Pages|$Item 258",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecentPagesPB);

            RebarBand2WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RebarBand2WIN);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            AddressCProgramFilesAutodeskAutoCAD2016PLNT3DTB = new ToolBar()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddressCProgramFilesAutodeskAutoCAD2016PLNT3DTB);

            DesktopWIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001/[CustomWin]Desktop|$Item 1280",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesktopWIN);

            AutoCAD2016WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001/[CustomWin]AutoCAD 2016|$Item 1285",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCAD2016WIN);

            PLNT3DWIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001/[CustomWin]PLNT3D|$Item 1286",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PLNT3DWIN);

            ToolBar2TB = new ToolBar()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1/[ToolBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar2TB);

            PreviousLocationsPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1/[ToolBar]#1/[PushButton]Previous Locations|$Item 202",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousLocationsPB);

            RefreshPLNT3DPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[2]/[Pane]$41477/[CustomWin]#1/[ToolBar]#1/[PushButton]Refresh \"PLNT3D\"|$Item 102",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RefreshPLNT3DPB);

            RebarBand3WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[3]",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RebarBand3WIN);

            Pane12PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[3]/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane12PANE);

            Pane13PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[3]/[Pane]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane13PANE);

            Pane14PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[3]/[Pane]#1/[Pane]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane14PANE);

            SearchPLNT3DPANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[3]/[Pane]#1/[Pane]#1/[Pane]#1/[Pane] Search PLNT3D",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchPLNT3DPANE);

            TextField43TF = new TextField()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[3]/[Pane]#1/[Pane]#1/[Pane]#1/[Pane] Search PLNT3D/[TextField]$SearchEditBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField43TF);

            SearchPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965/[CustomWin]Rebar Band[3]/[Pane]#1/[Pane]#1/[Pane]#1/[Pane] Search PLNT3D/[PushButton]Search|$SearchBoxSearchButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchPB);

            OpenFileCTL = new TitleBar()
            {
                Tag = "[TitleBar]Open file|$TitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenFileCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Open file|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
