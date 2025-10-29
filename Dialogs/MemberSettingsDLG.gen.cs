// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Member Settings", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class MemberSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PopupList PopupListPL;
        public  TextField TextField1TF;
        public  PushButton Button1PB;
        public  ListBox ShapeType1LB;
        public  TextField ShapeTypeTF;
        public  PushButton Button2PB;
        public  PushButton nine0RotatePB;
        public  CheckBox FlipAboutYAxisCK;
        public  CheckBox AlignYAxisWithCK;
        public  TextField TextField2TF;
        public  TextField VerticalTF;
        public  PopupList MaterialStandardPL;
        public  PopupList MaterialCodePL;
        public  PushButton OK;
        public  PushButton Cancel;
        public  PushButton HelpPB;
        public  ListBox ShapeType2LB;
        public  ComboBox AngleCB;

        partial void OnInitialize();

        public MemberSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PopupListPL = new PopupList()
            {
                Tag = "[PopupList]$1003",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            TextField1TF = new TextField()
            {
                Tag = "[TextField]$1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            Button1PB = new PushButton()
            {
                Tag = "[PushButton]Button1|$2556",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button1PB);

            ShapeType1LB = new ListBox()
            {
                Tag = "[ListBox]Shape type:[1]|$1039",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeType1LB);

            ShapeTypeTF = new TextField()
            {
                Tag = "[TextField]Shape type:|$1000",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeTypeTF);

            Button2PB = new PushButton()
            {
                Tag = "[PushButton]Button2|$2557",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Button2PB);

            nine0RotatePB = new PushButton()
            {
                Tag = "[PushButton]-90 rotate|$1031",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(nine0RotatePB);

            FlipAboutYAxisCK = new CheckBox()
            {
                Tag = "[CheckBox]Flip about Y axis|$1070",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlipAboutYAxisCK);

            AlignYAxisWithCK = new CheckBox()
            {
                Tag = "[CheckBox]Align Y axis with Z UCS|$1071",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlignYAxisWithCK);

            TextField2TF = new TextField()
            {
                Tag = "[TextField]$1036",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            VerticalTF = new TextField()
            {
                Tag = "[TextField]Vertical:|$1040",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalTF);

            MaterialStandardPL = new PopupList()
            {
                Tag = "[PopupList]Material standard:|$1403",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialStandardPL);

            MaterialCodePL = new PopupList()
            {
                Tag = "[PopupList]Material code:|$1004",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialCodePL);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$1037",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$1038",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$1030",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            ShapeType2LB = new ListBox()
            {
                Tag = "[ListBox]Shape type:[2]|$1034",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShapeType2LB);

            AngleCB = new ComboBox()
            {
                Tag = "[ComboBox]Angle:|$1404",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AngleCB);
        }
    }
}
