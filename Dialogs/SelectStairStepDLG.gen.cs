// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Step", Parent = typeof(StairSettingsDLG), GUIType = GuiType.UIA)]
    public partial class SelectStairStepDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText TreadStandardST;
        public  ListBox TreadStandardLB;
        public  StaticText StaticTextST;
        public  StaticText TreadShapeST;
        public  ListBox TreadShapeLB;
        public  GroupBox DimensionsGB;
        public  StaticText SizeST;
        public  TextField SizeTF;
        public  StaticText Height1ST;
        public  TextField Height1TF;
        public  StaticText Width2ST;
        public  TextField Width2TF;
        public  StaticText Chamfer3ST;
        public  TextField Chamfer3TF;
        public  PushButton AddPB;
        public  PushButton RemovePB;
        public  PushButton OK;
        public  PushButton Cancel;
        public  PushButton Help;

        partial void OnInitialize();

        public SelectStairStepDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TreadStandardST = new StaticText()
            {
                Tag = "[StaticText]Tread standard:|$2540|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreadStandardST);

            TreadStandardLB = new ListBox()
            {
                Tag = "[ListBox]Tread standard:|$1074|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreadStandardLB);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$-1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            TreadShapeST = new StaticText()
            {
                Tag = "[StaticText]Tread shape:|$2541|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreadShapeST);

            TreadShapeLB = new ListBox()
            {
                Tag = "[ListBox]Tread shape:|$1259|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreadShapeLB);

            DimensionsGB = new GroupBox()
            {
                Tag = "[GroupBox]Dimensions|$2545|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsGB);

            SizeST = new StaticText()
            {
                Tag = "[StaticText]Size:|$2550|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeST);

            SizeTF = new TextField()
            {
                Tag = "[TextField]Size:|$1000|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeTF);

            Height1ST = new StaticText()
            {
                Tag = "[StaticText]Height (1):|$2547|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Height1ST);

            Height1TF = new TextField()
            {
                Tag = "[TextField]Height (1):|$1001|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Height1TF);

            Width2ST = new StaticText()
            {
                Tag = "[StaticText]Width (2):|$2548|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Width2ST);

            Width2TF = new TextField()
            {
                Tag = "[TextField]Width (2):|$1002|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Width2TF);

            Chamfer3ST = new StaticText()
            {
                Tag = "[StaticText]Chamfer (3):|$2549|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Chamfer3ST);

            Chamfer3TF = new TextField()
            {
                Tag = "[TextField]Chamfer (3):|$1003|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Chamfer3TF);

            AddPB = new PushButton()
            {
                Tag = "[PushButton]Add|$2542|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            RemovePB = new PushButton()
            {
                Tag = "[PushButton]Remove|$2543|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$3|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);
        }
    }
}
