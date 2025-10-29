// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Ortho Creation in Process|#1", Parent = typeof(MainWin))]
    public partial class OrthoCreationinProcessDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane OrthoCreationInProcessPANE;
        public  Pane PanePANE;
        public  Image MainInstructionIconIMG;
        public  StaticText YouHaveAnOrthocubeST;
        public  StaticText YouMustCompleteOrST;
        public  PushButton OKPB;

        partial void OnInitialize();

        public OrthoCreationinProcessDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OrthoCreationInProcessPANE = new Pane()
            {
                Tag = "[Pane]Ortho Creation in Process|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(OrthoCreationInProcessPANE);

            PanePANE = new Pane()
            {
                Tag = "[Pane]Ortho Creation in Process|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Ortho Creation in Process|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            YouHaveAnOrthocubeST = new StaticText()
            {
                Tag = "[Pane]Ortho Creation in Process|$Window|#1/[StaticText]You Have an Orthocube Drawing Open|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouHaveAnOrthocubeST);

            YouMustCompleteOrST = new StaticText()
            {
                Tag = "[Pane]Ortho Creation in Process|$Window|#1/[StaticText]You must complete or cancel the Ortho creation process before switching to another drawing*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouMustCompleteOrST);

            OKPB = new PushButton()
            {
                Tag = "[Pane]Ortho Creation in Process|$Window|#1/[PushButton]OK|$CommandButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
