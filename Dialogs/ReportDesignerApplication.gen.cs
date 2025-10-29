// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$XRDesignFormExBase")]
    public partial class ReportDesignerApplication : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReportDesignerApplication()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
