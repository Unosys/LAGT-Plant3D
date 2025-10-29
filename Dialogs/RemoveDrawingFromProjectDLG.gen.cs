// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Remove Drawing From Project", Parent = typeof(ProjManUndocked))]
    public partial class RemoveDrawingFromProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane RemoveDrawingFromProjectPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText TheSelectedDrawingAndST;
        public  PushButton RemoveTheDrawingFromPB;
        public  PushButton DoNotRemoveThePB;

        partial void OnInitialize();

        public RemoveDrawingFromProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            RemoveDrawingFromProjectPANE = new Pane()
            {
                Tag = "[Pane]Remove Drawing From Project|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(RemoveDrawingFromProjectPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Remove Drawing From Project|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Remove Drawing From Project|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Remove Drawing From Project|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            TheSelectedDrawingAndST = new StaticText()
            {
                Tag = "[Pane]Remove Drawing From Project|$Window|#1/[StaticText]The selected drawing and its information will no longer be available in this project*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheSelectedDrawingAndST);

            RemoveTheDrawingFromPB = new PushButton()
            {
                Tag = "[Pane]Remove Drawing From Project|$Window|#1/[PushButton]Remove the Drawing from the Project |$CommandLink_0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveTheDrawingFromPB);

            DoNotRemoveThePB = new PushButton()
            {
                Tag = "[Pane]Remove Drawing From Project|$Window|#1/[PushButton]Do Not Remove the Drawing from the Project|$CommandLink_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotRemoveThePB);
        }
    }
}
