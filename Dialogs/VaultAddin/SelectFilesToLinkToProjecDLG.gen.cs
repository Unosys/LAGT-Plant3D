// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Files to Link to Project", Parent = typeof(PROJECTMANAGERDLG))]
    public partial class SelectFilesToLinkToProjecDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListView1Class ListView1;
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
        public  PushButton Open;
        public  PushButton Cancel;
        public  ListBox LookIn1;
        public  StaticText LookInText;
        public  PopupList LookIn2;

        partial void OnInitialize();

        public SelectFilesToLinkToProjecDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ListView1 = new ListView1Class()
            {
                Tag = "$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView1);

            FileNameText = new StaticText()
            {
                Tag = "$13008",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);

            FileName = new ComboBox()
            {
                Tag = "$13006",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FilesOfTypeText = new StaticText()
            {
                Tag = "$13009",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeText);

            FilesOfType = new PopupList()
            {
                Tag = "$13002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType);

            PreviousFolderAlt1 = new PushButton()
            {
                Tag = "$13011",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousFolderAlt1);

            UpOneLevelAlt2 = new PushButton()
            {
                Tag = "$13003",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelAlt2);

            SearchTheWebAlt3 = new PushButton()
            {
                Tag = "$13004",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebAlt3);

            DeleteDel = new PushButton()
            {
                Tag = "$13014",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteDel);

            CreateNewFolderAlt5 = new PushButton()
            {
                Tag = "$13013",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderAlt5);

            Views = new PushButton()
            {
                Tag = "$13012",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Views);

            Tools = new PushButton()
            {
                Tag = "$13005",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tools);

            Open = new PushButton()
            {
                Tag = "$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            LookIn1 = new ListBox()
            {
                Tag = "$13000",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn1);

            LookInText = new StaticText()
            {
                Tag = "$13007",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInText);

            LookIn2 = new PopupList()
            {
                Tag = "$13001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn2);
        }

        public partial class ListView1Class : ListView
        {
            public Header1Class Header1;

            partial void OnInitialize();

            public ListView1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "$1";
                ParentType = this.GetType();

                Header1 = new Header1Class()
                {
                    Tag = "$0",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Header1);
            }
        }

        public partial class Header1Class : Header
        {
            public PushButton Name;
            public PushButton DateModified;
            public PushButton Type;
            public PushButton Size;

            partial void OnInitialize();

            public Header1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "$0";
                ParentType = this.GetType();

                Name = new PushButton()
                {
                    Tag = "Name",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Name);

                DateModified = new PushButton()
                {
                    Tag = "Date modified",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(DateModified);

                Type = new PushButton()
                {
                    Tag = "Type",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Type);

                Size = new PushButton()
                {
                    Tag = "Size",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Size);
            }
        }
    }
}
