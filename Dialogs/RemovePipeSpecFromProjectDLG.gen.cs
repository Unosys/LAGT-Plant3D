// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Remove Pipe Spec From Project|#1", Parent = typeof(ProjManUndocked), GUIType = GuiType.WIN32)]
    public partial class RemovePipeSpecFromProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane RemovePipeSpecFromPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText TheSelectedPipeSpecST;
        public  PushButton RemoveThePipeSpecPB;
        public  PushButton DoNotRemoveThePB;

        partial void OnInitialize();

        public RemovePipeSpecFromProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RemovePipeSpecFromPANE = new Pane()
            {
                Tag = "[Pane]Remove Pipe Spec From Project|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(RemovePipeSpecFromPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Remove Pipe Spec From Project|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Remove Pipe Spec From Project|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Remove Pipe Spec From Project|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            TheSelectedPipeSpecST = new StaticText()
            {
                Tag = "[Pane]Remove Pipe Spec From Project|$Window|#1/[StaticText]The selected pipe spec and its information will no longer be available in this project*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheSelectedPipeSpecST);

            RemoveThePipeSpecPB = new PushButton()
            {
                Tag = "[Pane]Remove Pipe Spec From Project|$Window|#1/[PushButton]Remove the Pipe Spec from the Project |$CommandLink_0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveThePipeSpecPB);

            DoNotRemoveThePB = new PushButton()
            {
                Tag = "[Pane]Remove Pipe Spec From Project|$Window|#1/[PushButton]Do Not Remove the Pipe Spec from the Project|$CommandLink_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotRemoveThePB);
        }
    }
}
