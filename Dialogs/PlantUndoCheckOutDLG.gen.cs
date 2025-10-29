// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Undo Check Out", Parent = typeof(CustomWin), GUIType = GuiType.WIN32)]
    public partial class PlantUndoCheckOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane UndoCheckOutPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText ThisDrawingHasChangesST;
        public  PushButton UndoCheckoutAndClosePB;
        public  PushButton UndoCheckoutAndReOpenPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public PlantUndoCheckOutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            UndoCheckOutPANE = new Pane()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(UndoCheckOutPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            ThisDrawingHasChangesST = new StaticText()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[StaticText]This drawing has changes that have not been checked-in*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisDrawingHasChangesST);

            UndoCheckoutAndClosePB = new PushButton()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[PushButton]Undo Checkout and Close Drawing Without Saving|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UndoCheckoutAndClosePB);

            UndoCheckoutAndReOpenPB = new PushButton()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[PushButton]Undo Checkout and Re-Open Drawing from Project|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UndoCheckoutAndReOpenPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Undo Check Out|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
