// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmDrawingMigration", Parent = typeof(CustomWin))]
    public partial class PandIDAutoCADPIDMigrationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnBrowse;
        public  PushButton BtnCancel;
        public  PushButton BtnMigrate;
        public  CheckBox ChkboxBackup;
        public  StaticText LblHeader;
        public  StaticText LblHeader2;
        public  StaticText LblMsg01;
        public  StaticText LblMsg02;
        public  StaticText LblMsg03;
        public  Link LinkLabel0;
        public  GroupBox PnlButtons;
        public  GroupBox PnlHeader;
        public  GroupBox PnlInfos;
        public  TextField TxtboxDwgPath;
        public  Link WhatIsUpdatedDuringMigration;
        public  Link WhatOccursDuringDrawingMigration;
        public  Link WhyDidTheMigrationFail;

        partial void OnInitialize();

        public PandIDAutoCADPIDMigrationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnBrowse = new PushButton()
            {
                Tag = "[PushButton]$btnBrowse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnBrowse);

            BtnCancel = new PushButton()
            {
                Tag = "[Pane]Please verify that this drawing is not in use before proceeding with migration process[2]|$pnlButtons|#3/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnMigrate = new PushButton()
            {
                Tag = "[PushButton]$btnMigrate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnMigrate);

            ChkboxBackup = new CheckBox()
            {
                Tag = "[CheckBox]$chkboxBackup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChkboxBackup);

            LblHeader = new StaticText()
            {
                Tag = "[StaticText]$frmMigrationInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblHeader);

            LblHeader2 = new StaticText()
            {
                Tag = "[StaticText]$pnlHeader",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblHeader2);

            LblMsg01 = new StaticText()
            {
                Tag = "[StaticText]$lblMsg01",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblMsg01);

            LblMsg02 = new StaticText()
            {
                Tag = "[StaticText]$lblMsg02",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblMsg02);

            LblMsg03 = new StaticText()
            {
                Tag = "[StaticText]$lblMsg03",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblMsg03);

            LinkLabel0 = new Link()
            {
                Tag = "[Link]$linkLabel0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinkLabel0);

            PnlButtons = new GroupBox()
            {
                Tag = "[Group]$pnlButtons",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlButtons);

            PnlHeader = new GroupBox()
            {
                Tag = "[Group]$pnlHeader",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlHeader);

            PnlInfos = new GroupBox()
            {
                Tag = "[Group]$pnlInfos",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlInfos);

            TxtboxDwgPath = new TextField()
            {
                Tag = "[TextField]$txtboxDwgPath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TxtboxDwgPath);

            WhatIsUpdatedDuringMigration = new Link()
            {
                Tag = "[Link]$frmMigrationInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatIsUpdatedDuringMigration);

            WhatOccursDuringDrawingMigration = new Link()
            {
                Tag = "[Link]$frmMigrationInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatOccursDuringDrawingMigration);

            WhyDidTheMigrationFail = new Link()
            {
                Tag = "[Link]$frmMigrationInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhyDidTheMigrationFail);
        }
    }
}
