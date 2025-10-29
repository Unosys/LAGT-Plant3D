// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Login Required", Parent = typeof(MainWin))]
    public partial class LoginRequiredDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane LoginRequiredPANE;
        public  Pane PanePANE;
        public  Image MainInstructionIconIMG;
        public  StaticText ThisActionCannotBeST;
        public  StaticText InOrderToCarryST;
        public  PushButton OK;

        partial void OnInitialize();

        public LoginRequiredDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LoginRequiredPANE = new Pane()
            {
                Tag = "[Pane]Login Required|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(LoginRequiredPANE);

            PanePANE = new Pane()
            {
                Tag = "[Pane]Login Required|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Login Required|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            ThisActionCannotBeST = new StaticText()
            {
                Tag = "[Pane]Login Required|$Window|#1/[StaticText]This action cannot be completed|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisActionCannotBeST);

            InOrderToCarryST = new StaticText()
            {
                Tag = "[Pane]Login Required|$Window|#1/[StaticText]In order to carry out project-specific actions, you must be logged into Vault*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InOrderToCarryST);

            OK = new PushButton()
            {
                Tag = "[Pane]Login Required|$Window|#1/[PushButton]OK|$CommandButton_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
