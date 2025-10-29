// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Warning", Parent = typeof(P3DCreateEquipmentDLG), GUIType = GuiType.UIA)]
    public partial class EquipmentWarningDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane WarningPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText RemovingThisShapeWillST;
        public  PushButton RemoveShapeAndTrimPB;
        public  PushButton DoNotRemovePB;
        public  TitleBar WarningCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public EquipmentWarningDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            WarningPANE = new Pane()
            {
                Tag = "[Pane]Warning|$Window",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WarningPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Warning|$Window/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Warning|$Window/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Warning|$Window/[Image]MainInstructionIcon|$MainIcon",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            RemovingThisShapeWillST = new StaticText()
            {
                Tag = "[Pane]Warning|$Window/[StaticText]Removing this shape will also remove the connected trim*|$MainInstruction",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovingThisShapeWillST);

            RemoveShapeAndTrimPB = new PushButton()
            {
                Tag = "[Pane]Warning|$Window/[PushButton]Remove Shape and Trim*|$CommandLink_1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveShapeAndTrimPB);

            DoNotRemovePB = new PushButton()
            {
                Tag = "[Pane]Warning|$Window/[PushButton]Do Not Remove*|$CommandLink_1002",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotRemovePB);

            WarningCTL = new TitleBar()
            {
                Tag = "[TitleBar]Warning|$TitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WarningCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Warning|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
