// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open", Parent = typeof(Plant3D))]
    public partial class PlantOpenDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PopupList LookIn;
        public  ToolBar LookIn1;
        public  PushButton PushButton1;
        public  PushButton PushButton2;
        public  PushButton PushButton3;
        public  PushButton PushButton4;
        public  ToolBar LookIn2;
        public  PushButton RecentPlaces;
        public  PushButton Desktop;
        public  PushButton Libraries;
        public  PushButton Computer;
        public  PushButton Network;
        public  ListView ListView1;
        public  Header Header1;
        public  PushButton Name;
        public  PushButton DateModified;
        public  PushButton Type;
        public  PushButton Size;
        public  ComboBox FileNameCB;
        public  PopupList FilesOfType;
        public  PushButton OpenPB;
        public  PushButton CancelPB;
        public  PushButton Help;
        public  ScrollBar ScrollBar1;
        public  DialogBox DialogBox1;

        partial void OnInitialize();

        public PlantOpenDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LookIn = new PopupList()
            {
                Tag = "[PopupList]$1137|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn);

            LookIn1 = new ToolBar()
            {
                Tag = "[ToolBar]$1088|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn1);

            PushButton1 = new PushButton()
            {
                Tag = "[PushButton]$40971|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1);

            PushButton2 = new PushButton()
            {
                Tag = "[PushButton]$40961|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2);

            PushButton3 = new PushButton()
            {
                Tag = "[PushButton]$40962|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3);

            PushButton4 = new PushButton()
            {
                Tag = "[PushButton]$40970|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4);

            LookIn2 = new ToolBar()
            {
                Tag = "[ToolBar]$1184|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn2);

            RecentPlaces = new PushButton()
            {
                Tag = "[PushButton]$41060|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RecentPlaces);

            Desktop = new PushButton()
            {
                Tag = "[PushButton]$41061|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Desktop);

            Libraries = new PushButton()
            {
                Tag = "[PushButton]$41062|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Libraries);

            Computer = new PushButton()
            {
                Tag = "[PushButton]$41063|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Computer);

            Network = new PushButton()
            {
                Tag = "[PushButton]$41064|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Network);

            ListView1 = new ListView()
            {
                Tag = "[ListView]$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView1);

            Header1 = new Header()
            {
                Tag = "[Header]$0|#1",
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

            DateModified = new PushButton()
            {
                Tag = "#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModified);

            Type = new PushButton()
            {
                Tag = "#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Type);

            Size = new PushButton()
            {
                Tag = "#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size);

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            FilesOfType = new PopupList()
            {
                Tag = "[PopupList]$1136|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType);

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Help = new PushButton()
            {
                Tag = "[PushButton]$1038|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            ScrollBar1 = new ScrollBar()
            {
                Tag = "[ScrollBar]$-1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScrollBar1);

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
