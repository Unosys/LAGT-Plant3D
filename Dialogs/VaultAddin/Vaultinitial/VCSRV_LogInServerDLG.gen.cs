// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SignInForm", Parent = typeof(VaultProServer), GUIType = GuiType.UIA)]
    public partial class VCSRV_LogInServerDLG : Pane
    {
        public  PopupList AuthenticationPL;
        public  TextField PasswordTF;
        public  TextField UserNameTF;
        public  PushButton CancelPB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public VCSRV_LogInServerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AuthenticationPL = new PopupList()
            {
                Tag = "[Pane]$tableLayoutPanel1/[PopupList]$loginTypeComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthenticationPL);

            PasswordTF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel1/[TextField]$m_passwordTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTF);

            UserNameTF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel1/[TextField]$m_userNameTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTF);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1/[Pane]$panel2/[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1/[Pane]$panel2/[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
