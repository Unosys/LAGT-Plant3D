// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Export To AutoCAD")]
    public partial class PandIDExportToAutoCADDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListBox LookIn1;
        public  StaticText LookInText;
        public  PopupList LookIn2;
        public  ListView ListView1;
        public  Header Header1;
        public  PushButton Name;
        public  PushButton Size;
        public  PushButton Type;
        public  PushButton DateModified;
        public  StaticText FileNameText;
        public  ComboBox FileName;
        public  StaticText FilesOfTypeText;
        public  PopupList FilesOfType;
        public  PushButton PreviousFolderAlt1;
        public  PushButton UpOneLevelAlt2;
        public  PushButton SearchTheWebAlt3;
        public  PushButton DeleteDel;
        public  PushButton CreateNewFolderAlt5;
        public  PushButton Views;
        public  PushButton Tools;
        public  PushButton Save;
        public  PushButton Cancel;
        public  StaticText PreviewText;
        public  PushButton Preview;

        partial void OnInitialize();

        public PandIDExportToAutoCADDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LookIn1 = new ListBox()
            {
                Tag = "[ListBox]#1|$13000",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn1);

            LookInText = new StaticText()
            {
                Tag = "[StaticText]#1|$13007",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInText);

            LookIn2 = new PopupList()
            {
                Tag = "[PopupList]#1|$13001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn2);

            ListView1 = new ListView()
            {
                Tag = "[ListView]#1|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView1);

            Header1 = new Header()
            {
                Tag = "[Header]#1|$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Header1);

            Name = new PushButton()
            {
                Tag = "#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Name);

            Size = new PushButton()
            {
                Tag = "#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size);

            Type = new PushButton()
            {
                Tag = "#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Type);

            DateModified = new PushButton()
            {
                Tag = "#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModified);

            FileNameText = new StaticText()
            {
                Tag = "[StaticText]#3|$13008",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);

            FileName = new ComboBox()
            {
                Tag = "[ComboBox]#1|$13006",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FilesOfTypeText = new StaticText()
            {
                Tag = "[StaticText]#4|$13009",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeText);

            FilesOfType = new PopupList()
            {
                Tag = "[PopupList]#2|$13002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType);

            PreviousFolderAlt1 = new PushButton()
            {
                Tag = "[PushButton]#1|$13011",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousFolderAlt1);

            UpOneLevelAlt2 = new PushButton()
            {
                Tag = "[PushButton]#2|$13003",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelAlt2);

            SearchTheWebAlt3 = new PushButton()
            {
                Tag = "[PushButton]#3|$13004",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebAlt3);

            DeleteDel = new PushButton()
            {
                Tag = "[PushButton]#4|$13014",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteDel);

            CreateNewFolderAlt5 = new PushButton()
            {
                Tag = "[PushButton]#5|$13013",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderAlt5);

            Views = new PushButton()
            {
                Tag = "[PushButton]#6|$13012",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Views);

            Tools = new PushButton()
            {
                Tag = "[PushButton]#7|$13005",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tools);

            Save = new PushButton()
            {
                Tag = "[PushButton]#9|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Save);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]#10|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            PreviewText = new StaticText()
            {
                Tag = "[StaticText]#2|$13100",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewText);

            Preview = new PushButton()
            {
                Tag = "[PushButton]#8|$13101",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Preview);
        }
    }
}
