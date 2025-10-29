// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AddPropertyDlg", Parent = typeof(Pane))]
    public partial class PandIDAddPropertyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  GroupBox M_groupBox;
        public  StaticText M_labelDisplay;
        public  StaticText M_labelProperty;
        public  TextField M_textBoxDisplayName;
        public  TextField M_textBoxPropertyName;
        public  RadioButton M_radioAcquisition;
        public  RadioButton M_radioSelection;
        public  RadioButton M_radioBlock;
        public  RadioButton M_radioBoolean;
        public  RadioButton M_radioNumeric;
        public  RadioButton M_radioString;

        partial void OnInitialize();

        public PandIDAddPropertyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_groupBox = new GroupBox()
            {
                Tag = "[Group]$m_groupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBox);

            M_labelDisplay = new StaticText()
            {
                Tag = "[StaticText]$m_labelDisplay",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelDisplay);

            M_labelProperty = new StaticText()
            {
                Tag = "[StaticText]$m_labelProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelProperty);

            M_textBoxDisplayName = new TextField()
            {
                Tag = "[TextField]$m_textBoxDisplayName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxDisplayName);

            M_textBoxPropertyName = new TextField()
            {
                Tag = "[TextField]$m_textBoxPropertyName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxPropertyName);

            M_radioAcquisition = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioAcquisition|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioAcquisition);

            M_radioSelection = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioSelection|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioSelection);

            M_radioBlock = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioBlock|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioBlock);

            M_radioBoolean = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioBoolean|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioBoolean);

            M_radioNumeric = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioNumeric|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioNumeric);

            M_radioString = new RadioButton()
            {
                Tag = "[GroupBox]Choose a type|$m_groupBox|#1/[RadioButton]$m_radioString|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioString);
        }
    }
}
