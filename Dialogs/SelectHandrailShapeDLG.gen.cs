// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Handrail Shape", Parent = typeof(MainWin))]
    public partial class SelectHandrailShapeDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText ShapeStandardST;
        public  PopupList PopupListPL;
        public  StaticText ShapeTypeST;
        public  TextField TextField1TF;
        public  PushButton Button1PB;
        public  StaticText ShapeSizeST;
        public  ListBox ShapeType1LB;
        public  TextField ShapeTypeTF;
        public  PushButton Button2PB;
        public  GroupBox GroupBoxGB;
        public  StaticText AngleST;
        public  PushButton nine0RotatePB;
        public  CheckBox FlipAboutYAxisCK;
        public  CheckBox AlignYAxisWithCK;
        public  StaticText HorizontalST;
        public  TextField TextField2TF;
        public  StaticText VerticalST;
        public  TextField VerticalTF;
        public  StaticText MaterialStandardST;
        public  PopupList MaterialStandardPL;
        public  StaticText MaterialCodeST;
        public  PopupList MaterialCodePL;
        public  PushButton Select;
        public  PushButton Cancel;
        public  PushButton HelpPB;
        public  StaticText PreviewST;
        public  StaticText StaticText1ST;
        public  StaticText StaticText2ST;
        public  PushButton MatchPropertiesPB;
        public  ListBox ShapeType2LB;
        public  ComboBox AngleCB;

        partial void OnInitialize();

        public SelectHandrailShapeDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ShapeStandardST = new StaticText()
            {
                Tag = "[StaticText]Shape standard:|$1566|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeStandardST);

            PopupListPL = new PopupList()
            {
                Tag = "[PopupList]$1003|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            ShapeTypeST = new StaticText()
            {
                Tag = "[StaticText]Shape type:|$1567|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeTypeST);

            TextField1TF = new TextField()
            {
                Tag = "[TextField]$1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            Button1PB = new PushButton()
            {
                Tag = "[PushButton]Button1|$2556|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button1PB);

            ShapeSizeST = new StaticText()
            {
                Tag = "[StaticText]Shape size:|$1568|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeSizeST);

            ShapeType1LB = new ListBox()
            {
                Tag = "[ListBox]Shape type:[1]|$1039|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeType1LB);

            ShapeTypeTF = new TextField()
            {
                Tag = "[TextField]Shape type:|$1000|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeTypeTF);

            Button2PB = new PushButton()
            {
                Tag = "[PushButton]Button2|$2557|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button2PB);

            GroupBoxGB = new GroupBox()
            {
                Tag = "[GroupBox]$1468|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxGB);

            AngleST = new StaticText()
            {
                Tag = "[StaticText]Angle:|$1572|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AngleST);

            nine0RotatePB = new PushButton()
            {
                Tag = "[PushButton]-90 rotate|$1031|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(nine0RotatePB);

            FlipAboutYAxisCK = new CheckBox()
            {
                Tag = "[CheckBox]Flip about Y axis|$1070|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlipAboutYAxisCK);

            AlignYAxisWithCK = new CheckBox()
            {
                Tag = "[CheckBox]Align Y axis with Z UCS|$1071|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlignYAxisWithCK);

            HorizontalST = new StaticText()
            {
                Tag = "[StaticText]Horizontal:|$1574|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalST);

            TextField2TF = new TextField()
            {
                Tag = "[TextField]$1036|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            VerticalST = new StaticText()
            {
                Tag = "[StaticText]Vertical:|$1575|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalST);

            VerticalTF = new TextField()
            {
                Tag = "[TextField]Vertical:|$1040|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalTF);

            MaterialStandardST = new StaticText()
            {
                Tag = "[StaticText]Material standard:|$1469|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialStandardST);

            MaterialStandardPL = new PopupList()
            {
                Tag = "[PopupList]Material standard:|$1403|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialStandardPL);

            MaterialCodeST = new StaticText()
            {
                Tag = "[StaticText]Material code:|$1471|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialCodeST);

            MaterialCodePL = new PopupList()
            {
                Tag = "[PopupList]Material code:|$1004|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialCodePL);

            Select = new PushButton()
            {
                Tag = "[PushButton]Select|$1037|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Select);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$1038|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$1030|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            PreviewST = new StaticText()
            {
                Tag = "[StaticText]Preview|$1573|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewST);

            StaticText1ST = new StaticText()
            {
                Tag = "[StaticText]$2571|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            StaticText2ST = new StaticText()
            {
                Tag = "[StaticText]$2572|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            MatchPropertiesPB = new PushButton()
            {
                Tag = "[PushButton]Match Properties|$1053|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchPropertiesPB);

            ShapeType2LB = new ListBox()
            {
                Tag = "[ListBox]Shape type:[2]|$1034|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeType2LB);

            AngleCB = new ComboBox()
            {
                Tag = "[ComboBox]Angle:|$1404|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AngleCB);
        }
    }
}
