// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Select Vault Location|$SelectEntityFromVaultDialog", Parent = typeof(MainWin))]
    public partial class SelectVaultLocationDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton Open4PB;
        public  PushButton ClosePB;
        public  PushButton NonReleasedBiasedPB;

        partial void OnInitialize();

        public SelectVaultLocationDLG1()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel3|#2/[Pane]$tableLayoutPanelButtonBar|#2/[PushButton]Cancel|$cancel_button|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Open4PB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel3|#2/[Pane]$tableLayoutPanelButtonBar|#2/[PushButton]Open|$open_button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open4PB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            NonReleasedBiasedPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel3|#2/[Pane]$splitContainer1|#1/[Pane]#2/[Pane]$tableLayoutPanel6|#1/[Pane]$tableLayoutPanel4|#3/[Pane]Revision:|$tableLayoutPanel5|#2/[PushButton]Non-Released Biased|$releaseBiasedToggle_button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NonReleasedBiasedPB);
        }
    }
}
