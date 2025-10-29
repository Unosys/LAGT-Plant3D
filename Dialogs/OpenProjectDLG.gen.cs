// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]OpenProjectDLG", Parent = typeof(Plant3D))]
    public partial class OpenProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText LookInText;
        public  PopupList LookIn;
        public  ToolBar LookIn1;
        public  PushButton PushButton1;
        public  PushButton PushButton2;
        public  PushButton PushButton3;
        public  PushButton PushButton4;
        public  ToolBar LookIn2;
        public  PushButton MyRecentDocuments;
        public  PushButton Desktop;
        public  PushButton MyDocuments;
        public  PushButton MyComputer;
        public  PushButton MyNetworkPlaces;
        public  ListView ListView1;
        public  StaticText FileNameText;
        public  ComboBox FileName;
        public  StaticText FilesOfTypeText;
        public  PopupList FilesOfType1;
        public  PushButton Open;
        public  PushButton Cancel;
        public  ScrollBar FilesOfType2;
        public  DialogBox DialogBox1;

        partial void OnInitialize();

        public OpenProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LookInText = new StaticText()
            {
                Tag = "[StaticText]#1|$1091",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInText);

            LookIn = new PopupList()
            {
                Tag = "[PopupList]#1|$1137",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn);

            LookIn1 = new ToolBar()
            {
                Tag = "[ToolBar]#1|$1088",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn1);

            PushButton1 = new PushButton()
            {
                Tag = "[PushButton]#1|$40971",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1);

            PushButton2 = new PushButton()
            {
                Tag = "[PushButton]#2|$40961",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2);

            PushButton3 = new PushButton()
            {
                Tag = "[PushButton]#3|$40962",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3);

            PushButton4 = new PushButton()
            {
                Tag = "[PushButton]#4|$40970",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4);

            LookIn2 = new ToolBar()
            {
                Tag = "[ToolBar]#2|$1184",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn2);

            MyRecentDocuments = new PushButton()
            {
                Tag = "[PushButton]#1|$41060",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MyRecentDocuments);

            Desktop = new PushButton()
            {
                Tag = "[PushButton]#2|$41061",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Desktop);

            MyDocuments = new PushButton()
            {
                Tag = "[PushButton]#3|$41062",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MyDocuments);

            MyComputer = new PushButton()
            {
                Tag = "[PushButton]#4|$41063",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MyComputer);

            MyNetworkPlaces = new PushButton()
            {
                Tag = "[PushButton]#5|$41064",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MyNetworkPlaces);

            ListView1 = new ListView()
            {
                Tag = "[ListView]#1|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView1);

            FileNameText = new StaticText()
            {
                Tag = "[StaticText]#2|$1090",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);

            FileName = new ComboBox()
            {
                Tag = "[ComboBox]#1|$1148",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FilesOfTypeText = new StaticText()
            {
                Tag = "[StaticText]#3|$1089",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeText);

            FilesOfType1 = new PopupList()
            {
                Tag = "[PopupList]#2|$1136",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType1);

            Open = new PushButton()
            {
                Tag = "[PushButton]#1|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]#2|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            FilesOfType2 = new ScrollBar()
            {
                Tag = "[ScrollBar]#1|$-1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType2);

            DialogBox1 = new DialogBox()
            {
                Tag = "$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DialogBox1);
        }
    }
}
