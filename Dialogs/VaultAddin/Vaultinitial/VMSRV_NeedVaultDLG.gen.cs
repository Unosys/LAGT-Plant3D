// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CommonMessageBox", Parent = typeof(VaultProServer))]
    public partial class VMSRV_NeedVaultDLG : Autodesk.GUIHarness.Pane
    {
        public  PushButton YesPB;
        public  GroupBox TableLayoutPanel1;
        public  StaticText M_errorText;
        public  GroupBox TableLayoutPanel2;
        public  PushButton M_yesButton;
        public  PushButton M_noButton;

        partial void OnInitialize();

        public VMSRV_NeedVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YesPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1/[Pane]$tableLayoutPanel2/[PushButton]$button2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            TableLayoutPanel1 = new GroupBox()
            {
                Tag = "[GroupBox]$tableLayoutPanel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPanel1);

            M_errorText = new StaticText()
            {
                Tag = "[StaticText]$m_errorText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_errorText);

            TableLayoutPanel2 = new GroupBox()
            {
                Tag = "[GroupBox]$tableLayoutPanel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPanel2);

            M_yesButton = new PushButton()
            {
                Tag = "[PushButton]$button2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_yesButton);

            M_noButton = new PushButton()
            {
                Tag = "[PushButton]$button1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_noButton);
        }
    }
}
