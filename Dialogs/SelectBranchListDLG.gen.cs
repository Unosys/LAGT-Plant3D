// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Select Branch List|$MultiBranchSelWindow")]
    public partial class SelectBranchListDLG : Window
    {
        public  PushButton CancelPB;
        public  CheckBox UseBranchRow3CK;
        public  CheckBox UseBranchRow4CK;
        public  CheckBox UseBranchRow5CK;
        public  PushButton OKPB;

        partial void OnInitialize();

        public SelectBranchListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            UseBranchRow3CK = new CheckBox()
            {
                Tag = "[Pane]$wfi:WindowsFormsHost_1|#1/[ListView]#1/[CustomWin]#5/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseBranchRow3CK);

            UseBranchRow4CK = new CheckBox()
            {
                Tag = "[Pane]$wfi:WindowsFormsHost_1|#1/[ListView]#1/[CustomWin]#6/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseBranchRow4CK);

            UseBranchRow5CK = new CheckBox()
            {
                Tag = "[Pane]$wfi:WindowsFormsHost_1|#1/[ListView]#1/[CustomWin]#7/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseBranchRow5CK);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
