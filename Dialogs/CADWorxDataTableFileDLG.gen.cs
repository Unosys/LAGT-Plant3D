// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]CADWorx DataTable File *|#1", Parent = typeof(Window))]
    public partial class CADWorxDataTableFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  ScrollBar VerticalScrollBarSB;
        public  TreeViewItem FavoritesTVI;
        public  TreeViewItem DownloadsTVI;
        public  TreeViewItem RecentPlacesTVI;
        public  TreeViewItem A360DriveTVI;
        public  Pane ShellFolderViewPANE;
        public  ListBox ListBoxLB;
        public  Pane Pane4PANE;
        public  ScrollBar HorizontalScrollBarSB;
        public  Header HeaderCTL;
        public  CustomWin NameWIN;
        public  PushButton FilterDropdown1PB;
        public  CustomWin DateModifiedWIN;
        public  PushButton FilterDropdown2PB;
        public  CustomWin TypeWIN;
        public  ListBoxItem HadrianCatalogsLBI;
        public  Image Image1IMG;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  TextField TextField3TF;
        public  ListBoxItem HadrianSpecsLBI;
        public  Image Image2IMG;
        public  TextField TextField4TF;
        public  TextField TextField5TF;
        public  TextField TextField6TF;
        public  ListBoxItem NetworkPathLBI;
        public  Image Image3IMG;
        public  TextField TextField7TF;
        public  TextField TextField8TF;
        public  TextField TextField9TF;
        public  ListBoxItem NewMetricLBI;
        public  Image Image4IMG;
        public  TextField TextField10TF;
        public  TextField TextField11TF;
        public  TextField TextField12TF;
        public  ListBoxItem PreviewLispsLBI;
        public  Image Image5IMG;
        public  TextField TextField13TF;
        public  TextField TextField14TF;
        public  TextField TextField15TF;
        public  ListBoxItem Project1LBI;
        public  Image Image6IMG;
        public  TextField TextField16TF;
        public  TextField TextField17TF;
        public  TextField TextField18TF;
        public  ListBoxItem ResolveExcelImportChangesLBI;
        public  Image Image7IMG;
        public  TextField TextField19TF;
        public  TextField TextField20TF;
        public  TextField TextField21TF;
        public  ListBoxItem DataFiletblLBI;
        public  Image Image8IMG;
        public  TextField TextField22TF;
        public  TextField TextField23TF;
        public  TextField TextField24TF;
        public  StaticText FileNameST;
        public  ComboBox FileNameCB;
        public  PopupList FileNamePL;
        public  PushButton DropDownButtonPB;
        public  PushButton OpenPB;
        public  PushButton CancelPB;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  Pane Pane7PANE;
        public  CustomWin RebarBand1WIN;
        public  Pane Pane8PANE;
        public  ToolBar ToolBar1TB;
        public  PushButton BackPB;
        public  PushButton ForwardPB;
        public  PushButton RecentPagesPB;
        public  CustomWin RebarBand2WIN;
        public  Pane Pane9PANE;
        public  CustomWin CustomWinWIN;
        public  Pane Pane10PANE;
        public  ToolBar AddressCLAGTDesktopPlant3DTestFilesTB;
        public  CustomWin Desktop1WIN;
        public  CustomWin Desktop2WIN;
        public  CustomWin Plant3DWIN;
        public  CustomWin TestFilesWIN;
        public  ToolBar ToolBar2TB;
        public  PushButton PreviousLocationsPB;
        public  PushButton RefreshTestFilesPB;
        public  CustomWin RebarBand3WIN;
        public  Pane Pane11PANE;
        public  Pane Pane12PANE;
        public  Pane Pane13PANE;
        public  Pane SearchTestFilesPANE;
        public  TextField TextField25TF;
        public  PushButton SearchPB;
        public  TitleBar CADWorxDataTableFiletbltblCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CADWorxDataTableFileDLG()
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
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExplorerPanePANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            CommandModuleTB = new ToolBar()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[ToolBar]Command Module|$FolderBandModuleInner|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommandModuleTB);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[ToolBar]Command Module|$FolderBandModuleInner|#1/[PushButton]Help|$HelpButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            PreviewPaneCK = new CheckBox()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[ToolBar]Command Module|$FolderBandModuleInner|#1/[CheckBox]Preview pane|$PreviewButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewPaneCK);

            ViewsWIN = new CustomWin()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[ToolBar]Command Module|$FolderBandModuleInner|#1/[CustomWin]Views|$ViewControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewsWIN);

            ViewSliderPB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[ToolBar]Command Module|$FolderBandModuleInner|#1/[CustomWin]Views|$ViewControl|#1/[PushButton]View Slider|$SplitMenuButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewSliderPB);

            OrganizePB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[ToolBar]Command Module|$FolderBandModuleInner|#1/[PushButton]Organize|${7DDC1264-7E4D-4F74-BBC0-D191987C8D0F}|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrganizePB);

            NewFolderPB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[ToolBar]Command Module|$FolderBandModuleInner|#1/[PushButton]New folder|${E44616AD-6DF1-4B94-85A4-E465AE8A19DB}|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewFolderPB);

            ControlHostPANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Control Host|$ProperTreeHost|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ControlHostPANE);

            NamespaceTreeControlTV = new TreeView()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Control Host|$ProperTreeHost|#2/[TreeView]Namespace Tree Control|$100|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NamespaceTreeControlTV);

            VerticalScrollBarSB = new ScrollBar()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Control Host|$ProperTreeHost|#2/[TreeView]Namespace Tree Control|$100|#1/[ScrollBar]Vertical Scroll Bar|$Vertical ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarSB);

            FavoritesTVI = new TreeViewItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Control Host|$ProperTreeHost|#2/[TreeView]Namespace Tree Control|$100|#1/[TreeViewItem]Favorites|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FavoritesTVI);

            DownloadsTVI = new TreeViewItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Control Host|$ProperTreeHost|#2/[TreeView]Namespace Tree Control|$100|#1/[TreeViewItem]Favorites|#1/[TreeViewItem]Downloads|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DownloadsTVI);

            RecentPlacesTVI = new TreeViewItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Control Host|$ProperTreeHost|#2/[TreeView]Namespace Tree Control|$100|#1/[TreeViewItem]Favorites|#1/[TreeViewItem]Recent Places|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecentPlacesTVI);

            A360DriveTVI = new TreeViewItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Control Host|$ProperTreeHost|#2/[TreeView]Namespace Tree Control|$100|#1/[TreeViewItem]Favorites|#1/[TreeViewItem]A360 Drive|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(A360DriveTVI);

            ShellFolderViewPANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShellFolderViewPANE);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ScrollBar]Horizontal Scroll Bar|$HorizontalScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            HeaderCTL = new Header()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[Header]Header|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            NameWIN = new CustomWin()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[Header]Header|#1/[CustomWin]Name|$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            FilterDropdown1PB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[Header]Header|#1/[CustomWin]Name|$System.ItemNameDisplay|#1/[PushButton]Filter dropdown|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterDropdown1PB);

            DateModifiedWIN = new CustomWin()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[Header]Header|#1/[CustomWin]Date modified|$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModifiedWIN);

            FilterDropdown2PB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[Header]Header|#1/[CustomWin]Date modified|$System.DateModified|#2/[PushButton]Filter dropdown|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterDropdown2PB);

            TypeWIN = new CustomWin()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[Header]Header|#1/[CustomWin]Type|$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TypeWIN);

            HadrianCatalogsLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Catalogs|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HadrianCatalogsLBI);

            Image1IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Catalogs|#1/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Catalogs|#1/[TextField]$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Catalogs|#1/[TextField]$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            TextField3TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Catalogs|#1/[TextField]$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField3TF);

            HadrianSpecsLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Specs|$1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HadrianSpecsLBI);

            Image2IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Specs|$1|#2/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            TextField4TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Specs|$1|#2/[TextField]$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField4TF);

            TextField5TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Specs|$1|#2/[TextField]$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField5TF);

            TextField6TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Hadrian_Specs|$1|#2/[TextField]$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField6TF);

            NetworkPathLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NetworkPath|$2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NetworkPathLBI);

            Image3IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NetworkPath|$2|#3/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            TextField7TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NetworkPath|$2|#3/[TextField]$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField7TF);

            TextField8TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NetworkPath|$2|#3/[TextField]$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField8TF);

            TextField9TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NetworkPath|$2|#3/[TextField]$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField9TF);

            NewMetricLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NewMetric|$3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewMetricLBI);

            Image4IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NewMetric|$3|#4/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image4IMG);

            TextField10TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NewMetric|$3|#4/[TextField]$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField10TF);

            TextField11TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NewMetric|$3|#4/[TextField]$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField11TF);

            TextField12TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]NewMetric|$3|#4/[TextField]$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField12TF);

            PreviewLispsLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]PreviewLisps|$4|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewLispsLBI);

            Image5IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]PreviewLisps|$4|#5/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image5IMG);

            TextField13TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]PreviewLisps|$4|#5/[TextField]$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField13TF);

            TextField14TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]PreviewLisps|$4|#5/[TextField]$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField14TF);

            TextField15TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]PreviewLisps|$4|#5/[TextField]$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField15TF);

            Project1LBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Project 1|$5|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Project1LBI);

            Image6IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Project 1|$5|#6/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image6IMG);

            TextField16TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Project 1|$5|#6/[TextField]$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField16TF);

            TextField17TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Project 1|$5|#6/[TextField]$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField17TF);

            TextField18TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]Project 1|$5|#6/[TextField]$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField18TF);

            ResolveExcelImportChangesLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]ResolveExcelImportChanges|$6|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ResolveExcelImportChangesLBI);

            Image7IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]ResolveExcelImportChanges|$6|#7/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image7IMG);

            TextField19TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]ResolveExcelImportChanges|$6|#7/[TextField]$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField19TF);

            TextField20TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]ResolveExcelImportChanges|$6|#7/[TextField]$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField20TF);

            TextField21TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]ResolveExcelImportChanges|$6|#7/[TextField]$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField21TF);

            DataFiletblLBI = new ListBoxItem()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]DataFile*|$7|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataFiletblLBI);

            Image8IMG = new Image()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]DataFile*|$7|#8/[Image]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image8IMG);

            TextField22TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]DataFile*|$7|#8/[TextField]$System.ItemNameDisplay|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField22TF);

            TextField23TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]DataFile*|$7|#8/[TextField]$System.DateModified|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField23TF);

            TextField24TF = new TextField()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Shell Folder View|$listview|#4/[ListBox]#1/[ListBoxItem]DataFile*|$7|#8/[TextField]$System.ItemTypeText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField24TF);

            FileNameST = new StaticText()
            {
                Tag = "[StaticText]File name:|$1090|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameST);

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            FileNamePL = new PopupList()
            {
                Tag = "[PopupList]File name:|$1136|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNamePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]File name:|$1136|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            RebarBand1WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[1]|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RebarBand1WIN);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[1]|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            ToolBar1TB = new ToolBar()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[1]|#1/[Pane]#1/[ToolBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar1TB);

            BackPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[1]|#1/[Pane]#1/[ToolBar]#1/[PushButton]Back|$Item 256|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPB);

            ForwardPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[1]|#1/[Pane]#1/[ToolBar]#1/[PushButton]Forward|$Item 257|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ForwardPB);

            RecentPagesPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[1]|#1/[Pane]#1/[ToolBar]#1/[PushButton]Recent Pages|$Item 258|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecentPagesPB);

            RebarBand2WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RebarBand2WIN);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            Pane10PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane10PANE);

            AddressCLAGTDesktopPlant3DTestFilesTB = new ToolBar()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddressCLAGTDesktopPlant3DTestFilesTB);

            Desktop1WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001|#1/[CustomWin]Desktop[1]|$Item 1280|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Desktop1WIN);

            Desktop2WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001|#1/[CustomWin]Desktop[2]|$Item 1284|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Desktop2WIN);

            Plant3DWIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001|#1/[CustomWin]Plant3D|$Item 1285|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DWIN);

            TestFilesWIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[Pane]#1/[ToolBar]Address: C:*|$1001|#1/[CustomWin]TestFiles|$Item 1286|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TestFilesWIN);

            ToolBar2TB = new ToolBar()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[ToolBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar2TB);

            PreviousLocationsPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[ToolBar]#1/[PushButton]Previous Locations|$Item 202|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousLocationsPB);

            RefreshTestFilesPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[2]|#2/[Pane]$41477|#1/[CustomWin]#1/[ToolBar]#1/[PushButton]Refresh \"TestFiles\"|$Item 102|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RefreshTestFilesPB);

            RebarBand3WIN = new CustomWin()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[3]|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RebarBand3WIN);

            Pane11PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[3]|#3/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane11PANE);

            Pane12PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[3]|#3/[Pane]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane12PANE);

            Pane13PANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[3]|#3/[Pane]#1/[Pane]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane13PANE);

            SearchTestFilesPANE = new Pane()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[3]|#3/[Pane]#1/[Pane]#1/[Pane]#1/[Pane] Search TestFiles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTestFilesPANE);

            TextField25TF = new TextField()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[3]|#3/[Pane]#1/[Pane]#1/[Pane]#1/[Pane] Search TestFiles|#1/[TextField]$SearchEditBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField25TF);

            SearchPB = new PushButton()
            {
                Tag = "[Pane]#1/[Pane]$40965|#1/[CustomWin]Rebar Band[3]|#3/[Pane]#1/[Pane]#1/[Pane]#1/[Pane] Search TestFiles|#1/[PushButton]Search|$SearchBoxSearchButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchPB);

            CADWorxDataTableFiletbltblCTL = new TitleBar()
            {
                Tag = "[TitleBar]CADWorx DataTable File (*|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CADWorxDataTableFiletbltblCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]CADWorx DataTable File (*|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]CADWorx DataTable File (*|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]CADWorx DataTable File (*|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
