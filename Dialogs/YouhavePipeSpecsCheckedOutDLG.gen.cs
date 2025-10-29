// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]You Have Pipe Specs Checked Out", Parent = typeof(CustomWin), GUIType = GuiType.WIN32)]
    public partial class YouhavePipeSpecsCheckedOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane YouHavePipeSpecsPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText ThereArePipeSpecsST;
        public  PushButton CheckInAnyPipeSpecsPB;
        public  PushButton LeavePipeSpecsCheckedPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public YouhavePipeSpecsCheckedOutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YouHavePipeSpecsPANE = new Pane()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(YouHavePipeSpecsPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            ThereArePipeSpecsST = new StaticText()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1/[StaticText]There are Pipe Specs that have not been checked-in*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThereArePipeSpecsST);

            CheckInAnyPipeSpecsPB = new PushButton()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1/[PushButton]Check-In any Pipe Specs that I have Checked Out|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInAnyPipeSpecsPB);

            LeavePipeSpecsCheckedPB = new PushButton()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1/[PushButton]Leave Pipe Specs Checked Out|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LeavePipeSpecsCheckedPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]You Have Pipe Specs Checked Out|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
