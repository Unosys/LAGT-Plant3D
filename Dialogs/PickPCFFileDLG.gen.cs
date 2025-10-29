// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Pick PCF File|#1", Parent = typeof(CreateIsoFromPCFDLG))]
    public partial class PickPCFFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton CreateNewFolderAlt5;
        public  PushButton DeleteDel;
        public  StaticText FileName;
        public  ComboBox FileNameComboBox;
        public  TextField FileNameTextField;
        public  StaticText FilesOfType;
        public  ComboBox FilesOfTypeComboBox;
        public  Header Header;
        public  ScrollBar HorizontalScrollBar;
        public  ListView ListView;
        public  ListBox LookIn;
        public  ComboBox LookInComboBox;
        public  StaticText LookInLabel;
        public  PushButton Open;
        public  PushButton PreviousFolderAlt1;
        public  PushButton SearchTheWebAlt3;
        public  CustomWin SHELLDLL_DefView;
        public  PushButton Tools;
        public  PushButton UpOneLevelAlt2;
        public  PushButton Views;

        partial void OnInitialize();

        public PickPCFFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            CreateNewFolderAlt5 = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderAlt5);

            DeleteDel = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteDel);

            FileName = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FileNameComboBox = new ComboBox()
            {
                Tag = "[ComboBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameComboBox);

            FileNameTextField = new TextField()
            {
                Tag = "[TextField]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTextField);

            FilesOfType = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType);

            FilesOfTypeComboBox = new ComboBox()
            {
                Tag = "[ComboBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeComboBox);

            Header = new Header()
            {
                Tag = "[Header]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Header);

            HorizontalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBar);

            ListView = new ListView()
            {
                Tag = "[ListView]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView);

            LookIn = new ListBox()
            {
                Tag = "[ListBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn);

            LookInComboBox = new ComboBox()
            {
                Tag = "[ComboBox]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInComboBox);

            LookInLabel = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInLabel);

            Open = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            PreviousFolderAlt1 = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousFolderAlt1);

            SearchTheWebAlt3 = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebAlt3);

            SHELLDLL_DefView = new CustomWin()
            {
                Tag = "[CustomWin]$SHELLDLL_DefView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SHELLDLL_DefView);

            Tools = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tools);

            UpOneLevelAlt2 = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelAlt2);

            Views = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Views);
        }
    }
}
