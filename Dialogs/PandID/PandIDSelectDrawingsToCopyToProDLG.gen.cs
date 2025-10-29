// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Drawings to Copy to Project", Parent = typeof(CustomWin))]
    public partial class PandIDSelectDrawingsToCopyToProDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
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

        partial void OnInitialize();

        public PandIDSelectDrawingsToCopyToProDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

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
                Tag = "[PushButton]Open|$1|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
