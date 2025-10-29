// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$MessageForm")]
    public partial class ReportLayoutModifiedSaveChangesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton NoPB;
        public  PushButton YesPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReportLayoutModifiedSaveChangesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            NoPB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$m_buttonsTableLayoutPanel|#2/[PushButton]No|$m_noBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            YesPB = new PushButton()
            {
                Tag = "[Pane]$m_mainTableLayoutPanel|#1/[Pane]$m_buttonsTableLayoutPanel|#2/[PushButton]Yes|$m_yesBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
