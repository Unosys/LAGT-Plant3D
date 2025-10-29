// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$UserRolesDialog", Parent = typeof(VC_NewUserDLG))]
    public partial class VC_AddRolesDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  ListBox TheseAreTheRolesLB;
        public  CheckBox AdministratorCK;
        public  CheckBox ProjectAdministratorCK;
        public  CheckBox SecurityAdministratorCK;
        public  CheckBox ItemReviewerCK;

        partial void OnInitialize();

        public VC_AddRolesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            TheseAreTheRolesLB = new ListBox()
            {
                Tag = "[ListBox]$m_userRolesCheckedListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheseAreTheRolesLB);

            AdministratorCK = new CheckBox()
            {
                Tag = "[ListBox]$m_userRolesCheckedListBox/[CheckBox]Administrator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdministratorCK);

            ProjectAdministratorCK = new CheckBox()
            {
                Tag = "[ListBox]$m_userRolesCheckedListBox/[CheckBox]Project Administrator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectAdministratorCK);

            SecurityAdministratorCK = new CheckBox()
            {
                Tag = "[ListBox]$m_userRolesCheckedListBox/[CheckBox]Security Administrator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SecurityAdministratorCK);

            ItemReviewerCK = new CheckBox()
            {
                Tag = "[ListBox]$m_userRolesCheckedListBox/[CheckBox]Item Reviewer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemReviewerCK);
        }
    }
}
