// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Branch Table Setup|$BranchTableSetupWindow")]
    public partial class BranchTableSetupDLG : Autodesk.GUIHarness.Window
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton ApplyPB;

        partial void OnInitialize();

        public BranchTableSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OKButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ApplyPB = new PushButton()
            {
                Tag = "[PushButton]Apply|$ApplyButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);
        }
    }
}
