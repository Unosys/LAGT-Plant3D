// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "Add Property|$AddPropertyDlg", Parent = typeof(ProjectSetupPandIDClassDefinitionDLG))]
    public partial class AddPropertyDLG : Pane
    {
        public  PushButton OKPB;
        public  PushButton M_btnCancel;
        public  TextField DisplayNameTF;
        public  StaticText DisplayNameST;
        public  TextField M_textBoxPropertyName;
        public  StaticText PropertyNameST;
        public  GroupBox ChooseATypeGB;
        public  RadioButton M_radioAcquisition;
        public  RadioButton RadioButton2RB;
        public  RadioButton RadioButton3RB;
        public  RadioButton RadioButton4RB;
        public  RadioButton RadioButton5RB;
        public  RadioButton RadioButton6RB;
        public  TitleBar AddPropertyCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AddPropertyDLG()
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

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

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

            M_textBoxPropertyName = new TextField()
            {
                Tag = "[TextField]Property name:|$m_textBoxPropertyName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxPropertyName);

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

            M_radioAcquisition = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioAcquisition|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioAcquisition);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioSelection|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            RadioButton3RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioBlock|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton3RB);

            RadioButton4RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioBoolean|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton4RB);

            RadioButton5RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioNumeric|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton5RB);

            RadioButton6RB = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioString|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton6RB);

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
