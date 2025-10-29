// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$UserAccountsDialog", Parent = typeof(VC_NewUserDLG))]
    public partial class VC_AddAuthenticationAccountDLG : Autodesk.GUIHarness.Pane
    {
        public  ListBox ListBoxLB;
        public  CheckBox WindowsAuthenticationCK;
        public  CheckBox VaultAccountCK;
        public  CheckBox AutodeskIDCK;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton SelectDomainUserPB;
        public  TextField ConfirmPasswordTF;
        public  TextField PasswordTF;
        public  TextField UserNameTF;
        public  TextField AutodeskIDCredentialsTF;

        partial void OnInitialize();

        public VC_AddAuthenticationAccountDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[ListBox]$m_accountsCheckedListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            WindowsAuthenticationCK = new CheckBox()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[ListBox]$m_accountsCheckedListBox/[CheckBox]Windows Authentication",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WindowsAuthenticationCK);

            VaultAccountCK = new CheckBox()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[ListBox]$m_accountsCheckedListBox/[CheckBox]Vault Account",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultAccountCK);

            AutodeskIDCK = new CheckBox()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[ListBox]$m_accountsCheckedListBox/[CheckBox]Autodesk ID",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskIDCK);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[Pane]$m_buttonsPanel/[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[Pane]$m_buttonsPanel/[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            SelectDomainUserPB = new PushButton()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[Pane]$m_settingsPanel/[Pane]$WinAccountSettingsControl/[Pane]$panel1/[PushButton]$m_browseDomainUsrButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectDomainUserPB);

            ConfirmPasswordTF = new TextField()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[Pane]$m_settingsPanel/[Pane]$VaultAccountSettingsControl/[Pane]$panel1/[TextField]$m_confirmPasswordTextEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfirmPasswordTF);

            PasswordTF = new TextField()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[Pane]$m_settingsPanel/[Pane]$VaultAccountSettingsControl/[Pane]$panel1/[TextField]$m_passwordTextEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTF);

            UserNameTF = new TextField()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[Pane]$m_settingsPanel/[Pane]$VaultAccountSettingsControl/[Pane]$panel1/[TextField]$m_loginNameTextEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTF);

            AutodeskIDCredentialsTF = new TextField()
            {
                Tag = "[Pane]$m_authTableLayoutPanel/[Pane]$m_settingsPanel/[Pane]$ADSKIdAccountSettingsControl/[Pane]$panel1/[TextField]$m_emailTextEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskIDCredentialsTF);
        }
    }
}
