// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$FormattingRuleSheetEditorForm", Parent = typeof(Pane))]
    public partial class FormattingRulesSheetEditorAddDLG : Pane
    {
        public  PushButton Close2PB;

        partial void OnInitialize();

        public FormattingRulesSheetEditorAddDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Formatting Rule Sheet Editor|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
