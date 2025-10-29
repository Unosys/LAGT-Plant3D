// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Create Grid", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class CreateGridDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText GridNameST;
        public  TextField GridNameTF;
        public  StaticText AxisValueST;
        public  TextField AxisValueTF;
        public  PushButton G1PB;
        public  PushButton PushButton1PB;
        public  StaticText AxisNamelocalXST;
        public  TextField AxisNamelocalXTF;
        public  StaticText RowValueST;
        public  TextField RowValueTF;
        public  PushButton G2PB;
        public  PushButton PushButton2PB;
        public  StaticText RowNamelocalYST;
        public  TextField RowNamelocalYTF;
        public  StaticText PlatformValueST;
        public  TextField PlatformValueTF;
        public  PushButton G3PB;
        public  PushButton PushButton3PB;
        public  StaticText PlatformNamelocalZST;
        public  TextField PlatformNamelocalZTF;
        public  GroupBox CoordinateSystemGB;
        public  RadioButton GridName1RB;
        public  RadioButton GridName2RB;
        public  RadioButton AxisNamelocalXRB;
        public  GroupBox FontSizeGB;
        public  TextField FontSizeTF;
        public  PushButton Create;
        public  PushButton Cancel;
        public  PushButton Help;

        partial void OnInitialize();

        public CreateGridDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            GridNameST = new StaticText()
            {
                Tag = "[StaticText]Grid name:|$1557|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GridNameST);

            GridNameTF = new TextField()
            {
                Tag = "[TextField]Grid name:|$1000|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GridNameTF);

            AxisValueST = new StaticText()
            {
                Tag = "[StaticText]Axis value:|$1561|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AxisValueST);

            AxisValueTF = new TextField()
            {
                Tag = "[TextField]Axis value:|$1005|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AxisValueTF);

            G1PB = new PushButton()
            {
                Tag = "[PushButton]g[1]|$1369|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(G1PB);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]->[1]|$1354|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            AxisNamelocalXST = new StaticText()
            {
                Tag = "[StaticText]Axis name (local X):|$1558|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AxisNamelocalXST);

            AxisNamelocalXTF = new TextField()
            {
                Tag = "[TextField]Axis name (local X):|$1002|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AxisNamelocalXTF);

            RowValueST = new StaticText()
            {
                Tag = "[StaticText]Row value:|$1562|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RowValueST);

            RowValueTF = new TextField()
            {
                Tag = "[TextField]Row value:|$1006|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RowValueTF);

            G2PB = new PushButton()
            {
                Tag = "[PushButton]g[2]|$1370|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(G2PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]->[2]|$1353|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            RowNamelocalYST = new StaticText()
            {
                Tag = "[StaticText]Row name (local Y):|$1559|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RowNamelocalYST);

            RowNamelocalYTF = new TextField()
            {
                Tag = "[TextField]Row name (local Y):|$1004|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RowNamelocalYTF);

            PlatformValueST = new StaticText()
            {
                Tag = "[StaticText]Platform value:|$1563|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlatformValueST);

            PlatformValueTF = new TextField()
            {
                Tag = "[TextField]Platform value:|$1008|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlatformValueTF);

            G3PB = new PushButton()
            {
                Tag = "[PushButton]g[3]|$1371|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(G3PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[PushButton]->[3]|$1352|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            PlatformNamelocalZST = new StaticText()
            {
                Tag = "[StaticText]Platform name (local Z):|$1560|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlatformNamelocalZST);

            PlatformNamelocalZTF = new TextField()
            {
                Tag = "[TextField]Platform name (local Z):|$1007|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PlatformNamelocalZTF);

            CoordinateSystemGB = new GroupBox()
            {
                Tag = "[GroupBox]Coordinate system|$1564|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CoordinateSystemGB);

            GridName1RB = new RadioButton()
            {
                Tag = "[RadioButton]Grid name:[1]|$1045|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GridName1RB);

            GridName2RB = new RadioButton()
            {
                Tag = "[RadioButton]Grid name:[2]|$1046|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GridName2RB);

            AxisNamelocalXRB = new RadioButton()
            {
                Tag = "[RadioButton]Axis name (local X):|$1047|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AxisNamelocalXRB);

            FontSizeGB = new GroupBox()
            {
                Tag = "[GroupBox]Font size:|$1565|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FontSizeGB);

            FontSizeTF = new TextField()
            {
                Tag = "[TextField]Font size:|$1001|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FontSizeTF);

            Create = new PushButton()
            {
                Tag = "[PushButton]Create|$1|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Create);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$1003|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$1052|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);
        }
    }
}
