// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$AddModifySimpleJointDlg")]
    public partial class ModifyJointDLG : Pane
    {
        public  ListBoxItem LFL1LBI;
        public  ListBoxItem BoltSet;
        public  PushButton MatchingValuesPB;
        public  PushButton BtnCancel;
        public  ListView ListViewLV;
        public  PushButton SpecFilterPB;

        partial void OnInitialize();

        public ModifyJointDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LFL1LBI = new ListBoxItem()
            {
                Tag = "[GroupBox]Connection settings|$grpboxConn|#1/[Pane]Learn more about Imperial to Metric Connections|$splitContainer1|#1/[Pane]$462214|#1/[ListBox]End 1:|$clstboxEnd1|#1/[ListBoxItem]LFL|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LFL1LBI);

            BoltSet = new ListBoxItem()
            {
                Tag = "[GroupBox]Fasteners|$grpboxPropMatches|#2/[ListBox]$clstboxFasteners|#1/[ListBoxItem]Bolt Set|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltSet);

            MatchingValuesPB = new PushButton()
            {
                Tag = "[GroupBox]Connection settings|$grpboxConn|/[PushButton]Matching Values*|$btnSetRange1|",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingValuesPB);

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            ListViewLV = new ListView()
            {
                Tag = "[GroupBox]$grpboxConn|#1/[ListView]$dgProperty|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            SpecFilterPB = new PushButton()
            {
                Tag = "[GroupBox]Fasteners|$grpboxPropMatches|#2/[PushButton]Spec Filter*|$btnFastenerFilter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecFilterPB);
        }
    }
}
