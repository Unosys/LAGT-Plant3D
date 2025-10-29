// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]User Conflict", Parent = typeof(Plant3D))]
    public partial class UserConflictDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane UserConflictPANE;
        public  Pane PanePANE;
        public  Image MainInstructionIconIMG;
        public  StaticText CannotOpenThisVaultST;
        public  StaticText YouCannotOpenAST;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public UserConflictDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            UserConflictPANE = new Pane()
            {
                Tag = "[Pane]User Conflict|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(UserConflictPANE);

            PanePANE = new Pane()
            {
                Tag = "[Pane]User Conflict|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]User Conflict|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            CannotOpenThisVaultST = new StaticText()
            {
                Tag = "[Pane]User Conflict|$Window|#1/[StaticText]Cannot open this Vault project|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CannotOpenThisVaultST);

            YouCannotOpenAST = new StaticText()
            {
                Tag = "[Pane]User Conflict|$Window|#1/[StaticText]You cannot open a project from Administrator's workspace*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouCannotOpenAST);

            ClosePB = new PushButton()
            {
                Tag = "[Pane]User Conflict|$Window|#1/[PushButton]Close|$CommandButton_8|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
