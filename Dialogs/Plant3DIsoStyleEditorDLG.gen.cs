// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Plant 3D Iso Style Editor|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class Plant3DIsoStyleEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Plant3DIsoStylePANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText YouHaveChangesThatST;
        public  StaticText UnsavedIsoSettingChangesST;
        public  PushButton SaveChangesInProjectPB;
        public  PushButton DoNotOpenThePB;

        partial void OnInitialize();

        public Plant3DIsoStyleEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Plant3DIsoStylePANE = new Pane()
            {
                Tag = "[Pane]Plant 3D Iso Style Editor|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Plant3DIsoStylePANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D Iso Style Editor|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Plant 3D Iso Style Editor|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Plant 3D Iso Style Editor|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            YouHaveChangesThatST = new StaticText()
            {
                Tag = "[Pane]Plant 3D Iso Style Editor|$Window|#1/[StaticText]You have changes that must be saved before opening the Iso Style XML Editor*|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouHaveChangesThatST);

            UnsavedIsoSettingChangesST = new StaticText()
            {
                Tag = "[Pane]Plant 3D Iso Style Editor|$Window|#1/[StaticText]Unsaved Iso setting changes made in Project Setup will be discarded if you make and save*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnsavedIsoSettingChangesST);

            SaveChangesInProjectPB = new PushButton()
            {
                Tag = "[Pane]Plant 3D Iso Style Editor|$Window|#1/[PushButton]Save Changes in Project Setup (Recommended)|$CommandLink_0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveChangesInProjectPB);

            DoNotOpenThePB = new PushButton()
            {
                Tag = "[Pane]Plant 3D Iso Style Editor|$Window|#1/[PushButton]Do Not Open the Iso Style XML Editor |$CommandLink_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotOpenThePB);
        }
    }
}
