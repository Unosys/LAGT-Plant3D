// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AddPropertyDlg", Parent = typeof(ProjectSetupPlant3DDWG))]
    public partial class P3DAddPropertyDLG : Pane
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  TextField DisplayNameTF;
        public  StaticText DisplayNameST;
        public  TextField PropertyNameTF;
        public  StaticText PropertyNameST;
        public  GroupBox ChooseATypeGB;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  RadioButton RadioButton3RB;
        public  RadioButton RadioButton4RB;
        public  RadioButton RadioButton5RB;
        public  RadioButton RadioButton6RB;
        public  RadioButton RadioButton7RB;
        public  TitleBar AddPropertyCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public P3DAddPropertyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            DisplayNameTF = new TextField()
            {
                Tag = "[TextField]Display name:|$m_textBoxDisplayName|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameTF);

            DisplayNameST = new StaticText()
            {
                Tag = "[StaticText]Display name:|$m_labelDisplay|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameST);

            PropertyNameTF = new TextField()
            {
                Tag = "[TextField]Property name:|$m_textBoxPropertyName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameTF);

            PropertyNameST = new StaticText()
            {
                Tag = "[StaticText]Property name:|$m_labelProperty|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameST);

            ChooseATypeGB = new GroupBox()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseATypeGB);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioCalculated|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioAcquisition|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            RadioButton3RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioSelection|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton3RB);

            RadioButton4RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioBlock|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton4RB);

            RadioButton5RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioBoolean|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton5RB);

            RadioButton6RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioNumeric|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton6RB);

            RadioButton7RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioString|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton7RB);

            AddPropertyCTL = new TitleBar()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1/[CustomWin]System Menu Bar|$AddPropertyDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1/[CustomWin]System Menu Bar|$AddPropertyDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
