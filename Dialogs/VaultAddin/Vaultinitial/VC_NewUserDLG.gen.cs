// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$UserProfileForm", Parent = typeof(VC_UserAndGroupManagementDLG))]
    public partial class VC_NewUserDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton GroupsPB;
        public  PushButton VaultsPB;
        public  PushButton RolesPB;
        public  PushButton AccountsPB;
        public  TextField EmailAliasTF;
        public  TextField DisplayNameTF;
        public  TextField FirstNameTF;
        public  TextField LastNameTF;

        partial void OnInitialize();

        public VC_NewUserDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_dialogButtonPanel/[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_dialogButtonPanel/[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            GroupsPB = new PushButton()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_rolesVaultsPanel/[PushButton]$m_groupsButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupsPB);

            VaultsPB = new PushButton()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_rolesVaultsPanel/[PushButton]$m_vaultsButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultsPB);

            RolesPB = new PushButton()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_rolesVaultsPanel/[PushButton]$m_rolesButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RolesPB);

            AccountsPB = new PushButton()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_rolesVaultsPanel/[PushButton]$m_authByButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AccountsPB);

            EmailAliasTF = new TextField()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_nameEmailPanel/[TextField]$m_emailTextEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EmailAliasTF);

            DisplayNameTF = new TextField()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_nameEmailPanel/[TextField]$m_loginNameTextEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameTF);

            FirstNameTF = new TextField()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_attributesTableLayoutPanel/[Pane]$m_attributesPanel/[Pane]#1/[TextField]$m_profAttrValTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FirstNameTF);

            LastNameTF = new TextField()
            {
                Tag = "[Pane]$m_userProfileTableLayoutPanel/[Pane]$m_attributesTableLayoutPanel/[Pane]$m_attributesPanel/[Pane]#2/[TextField]$m_profAttrValTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LastNameTF);
        }
    }
}
