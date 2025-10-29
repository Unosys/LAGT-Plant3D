// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Synchronize to Vault", Parent = typeof(CustomWin))]
    public partial class SynchronizeProjectToServerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane SynchronizeToVaultPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Image MainInstructionIconIMG;
        public  StaticText SaveAndCheckInST;
        public  StaticText AllCheckedoutFilesWillST;
        public  PushButton ShowDetailsPB;
        public  CheckBox AlwaysSaveAndCheckCK;
        public  PushButton SaveAndCheckInPB;
        public  PushButton Cancel;

        partial void OnInitialize();

        public SynchronizeProjectToServerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SynchronizeToVaultPANE = new Pane()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(SynchronizeToVaultPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[Pane]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MainInstructionIconIMG = new Image()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[Image]MainInstructionIcon|$MainIcon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MainInstructionIconIMG);

            SaveAndCheckInST = new StaticText()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[StaticText]Save and Check In All|$MainInstruction|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAndCheckInST);

            AllCheckedoutFilesWillST = new StaticText()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[StaticText]All checked-out files will be saved and upload to the vault*|$ContentText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AllCheckedoutFilesWillST);

            ShowDetailsPB = new PushButton()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[PushButton]Show details|$ExpandoButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsPB);

            AlwaysSaveAndCheckCK = new CheckBox()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[CheckBox]Always save and check in all*|$VerificationCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AlwaysSaveAndCheckCK);

            SaveAndCheckInPB = new PushButton()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[PushButton]Save and Check In|$CommandButton_1001|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAndCheckInPB);

            Cancel = new PushButton()
            {
                Tag = "[Pane]Synchronize to Vault|$Window|#1/[PushButton]Cancel|$CommandButton_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
