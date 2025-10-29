// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Delete P*|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class DeletePIDPainterStyleDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  StaticText AreYouSureYouST;
        public  TitleBar DeletePIDPainterStyleCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DeletePIDPainterStyleDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YesPB = new PushButton()
            {
                Tag = "[PushButton]Yes|$6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[PushButton]No|$7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            AreYouSureYouST = new StaticText()
            {
                Tag = "[StaticText]Are you sure you want to delete \"Color by Service\" ?|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AreYouSureYouST);

            DeletePIDPainterStyleCTL = new TitleBar()
            {
                Tag = "[TitleBar]Delete P*|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePIDPainterStyleCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Delete P*|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
