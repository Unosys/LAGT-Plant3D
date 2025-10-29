// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SetJointPropertyRangeDlg", Parent = typeof(ModifyJointDLG))]
    public partial class SetMatchingValuesDLG : Pane
    {
        public  PushButton BtnCancel;
        public  PushButton BtnHelp;
        public  PushButton BtnOK;
        public  Table DataGridView1;
        public  StaticText Label1;
        public  StaticText LblRanges;
        public  PushButton MatchingValuesPB;
        public  Table DataGridViewTBL;

        partial void OnInitialize();

        public SetMatchingValuesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            DataGridView1 = new Table()
            {
                Tag = "[Table]$dataGridView1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridView1);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            LblRanges = new StaticText()
            {
                Tag = "[StaticText]$lblRanges",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblRanges);

            MatchingValuesPB = new PushButton()
            {
                Tag = "[GroupBox]Connection settings|$grpboxConn|/[PushButton]Matching Values*|$btnSetRange1|",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingValuesPB);

            DataGridViewTBL = new Table()
            {
                Tag = "[GroupBox]Connection settings|$grpboxConn|/[Table]DataGridView|$dgProperty|",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);
        }
    }
}
