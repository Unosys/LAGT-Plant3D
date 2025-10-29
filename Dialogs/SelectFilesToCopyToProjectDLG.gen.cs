// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Files to Copy to Project|#1", Parent = typeof(ProjManUndocked), GUIType = GuiType.WIN32)]
    public partial class SelectFilesToCopyToProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin CustomWinWIN;
        public  ListView ListViewLV;
        public  Header HeaderCTL;
        public  CustomWin NameWIN;
        public  CustomWin DateModifiedWIN;
        public  CustomWin TypeWIN;
        public  StaticText FileNameST;
        public  ComboBox FileNameCB;
        public  StaticText FilesOfTypeST;
        public  PopupList FilesOfTypePL;
        public  PushButton PreviousFolderAlt1PB;
        public  PushButton UpOneLevelAlt2PB;
        public  PushButton SearchTheWebAlt3PB;
        public  PushButton DeleteDelPB;
        public  PushButton CreateNewFolderAlt5PB;
        public  PushButton ViewsPB;
        public  PushButton ToolsPB;
        public  PushButton OpenPB;
        public  PushButton CancelPB;
        public  ListBox LookInLB;
        public  StaticText LookInST;
        public  PopupList LookInPL;

        partial void OnInitialize();

        public SelectFilesToCopyToProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            ListViewLV = new ListView()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            HeaderCTL = new Header()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(HeaderCTL);

            NameWIN = new CustomWin()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Name|$HeaderItem 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            DateModifiedWIN = new CustomWin()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Date modified|$HeaderItem 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModifiedWIN);

            TypeWIN = new CustomWin()
            {
                Tag = "[CustomWin]#1/[ListView]$1|#1/[Header]Header|$Header|#1/[CustomWin]Type|$HeaderItem 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TypeWIN);

            FileNameST = new StaticText()
            {
                Tag = "[StaticText]File name:|$13008|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameST);

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$13006|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            FilesOfTypeST = new StaticText()
            {
                Tag = "[StaticText]Files of type:|$13009|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeST);

            FilesOfTypePL = new PopupList()
            {
                Tag = "[PopupList]Files of type:|$13002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypePL);

            PreviousFolderAlt1PB = new PushButton()
            {
                Tag = "[PushButton]Previous folder(Alt+1)|$13011|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousFolderAlt1PB);

            UpOneLevelAlt2PB = new PushButton()
            {
                Tag = "[PushButton]Up one level (Alt+2)|$13003|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelAlt2PB);

            SearchTheWebAlt3PB = new PushButton()
            {
                Tag = "[PushButton]Search the Web (Alt+3)|$13004|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebAlt3PB);

            DeleteDelPB = new PushButton()
            {
                Tag = "[PushButton]Delete (Del)|$13014|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteDelPB);

            CreateNewFolderAlt5PB = new PushButton()
            {
                Tag = "[PushButton]Create New Folder (Alt+5)|$13013|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderAlt5PB);

            ViewsPB = new PushButton()
            {
                Tag = "[PushButton]Views|$13012|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ViewsPB);

            ToolsPB = new PushButton()
            {
                Tag = "[PushButton]Tools|$13005|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolsPB);

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            LookInLB = new ListBox()
            {
                Tag = "[ListBox]Look in:|$13000|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInLB);

            LookInST = new StaticText()
            {
                Tag = "[StaticText]Look in:|$13007|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInST);

            LookInPL = new PopupList()
            {
                Tag = "[PopupList]Look in:|$13001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInPL);
        }
    }
}
