// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateVaultForm", Parent = typeof(VaultProServer))]
    public partial class VMSRV_CreatVaultDLG : Pane
    {
        public  TextField M_vaultNameTextBox;
        public  PushButton M_okButton;
        public  CheckBox UseConfigurationCK;
        public  PopupList ConfigurationPL;

        partial void OnInitialize();

        public VMSRV_CreatVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_vaultNameTextBox = new TextField()
            {
                Tag = "[TextField]$m_vaultNameTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_vaultNameTextBox);

            M_okButton = new PushButton()
            {
                Tag = "[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_okButton);

            UseConfigurationCK = new CheckBox()
            {
                Tag = "[GroupBox]$_groupBoxConfiguration/[Pane]$_tableLayoutPanelConfiguration/[CheckBox]$_checkBoxUseConfiguration",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseConfigurationCK);

            ConfigurationPL = new PopupList()
            {
                Tag = "[GroupBox]$_groupBoxConfiguration/[Pane]$_tableLayoutPanelConfiguration/[PopupList]$cbSelectConfig",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfigurationPL);
        }
    }
}
