// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$SelectStandardsDlg")]
    public partial class PandIDStandardsCentrifugalBlowerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelButton;
        public  CheckBox CheckBoxDin;
        public  CheckBox CheckBoxIsa;
        public  CheckBox CheckBoxIso;
        public  CheckBox CheckBoxJis;
        public  CheckBox CheckBoxPip;
        public  GroupBox GroupBox1;
        public  PushButton OkButton;

        partial void OnInitialize();

        public PandIDStandardsCentrifugalBlowerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelButton = new PushButton()
            {
                Tag = "[PushButton]$cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelButton);

            CheckBoxDin = new CheckBox()
            {
                Tag = "[CheckBox]$checkBoxDin",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBoxDin);

            CheckBoxIsa = new CheckBox()
            {
                Tag = "[CheckBox]$checkBoxIsa",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBoxIsa);

            CheckBoxIso = new CheckBox()
            {
                Tag = "[CheckBox]$checkBoxIso",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBoxIso);

            CheckBoxJis = new CheckBox()
            {
                Tag = "[CheckBox]$checkBoxJis",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBoxJis);

            CheckBoxPip = new CheckBox()
            {
                Tag = "[CheckBox]$checkBoxPip",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBoxPip);

            GroupBox1 = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox1);

            OkButton = new PushButton()
            {
                Tag = "[PushButton]$okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkButton);
        }
    }
}
