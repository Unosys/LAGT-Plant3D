// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Close Project Drawings", Parent = typeof(CustomWin))]
    public partial class PandIDCloseProjectDrawingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane CloseProjectDrawingsPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText OneOrMoreDrawingsST;
        public  PushButton OKPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public PandIDCloseProjectDrawingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CloseProjectDrawingsPANE = new Pane()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(CloseProjectDrawingsPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            OneOrMoreDrawingsST = new StaticText()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1/[StaticText]One or more drawings of the current project are still open*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreDrawingsST);

            OKPB = new PushButton()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1/[PushButton]OK|$CommandButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Close Project Drawings|$Window|#1/[PushButton]Cancel|$CommandButton_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
