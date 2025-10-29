// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]P*ID|#1", Parent = typeof(SizeMappingDLG), GUIType = GuiType.UIA)]
    public partial class PIDInteroperabilityDeleteRowDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane PIDInteroperabilityDeletePANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText AreYouSureYouST;
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  TitleBar PIDInteroperabilityDeleteCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PIDInteroperabilityDeleteRowDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PIDInteroperabilityDeletePANE = new Pane()
            {
                Tag = "[Pane]P*|$Window|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDInteroperabilityDeletePANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]P*|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]P*|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]P*|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            AreYouSureYouST = new StaticText()
            {
                Tag = "[Pane]P*|$Window|#1/[StaticText]Are you sure you want to remove the size mapping of P*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AreYouSureYouST);

            YesPB = new PushButton()
            {
                Tag = "[Pane]P*|$Window|#1/[PushButton]Yes|$CommandButton_6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[Pane]P*|$Window|#1/[PushButton]No|$CommandButton_7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            PIDInteroperabilityDeleteCTL = new TitleBar()
            {
                Tag = "[TitleBar]P*|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDInteroperabilityDeleteCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]P*|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
