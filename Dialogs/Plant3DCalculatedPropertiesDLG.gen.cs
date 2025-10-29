// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Plant 3D - Calculated Properties", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class Plant3DCalculatedPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Plant3DCalculatedPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText CalculatedPropertiesAreNowST;
        public  PushButton OpenProjectSetuprecommendedPB;
        public  PushButton UseTheOldPLANTDEFINECALCPROPERTIESPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public Plant3DCalculatedPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Plant3DCalculatedPANE = new Pane()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Plant3DCalculatedPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1/[Pane]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            CalculatedPropertiesAreNowST = new StaticText()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1/[StaticText]Calculated Properties are now available in Project Setup, and the PLANTDEFINECALCPROPERTIES command will be deprecated*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CalculatedPropertiesAreNowST);

            OpenProjectSetuprecommendedPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1/[PushButton]Open Project Setup (recommended)|$CommandLink_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenProjectSetuprecommendedPB);

            UseTheOldPLANTDEFINECALCPROPERTIESPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1/[PushButton]Use the old PLANTDEFINECALCPROPERTIES dialog|$CommandLink_1002|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseTheOldPLANTDEFINECALCPROPERTIESPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D - Calculated Properties|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
