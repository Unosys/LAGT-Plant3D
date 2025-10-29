// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Undo Check Out - Plant 3D Drawings|$Window_1")]
    public partial class UndoCheckOutProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton UndoCheckOutPB;

        partial void OnInitialize();

        public UndoCheckOutProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Button_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            UndoCheckOutPB = new PushButton()
            {
                Tag = "[PushButton]Undo Check Out|$Button_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UndoCheckOutPB);
        }
    }
}
