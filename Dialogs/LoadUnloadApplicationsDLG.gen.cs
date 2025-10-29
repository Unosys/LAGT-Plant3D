// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Load*", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class LoadUnloadApplicationsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText LookInST;
        public  PopupList LookInPL;
        public  ToolBar ToolBarTB;
        public  PushButton GoToLastFolderPB;
        public  PushButton UpOneLevelPB;
        public  PushButton CreateNewFolderPB;
        public  PushButton ViewMenuPB;
        public  CustomWin CustomWinWIN;
        public  ListView ListView1LV;
        public  Header Header1CTL;
        public  CustomWin NameWIN;
        public  CustomWin DateModifiedWIN;
        public  StaticText FileNameST;
        public  ComboBox FileNameCB;
        public  StaticText FilesOfTypeST;
        public  PopupList FilesOfTypePL;
        public  PushButton LoadPB;
        public  DialogBox DialogBoxDLG;
        public  ListView ListView2LV;
        public  Header Header2CTL;
        public  CustomWin FileWIN;
        public  CustomWin PathWIN;
        public  StaticText StaticText1ST;
        public  PageList Tab1PG;
        public  CheckBox AddToHistoryCK;
        public  PushButton UnloadPB;
        public  GroupBox StartupSuiteGB;
        public  StaticText StaticText2ST;
        public  PushButton ContentsPB;
        public  StaticText StaticText3ST;
        public  PushButton ClosePB;
        public  PushButton HelpPB;
        public  PushButton SearchTheWebPB;
        public  PushButton LookInFavoritesPB;
        public  PushButton AddToFavoritesPB;

        partial void OnInitialize();

        public LoadUnloadApplicationsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LookInST = new StaticText()
            {
                Tag = "[StaticText]Look in:|$1091|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInST);

            LookInPL = new PopupList()
            {
                Tag = "[PopupList]Look in:|$1137|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInPL);

            ToolBarTB = new ToolBar()
            {
                Tag = "[ToolBar]$1088|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(ToolBarTB);

            GoToLastFolderPB = new PushButton()
            {
                Tag = "[ToolBar]$1088|#1/[PushButton]Go To Last Folder Visited|$Item 40971|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GoToLastFolderPB);

            UpOneLevelPB = new PushButton()
            {
                Tag = "[ToolBar]$1088|#1/[PushButton]Up One Level|$Item 40961|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelPB);

            CreateNewFolderPB = new PushButton()
            {
                Tag = "[ToolBar]$1088|#1/[PushButton]Create New Folder|$Item 40962|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderPB);

            ViewMenuPB = new PushButton()
            {
                Tag = "[ToolBar]$1088|#1/[PushButton]View Menu|$Item 40970|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewMenuPB);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$1121|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            ListView1LV = new ListView()
            {
                Tag = "[CustomWin]$1121|#1/[ListView]$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView1LV);

            Header1CTL = new Header()
            {
                Tag = "[CustomWin]$1121|#1/[ListView]$1|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Header1CTL);

            NameWIN = new CustomWin()
            {
                Tag = "[CustomWin]$1121|#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Name|$HeaderItem 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            DateModifiedWIN = new CustomWin()
            {
                Tag = "[CustomWin]$1121|#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Date modified|$HeaderItem 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModifiedWIN);

            FileNameST = new StaticText()
            {
                Tag = "[StaticText]File name:|$1090|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameST);

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]$1148",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            FilesOfTypeST = new StaticText()
            {
                Tag = "[StaticText]Files of type:|$1089|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeST);

            FilesOfTypePL = new PopupList()
            {
                Tag = "[PopupList]Files of type:|$1136|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypePL);

            LoadPB = new PushButton()
            {
                Tag = "[PushButton]Load|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LoadPB);

            DialogBoxDLG = new DialogBox()
            {
                Tag = "[DialogBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DialogBoxDLG);

            ListView2LV = new ListView()
            {
                Tag = "[DialogBox]#1/[ListView]$1015|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView2LV);

            Header2CTL = new Header()
            {
                Tag = "[DialogBox]#1/[ListView]$1015|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Header2CTL);

            FileWIN = new CustomWin()
            {
                Tag = "[DialogBox]#1/[ListView]$1015|#1/[Header]Header|$Header|#1/[CustomWin]File|$HeaderItem 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileWIN);

            PathWIN = new CustomWin()
            {
                Tag = "[DialogBox]#1/[ListView]$1015|#1/[Header]Header|$Header|#1/[CustomWin]Path|$HeaderItem 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathWIN);

            StaticText1ST = new StaticText()
            {
                Tag = "[DialogBox]#1/[StaticText]$1119|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            Tab1PG = new PageList()
            {
                Tag = "[DialogBox]#1/[PageList]Tab1|$1021|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tab1PG);

            AddToHistoryCK = new CheckBox()
            {
                Tag = "[DialogBox]#1/[CheckBox]Add to History|$1023|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddToHistoryCK);

            UnloadPB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]Unload|$1008|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnloadPB);

            StartupSuiteGB = new GroupBox()
            {
                Tag = "[DialogBox]#1/[GroupBox]Startup Suite|$1002|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StartupSuiteGB);

            StaticText2ST = new StaticText()
            {
                Tag = "[DialogBox]#1/[StaticText]$1011|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            ContentsPB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]Contents*|$1004|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentsPB);

            StaticText3ST = new StaticText()
            {
                Tag = "[DialogBox]#1/[StaticText]$1014|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText3ST);

            ClosePB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]Close|$1009|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            HelpPB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]Help|$1010|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            SearchTheWebPB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]Search the Web|$1024|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebPB);

            LookInFavoritesPB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]Look in Favorites|$1025|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInFavoritesPB);

            AddToFavoritesPB = new PushButton()
            {
                Tag = "[DialogBox]#1/[PushButton]Add to Favorites|$1027|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddToFavoritesPB);
        }
    }
}
