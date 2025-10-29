// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$UserVaultsDialog", Parent = typeof(VC_NewUserDLG))]
    public partial class VC_AddVaultsDLG : Pane
    {
        public  PushButton M_cancelButton;
        public  PushButton OKPB;
        public  CheckBox VaultCK;
        public  CheckBox SelectUnselectAllCK;

        partial void OnInitialize();

        public VC_AddVaultsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_cancelButton = new PushButton()
            {
                Tag = "[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cancelButton);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            VaultCK = new CheckBox()
            {
                Tag = "[ListBox]$m_vaultCheckedListBoxControl/[CheckBox]Vault",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultCK);

            SelectUnselectAllCK = new CheckBox()
            {
                Tag = "[CheckBox]$m_selectAllCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectUnselectAllCK);
        }
    }
}
