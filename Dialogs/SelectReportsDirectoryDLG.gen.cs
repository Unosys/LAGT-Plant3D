// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Reports Directory", Parent = typeof(Plant3D))]
    public partial class SelectReportsDirectoryDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  PushButton PreviousFolderAlt1;
        public  PushButton UpOneLevelAlt2;
        public  PushButton SearchTheWebAlt3;
        public  PushButton DeleteDel;
        public  PushButton CreateNewFolderAlt5;
        public  PushButton Views;
        public  PushButton Tools;
        public  PushButton Open;
        public  PushButton Cancel;

        partial void OnInitialize();

        public SelectReportsDirectoryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LookIn1 = new ListBox()
            {
                Tag = "[ListBox]Look in:|#1|$13000",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn1);

            LookInText = new StaticText()
            {
                Tag = "[StaticText]Look in:|#1|$13007",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInText);

            LookIn2 = new PopupList()
            {
                Tag = "[PopupList]Look in:|#1|$13001",
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
                Tag = "[PushButton]Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Name);

            Size = new PushButton()
            {
                Tag = "[PushButton]Size|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size);

            Type = new PushButton()
            {
                Tag = "[PushButton]Type|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Type);

            DateModified = new PushButton()
            {
                Tag = "[PushButton]Date Modified|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModified);

            PreviousFolderAlt1 = new PushButton()
            {
                Tag = "[PushButton]Previous folder(Alt+1)|#1|$13011",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousFolderAlt1);

            UpOneLevelAlt2 = new PushButton()
            {
                Tag = "[PushButton]Up one level (Alt+2)|#2|$13003",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelAlt2);

            SearchTheWebAlt3 = new PushButton()
            {
                Tag = "[PushButton]Search the Web (Alt+3)|#3|$13004",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebAlt3);

            DeleteDel = new PushButton()
            {
                Tag = "[PushButton]Delete (Del)|#4|$13014",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteDel);

            CreateNewFolderAlt5 = new PushButton()
            {
                Tag = "[PushButton]Create New Folder (Alt+5)|#5|$13013",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderAlt5);

            Views = new PushButton()
            {
                Tag = "[PushButton]Views|#6|$13012",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Views);

            Tools = new PushButton()
            {
                Tag = "[PushButton]Tools|#7|$13005",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tools);

            Open = new PushButton()
            {
                Tag = "[PushButton]Open|#8|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|#9|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
