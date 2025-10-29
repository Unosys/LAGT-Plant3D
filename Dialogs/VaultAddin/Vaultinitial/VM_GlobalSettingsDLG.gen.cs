// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Global Settings|$AdminToolForm", Parent = typeof(VaultPro), GUIType = GuiType.UIA)]
    public partial class VM_GlobalSettingsDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton ConfigurePB_BackgroundColor;
        public  PushButton ManageAccessPB;
        public  PushButton ManageRolesPB;
        public  CheckBox EnforcePasswordPolicyCK;
        public  PushButton ConfigurePB_Password;
        public  PushButton DefinePB;
        public  CheckBox EnableJobServerCK;
        public  PushButton ConfigurePB_Job;
        public  PushButton ConfigurePB_JobFail;
        public  CheckBox EnableJobRetryCK;

        partial void OnInitialize();

        public VM_GlobalSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#2/[PushButton]Close|$m_closeButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ConfigurePB_BackgroundColor = new PushButton()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Security/[Pane]$UserManagementAdminPage/[Pane]$adminBackgroundColorControl1/[PushButton]$m_configureButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfigurePB_BackgroundColor);

            ManageAccessPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$adminToolTabControl1|#1/[PageList]$tabControl1|#1/[Pane]Security|$2951024|#1/[Pane]$UserManagementAdminPage|#1/[Pane]$userManagementControl1|#1/[PushButton]Manage Access*|$m_userButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManageAccessPB);

            ManageRolesPB = new PushButton()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Security/[Pane]$UserManagementAdminPage/[Pane]$rolesAndPermissionsControl1/[PushButton]$m_rolesButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManageRolesPB);

            EnforcePasswordPolicyCK = new CheckBox()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Security/[Pane]$UserManagementAdminPage/[Pane]$userManagementControl1/[CheckBox]$m_passwordPolicyCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnforcePasswordPolicyCK);

            ConfigurePB_Password = new PushButton()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Security/[Pane]$UserManagementAdminPage/[Pane]$userManagementControl1/[PushButton]$m_configureButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfigurePB_Password);

            DefinePB = new PushButton()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Change Orders/[Pane]$ChangeOrderGlobalAdminPage/[Pane]$routingDefinitionControl/[PushButton]$m_defineButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefinePB);

            EnableJobServerCK = new CheckBox()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Integrations/[Pane]$IntegrationsAdminPage/[Pane]$JobQueueOptionsControl/[CheckBox]$m_jobQueueForUpdateViewOption",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnableJobServerCK);

            ConfigurePB_Job = new PushButton()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Integrations/[Pane]$IntegrationsAdminPage/[Pane]$JobQueueOptionsControl/[PushButton]$m_configButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfigurePB_Job);

            ConfigurePB_JobFail = new PushButton()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Integrations/[Pane]$IntegrationsAdminPage/[Pane]$JobQueueOptionsControl/[PushButton]$m_configFailedButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfigurePB_JobFail);

            EnableJobRetryCK = new CheckBox()
            {
                Tag = "[Pane]$adminToolTabControl1/[PageList]$tabControl1/[Pane]Integrations/[Pane]$IntegrationsAdminPage/[Pane]$JobQueueOptionsControl/[CheckBox]$m_setRetryAutoForFailedJobOption",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnableJobRetryCK);
        }
    }
}
