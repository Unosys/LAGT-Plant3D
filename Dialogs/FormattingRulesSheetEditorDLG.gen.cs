// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Formatting Rule Sheet Editor|$FormattingRuleSheetEditorForm", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class FormattingRulesSheetEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Close2PB;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  PushButton PushButton3PB;
        public  PushButton PushButton4PB;
        public  PushButton AddPB;

        partial void OnInitialize();

        public FormattingRulesSheetEditorDLG()
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

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$btPurge|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$btClear|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$btRemove|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            PushButton4PB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$btClone|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$layoutControl1|#1/[PushButton]$btAdd|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);
        }
    }
}
