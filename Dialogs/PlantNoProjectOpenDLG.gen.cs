// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]No Project Open", Parent = typeof(Plant3D))]
    public partial class PlantNoProjectOpenDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane NoProjectOpenPANE;
        public  Pane PanePANE;
        public  Image MainInstructionIconIMG;
        public  StaticText CannotCreateReportBecauseST;
        public  StaticText YouMustHaveAST;
        public  PushButton OKPB;

        partial void OnInitialize();

        public PlantNoProjectOpenDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            NoProjectOpenPANE = new Pane()
            {
                Tag = "[Pane]No Project Open|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(NoProjectOpenPANE);

            PanePANE = new Pane()
            {
                Tag = "[Pane]No Project Open|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]No Project Open|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            CannotCreateReportBecauseST = new StaticText()
            {
                Tag = "[Pane]No Project Open|$Window|#1/[StaticText]Cannot create report because no project is open*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CannotCreateReportBecauseST);

            YouMustHaveAST = new StaticText()
            {
                Tag = "[Pane]No Project Open|$Window|#1/[StaticText]You must have a project open to create a report*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouMustHaveAST);

            OKPB = new PushButton()
            {
                Tag = "[Pane]No Project Open|$Window|#1/[PushButton]OK|$CommandButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
