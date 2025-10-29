// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmProjectMigration1|[Pane]$frmProjectMigration3|[Pane]$frmProjectMigration4", Parent = typeof(Plant3D))]
    public partial class PandIDAutoCADPIDMigration2009DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText ClickNextToCheckST;
        public  StaticText PleaseVerifyThatAllST;
        public  Pane PleaseVerifyThatAll1PANE;
        public  Pane PleaseVerifyThatAll2PANE;
        public  Link HowDoIVerifyLINK;
        public  StaticText InformationST;
        public  Link WhatOccursDuringProjectLINK;
        public  Link WhatOccursDuringDrawingLINK;
        public  Link WhatIsUpdatedDuringLINK;
        public  Link WhyDidTheMigrationLINK;
        public  Pane PleaseVerifyThatAll3PANE;
        public  PushButton NextPB;
        public  PushButton CancelPB;
        public  Pane PleaseVerifyThatAll4PANE;
        public  StaticText ThisProjectWasCreatedST;
        public  TitleBar AutoCADPIDMigrationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  CheckBox BackupTheseFilesBeforeCK;
        public  TextField TextFieldTF;
        public  PushButton MigratePB;

        partial void OnInitialize();

        public PandIDAutoCADPIDMigration2009DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClickNextToCheckST = new StaticText()
            {
                Tag = "[StaticText]$lblMsg02|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClickNextToCheckST);

            PleaseVerifyThatAllST = new StaticText()
            {
                Tag = "[StaticText]$lblMsg01|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatAllST);

            PleaseVerifyThatAll1PANE = new Pane()
            {
                Tag = "[Pane]$pnlInfos|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatAll1PANE);

            PleaseVerifyThatAll2PANE = new Pane()
            {
                Tag = "[Pane]$pnlInfos|#2/[Pane]$frmMigrationInfo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatAll2PANE);

            HowDoIVerifyLINK = new Link()
            {
                Tag = "[Pane]$pnlInfos|#2/[Pane]$frmMigrationInfo|#1/[Link]$linkLabel0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HowDoIVerifyLINK);

            InformationST = new StaticText()
            {
                Tag = "[Pane]$pnlInfos|#2/[Pane]$frmMigrationInfo|#1/[StaticText]$lblHeader|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InformationST);

            WhatOccursDuringProjectLINK = new Link()
            {
                Tag = "[Pane]$pnlInfos|#2/[Pane]$frmMigrationInfo|#1/[Link]$linkLabel1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatOccursDuringProjectLINK);

            WhatOccursDuringDrawingLINK = new Link()
            {
                Tag = "[Pane]$pnlInfos|#2/[Pane]$frmMigrationInfo|#1/[Link]$linkLabel1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatOccursDuringDrawingLINK);

            WhatIsUpdatedDuringLINK = new Link()
            {
                Tag = "[Pane]$pnlInfos|#2/[Pane]$frmMigrationInfo|#1/[Link]$linkLabel1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatIsUpdatedDuringLINK);

            WhyDidTheMigrationLINK = new Link()
            {
                Tag = "[Pane]$pnlInfos|#2/[Pane]$frmMigrationInfo|#1/[Link]$linkLabel1|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhyDidTheMigrationLINK);

            PleaseVerifyThatAll3PANE = new Pane()
            {
                Tag = "[Pane]$pnlButtons|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatAll3PANE);

            NextPB = new PushButton()
            {
                Tag = "[Pane]$pnlButtons/[PushButton]$btnNext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NextPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$pnlButtons/[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PleaseVerifyThatAll4PANE = new Pane()
            {
                Tag = "[Pane]$pnlHeader|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseVerifyThatAll4PANE);

            ThisProjectWasCreatedST = new StaticText()
            {
                Tag = "[Pane]$pnlHeader|#1/[StaticText]$lblHeader|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisProjectWasCreatedST);

            AutoCADPIDMigrationCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoCADPIDMigrationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]$frmProjectMigration1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]$frmProjectMigration1|#1/[MenuItem]$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            BackupTheseFilesBeforeCK = new CheckBox()
            {
                Tag = "[CheckBox]Backup these files before migration (recommended)|$chkboxBackup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackupTheseFilesBeforeCK);

            TextFieldTF = new TextField()
            {
                Tag = "[TextField]$txtboxFolder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextFieldTF);

            MigratePB = new PushButton()
            {
                Tag = "[Pane]$pnlButtons/[PushButton]$btnMigrate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigratePB);
        }
    }
}
