// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Editor - Batch Assign Long Description Styles Completed|$Window_TaskDialog", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecEditorBatchAssignlongDescriptionStylesCompletedDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar SpecEditorBatchCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton Close1PB;
        public  PushButton Close2PB;
        public  StaticText CloseST;
        public  StaticText BatchAssignmentOfLongST;
        public  StaticText StaticTextST;

        partial void OnInitialize();

        public SpecEditorBatchAssignlongDescriptionStylesCompletedDLG1()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SpecEditorBatchCTL = new TitleBar()
            {
                Tag = "[TitleBar]Spec Editor - Batch Assign Long Description Styles Completed|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecEditorBatchCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Spec Editor - Batch Assign Long Description Styles Completed|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Spec Editor - Batch Assign Long Description Styles Completed|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]Spec Editor - Batch Assign Long Description Styles Completed|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            Close2PB = new PushButton()
            {
                Tag = "[PushButton]Close|$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);

            CloseST = new StaticText()
            {
                Tag = "[PushButton]Close|$CloseButton|#1/[StaticText]Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseST);

            BatchAssignmentOfLongST = new StaticText()
            {
                Tag = "[StaticText]Batch assignment of Long Description Styles has successfully completed*|$HeaderTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BatchAssignmentOfLongST);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$MessageTexBlockt|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);
        }
    }
}
