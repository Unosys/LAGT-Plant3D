// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Drawings to Copy to Project", Parent = typeof(ProjManUndocked), GUIType = GuiType.WIN32)]
    public partial class SelectDrawingsToCopyToProDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListView ListView1;
        public  ComboBox FileName;
        public  PopupList FilesOfType;
        public  PushButton PreviousFolderAlt1;
        public  PushButton UpOneLevelAlt2;
        public  PushButton SearchTheWebAlt3;
        public  PushButton DeleteDel;
        public  PushButton CreateNewFolderAlt5;
        public  PushButton Views;
        public  PushButton Tools;
        public  PushButton Open;
        public  PushButton Cancel;
        public  PushButton Preview;

        partial void OnInitialize();

        public SelectDrawingsToCopyToProDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ListView1 = new ListView()
            {
                Tag = "[CustomWin]#1/[ListView]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView1);

            FileName = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$13006",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FilesOfType = new PopupList()
            {
                Tag = "[PopupList]Files of type:|$13002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType);

            PreviousFolderAlt1 = new PushButton()
            {
                Tag = "[PushButton]Previous folder(Alt+1)|$13011",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousFolderAlt1);

            UpOneLevelAlt2 = new PushButton()
            {
                Tag = "[PushButton]Up one level (Alt+2)|$13003",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelAlt2);

            SearchTheWebAlt3 = new PushButton()
            {
                Tag = "[PushButton]Search the Web (Alt+3)|$13004",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebAlt3);

            DeleteDel = new PushButton()
            {
                Tag = "[PushButton]Delete (Del)|$13014",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteDel);

            CreateNewFolderAlt5 = new PushButton()
            {
                Tag = "[PushButton]Create New Folder (Alt+5)|$13013",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderAlt5);

            Views = new PushButton()
            {
                Tag = "[PushButton]Views|$13012",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Views);

            Tools = new PushButton()
            {
                Tag = "[PushButton]Tools|$13005",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tools);

            Open = new PushButton()
            {
                Tag = "[PushButton]Open|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Preview = new PushButton()
            {
                Tag = "[PushButton]$13101",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview);
        }
    }
}
