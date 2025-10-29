// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open", Parent = typeof(CustomWin), GUIType = GuiType.WIN32)]
    public partial class ProjectCompareOpenDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText LookInST;
        public  PopupList LookInPL;
        public  ToolBar ToolBar1TB;
        public  PushButton GoToLastFolderPB;
        public  PushButton UpOneLevelPB;
        public  PushButton CreateNewFolderPB;
        public  PushButton ViewMenuPB;
        public  ToolBar ToolBar2TB;
        public  PushButton QuickAccessPB;
        public  PushButton DesktopPB;
        public  PushButton LibrariesPB;
        public  PushButton ThisPCPB;
        public  PushButton NetworkPB;
        public  CustomWin CustomWin1WIN;
        public  ListView ListViewLV;
        public  Header HeaderCTL;
        public  CustomWin NameWIN;
        public  CustomWin DateModifiedWIN;
        public  CustomWin TypeWIN;
        public  StaticText FileNameST;
        public  ComboBox FileNameCB;
        public  StaticText FilesOfTypeST;
        public  PopupList FilesOfTypePL;
        public  PushButton OpenPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  CustomWin CustomWin2WIN;
        public  DialogBox DialogBoxDLG;

        partial void OnInitialize();

        public ProjectCompareOpenDLG()
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

            ToolBar1TB = new ToolBar()
            {
                Tag = "[ToolBar]$1088|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(ToolBar1TB);

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

            ToolBar2TB = new ToolBar()
            {
                Tag = "[ToolBar]$1184|#2",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(ToolBar2TB);

            QuickAccessPB = new PushButton()
            {
                Tag = "[ToolBar]$1184|#2/[PushButton]Quick access|$Item 41060|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(QuickAccessPB);

            DesktopPB = new PushButton()
            {
                Tag = "[ToolBar]$1184|#2/[PushButton]Desktop|$Item 41061|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesktopPB);

            LibrariesPB = new PushButton()
            {
                Tag = "[ToolBar]$1184|#2/[PushButton]Libraries|$Item 41062|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LibrariesPB);

            ThisPCPB = new PushButton()
            {
                Tag = "[ToolBar]$1184|#2/[PushButton]This PC|$Item 41063|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisPCPB);

            NetworkPB = new PushButton()
            {
                Tag = "[ToolBar]$1184|#2/[PushButton]Network|$Item 41064|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NetworkPB);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[CustomWin]$1121|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            ListViewLV = new ListView()
            {
                Tag = "[CustomWin]$1121|#1/[ListView]$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            HeaderCTL = new Header()
            {
                Tag = "[CustomWin]$1121|#1/[ListView]$1|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(HeaderCTL);

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

            TypeWIN = new CustomWin()
            {
                Tag = "[CustomWin]$1121|#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Type|$HeaderItem 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TypeWIN);

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

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$1038|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[CustomWin]$-1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            DialogBoxDLG = new DialogBox()
            {
                Tag = "[DialogBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DialogBoxDLG);
        }
    }
}
