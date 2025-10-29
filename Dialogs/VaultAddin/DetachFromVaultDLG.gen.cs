// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Detach from Vault|#1", Parent = typeof(PROJECTMANAGERDLG), GUIType = GuiType.WIN32)]
    public partial class DetachFromVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane DetachFromVaultPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText DetachProjectFromTheST;
        public  StaticText TheProjectInTheST;
        public  CheckBox AlwaysDetachFromTheCK;
        public  PushButton DetachPB;
        public  PushButton Cancel;

        partial void OnInitialize();

        public DetachFromVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DetachFromVaultPANE = new Pane()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(DetachFromVaultPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            DetachProjectFromTheST = new StaticText()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1/[StaticText]Detach Project from the Vault|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetachProjectFromTheST);

            TheProjectInTheST = new StaticText()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1/[StaticText]The project in the local workspace will be converted to a non-vault project*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheProjectInTheST);

            AlwaysDetachFromTheCK = new CheckBox()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1/[CheckBox]Always detach from the vault*|$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlwaysDetachFromTheCK);

            DetachPB = new PushButton()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1/[PushButton]Detach|$CommandButton_1001|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DetachPB);

            Cancel = new PushButton()
            {
                Tag = "[Pane]Detach from Vault|$Window|#1/[PushButton]Cancel|$CommandButton_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
