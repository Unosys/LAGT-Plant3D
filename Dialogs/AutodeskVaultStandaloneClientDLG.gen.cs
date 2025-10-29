// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Autodesk Vault Stand Alone Client|#1", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class AutodeskVaultStandaloneClientDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane AutodeskVaultStandAlonePANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText AutodeskVaultST;
        public  StaticText DoNotUseAutodeskST;
        public  PushButton LaunchAutodeskVaultPB;
        public  PushButton DoNotLaunchAutodeskPB;
        public  CheckBox AlwaysLaunchAutodeskVaultCK;

        partial void OnInitialize();

        public AutodeskVaultStandaloneClientDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutodeskVaultStandAlonePANE = new Pane()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(AutodeskVaultStandAlonePANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            AutodeskVaultST = new StaticText()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1/[StaticText]Autodesk Vault|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskVaultST);

            DoNotUseAutodeskST = new StaticText()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1/[StaticText]Do not use Autodesk Vault Client to check out or check in files if you can use Project Manager instead*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotUseAutodeskST);

            LaunchAutodeskVaultPB = new PushButton()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1/[PushButton]Launch Autodesk Vault|$CommandLink_1001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LaunchAutodeskVaultPB);

            DoNotLaunchAutodeskPB = new PushButton()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1/[PushButton]Do Not Launch Autodesk Vault|$CommandLink_2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotLaunchAutodeskPB);

            AlwaysLaunchAutodeskVaultCK = new CheckBox()
            {
                Tag = "[Pane]Autodesk Vault Stand Alone Client|$Window|#1/[CheckBox]Always launch Autodesk Vault*|$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlwaysLaunchAutodeskVaultCK);
        }
    }
}
