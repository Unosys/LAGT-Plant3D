// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Delete annotation", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class DeleteAnnotationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton DeleteTheAnnotationPB;
        public  PushButton DoNotDeleteThePB;
        public  PushButton CancelPB;
        public  TitleBar DeleteAnnotationCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DeleteAnnotationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DeleteTheAnnotationPB = new PushButton()
            {
                Tag = "[Pane]Delete annotation|$Window|#1/[PushButton]Delete the annotation|$CommandLink_0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteTheAnnotationPB);

            DoNotDeleteThePB = new PushButton()
            {
                Tag = "[Pane]Delete annotation|$Window|#1/[PushButton]Do not delete the annotation|$CommandLink_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotDeleteThePB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Delete annotation|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            DeleteAnnotationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Delete annotation|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteAnnotationCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Delete annotation|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
