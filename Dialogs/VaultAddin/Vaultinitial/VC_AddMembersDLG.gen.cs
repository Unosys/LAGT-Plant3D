// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AddUsersForm", Parent = typeof(VC_NewGroupDLG))]
    public partial class VC_AddMembersDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  RadioButton MembersRB;
        public  RadioButton ProfileAttributesRB;
        public  PushButton AddPB_Members;
        public  PushButton RemovePB_Members;
        public  Table AvailableMembersPANE;
        public  PushButton AddPB_ProfileAttributes;
        public  PushButton ReplacePB_ProfileAttributes;
        public  PushButton RemovePB_ProfileAttributes;
        public  ListBox SelectMembersThatMatchLB;
        public  PopupList PropertyPL;
        public  PopupList ConditionPL;
        public  TextField TextFieldTF;

        partial void OnInitialize();

        public VC_AddMembersDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$panel4/[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$panel4/[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            MembersRB = new RadioButton()
            {
                Tag = "[Pane]$tableLayoutPanel5/[RadioButton]$memberRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MembersRB);

            ProfileAttributesRB = new RadioButton()
            {
                Tag = "[Pane]$tableLayoutPanel5/[RadioButton]$profAttrRadioBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProfileAttributesRB);

            AddPB_Members = new PushButton()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$memberPage/[Pane]$tableLayoutPanel1/[Pane]$panel3/[PushButton]$m_addButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB_Members);

            RemovePB_Members = new PushButton()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$memberPage/[Pane]$tableLayoutPanel1/[Pane]$panel3/[PushButton]$m_removeButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB_Members);

            AvailableMembersPANE = new Table()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$memberPage/[Pane]$tableLayoutPanel1/[Pane]$panel2/[Pane]$tableLayoutPanel2/[Table]$m_availableUsersGridControl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AvailableMembersPANE);

            AddPB_ProfileAttributes = new PushButton()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$profAttrPage/[Pane]$advancedConditionBuilder1/[Pane]$m_conditionPanel/[Pane]$tableLayoutPanel1/[PushButton]$m_addButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB_ProfileAttributes);

            ReplacePB_ProfileAttributes = new PushButton()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$profAttrPage/[Pane]$advancedConditionBuilder1/[Pane]$m_conditionPanel/[Pane]$tableLayoutPanel1/[PushButton]$m_replaceButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReplacePB_ProfileAttributes);

            RemovePB_ProfileAttributes = new PushButton()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$profAttrPage/[Pane]$advancedConditionBuilder1/[Pane]$m_conditionPanel/[Pane]$tableLayoutPanel1/[PushButton]$m_removeButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB_ProfileAttributes);

            SelectMembersThatMatchLB = new ListBox()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$profAttrPage/[Pane]$advancedConditionBuilder1/[Pane]$m_conditionPanel/[ListBox]$m_criteriaListBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectMembersThatMatchLB);

            PropertyPL = new PopupList()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$profAttrPage/[Pane]$advancedConditionBuilder1/[Pane]$m_conditionPanel/[Pane]$m_condTableLayoutPanel/[PopupList]$m_propertyComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyPL);

            ConditionPL = new PopupList()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$profAttrPage/[Pane]$advancedConditionBuilder1/[Pane]$m_conditionPanel/[Pane]$m_condTableLayoutPanel/[PopupList]$m_conditionComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConditionPL);

            TextFieldTF = new TextField()
            {
                Tag = "[PageList]$xtraTabControl1/[Pane]$profAttrPage/[Pane]$advancedConditionBuilder1/[Pane]$m_conditionPanel/[Pane]$m_condTableLayoutPanel/[Pane]#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);
        }
    }
}
