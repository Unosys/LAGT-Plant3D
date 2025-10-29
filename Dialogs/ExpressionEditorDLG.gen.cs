// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Expression Editor|$ReportExpressionCollectionEditorForm", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class ExpressionEditorDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public ExpressionEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#1/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]tablePanel1|$tablePanel1|#1/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
