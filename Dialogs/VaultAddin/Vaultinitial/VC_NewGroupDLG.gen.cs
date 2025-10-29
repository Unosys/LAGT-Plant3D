// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$GroupProfileForm", Parent = typeof(VC_UserAndGroupManagementDLG))]
    public partial class VC_NewGroupDLG : Pane
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton AddPB;
        public  TextField EmailAliasTF;
        public  TextField GroupNameTF;
        public  PushButton LinkedToPB;
        public  PushButton GroupManagersPB;

        partial void OnInitialize();

        public VC_NewGroupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_groupProfileTableLayoutPanel/[Pane]$panel5/[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_groupProfileTableLayoutPanel/[Pane]$panel5/[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$m_groupProfileTableLayoutPanel/[Pane]$panel4/[Pane]$groupBox1/[PushButton]$m_addButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            EmailAliasTF = new TextField()
            {
                Tag = "[Pane]$m_groupProfileTableLayoutPanel/[Pane]$panel2/[TextField]$m_emailDLTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EmailAliasTF);

            GroupNameTF = new TextField()
            {
                Tag = "[Pane]$m_groupProfileTableLayoutPanel/[Pane]$panel2/[TextField]$m_groupNameTextBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupNameTF);

            LinkedToPB = new PushButton()
            {
                Tag = "[Pane]$m_groupProfileTableLayoutPanel/[Pane]$panel3/[PushButton]$m_authByButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinkedToPB);

            GroupManagersPB = new PushButton()
            {
                Tag = "[Pane]$m_groupProfileTableLayoutPanel/[Pane]$panel3/[PushButton]$m_groupManagerButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupManagersPB);
        }
    }
}
