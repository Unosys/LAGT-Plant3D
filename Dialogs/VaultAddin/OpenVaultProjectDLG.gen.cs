// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open Vault Project", Parent = typeof(MainWin))]
    public partial class OpenVaultProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane OpenVaultProjectPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText OpenAVaultProjectST;
        public  StaticText InitializingThisProjectMayST;
        public  PushButton ShowProjectDetailsPB;
        public  CheckBox AlwaysOpenVaultProjectCK;
        public  PushButton YesPB;
        public  PushButton NoPB;

        partial void OnInitialize();

        public OpenVaultProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenVaultProjectPANE = new Pane()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(OpenVaultProjectPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            OpenAVaultProjectST = new StaticText()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[StaticText]Open a Vault project for the first time|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenAVaultProjectST);

            InitializingThisProjectMayST = new StaticText()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[StaticText]Initializing this project may take some time*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InitializingThisProjectMayST);

            ShowProjectDetailsPB = new PushButton()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[PushButton]Show project details|$ExpandoButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowProjectDetailsPB);

            AlwaysOpenVaultProjectCK = new CheckBox()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[CheckBox]Always open vault project*|$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlwaysOpenVaultProjectCK);

            YesPB = new PushButton()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[PushButton]Yes|$CommandButton_6|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[Pane]Open Vault Project|$Window|#1/[PushButton]No|$CommandButton_7|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);
        }
    }
}
