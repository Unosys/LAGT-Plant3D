// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Validate Project|#1", Parent = typeof(PROJECTMANAGERDLG), GUIType = GuiType.WIN32)]
    public partial class ValidateProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane ValidateProjectPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText ProjectValidationOnCurrentST;
        public  StaticText ToEnsureThatYouST;
        public  PushButton Yes;
        public  PushButton Cancel;

        partial void OnInitialize();

        public ValidateProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ValidateProjectPANE = new Pane()
            {
                Tag = "[Pane]Validate Project|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(ValidateProjectPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Validate Project|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Validate Project|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Validate Project|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            ProjectValidationOnCurrentST = new StaticText()
            {
                Tag = "[Pane]Validate Project|$Window|#1/[StaticText]Project validation on current data|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectValidationOnCurrentST);

            ToEnsureThatYouST = new StaticText()
            {
                Tag = "[Pane]Validate Project|$Window|#1/[StaticText]To ensure that you get current validation results, sychronize the project before starting*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToEnsureThatYouST);

            Yes = new PushButton()
            {
                Tag = "[Pane]Validate Project|$Window|#1/[PushButton]Yes|$CommandButton_6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            Cancel = new PushButton()
            {
                Tag = "[Pane]Validate Project|$Window|#1/[PushButton]Cancel|$CommandButton_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
