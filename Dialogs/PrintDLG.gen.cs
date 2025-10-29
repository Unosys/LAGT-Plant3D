// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Print|$PrintEditorForm|#3", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class PrintDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton PrintPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PrintDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Cancel|$btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PrintPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Print|$btnPrint|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrintPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Print|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
