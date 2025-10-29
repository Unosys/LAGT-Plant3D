// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Undo Check Out", Parent = typeof(CustomWin), GUIType = GuiType.WIN32)]
    public partial class UndoCheckOut : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton UndoCheckoutChangesWillPB;
        public  PushButton DoNotUndoCheckoutPB;

        partial void OnInitialize();

        public UndoCheckOut()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            UndoCheckoutChangesWillPB = new PushButton()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[PushButton]Undo Checkout (Changes will be lost)|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UndoCheckoutChangesWillPB);

            DoNotUndoCheckoutPB = new PushButton()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[PushButton]Do Not Undo Checkout|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotUndoCheckoutPB);
        }
    }
}
