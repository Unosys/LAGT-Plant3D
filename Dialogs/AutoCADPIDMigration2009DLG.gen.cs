// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$frmProjectMigration", Parent = typeof(Plant3D))]
    public partial class AutoCADPIDMigration2009DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Exit;
        public  PushButton BtnCancel;
        public  PushButton BtnNext;
        public  CustomWin FrmMigrationInfo;
        public  StaticText LblHeader;
        public  StaticText LblHeader2;
        public  StaticText LblMsg01;
        public  StaticText LblMsg02;
        public  Link LinkLabel0;
        public  GroupBox PnlButtons;
        public  GroupBox PnlHeader;
        public  GroupBox PnlInfos;
        public  TextField TxtboxDwgPath;
        public  TextField TxtboxFolder;
        public  Link WhatIsUpdatedDuringMigration;
        public  Link WhatOccursDuringDrawingMigration;
        public  Link WhatOccursDuringProjectMigration;
        public  Link WhyDidTheMigrationFail;

        partial void OnInitialize();

        public AutoCADPIDMigration2009DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Exit = new PushButton()
            {
                Tag = "[PushButton]$btnExit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Exit);

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnNext = new PushButton()
            {
                Tag = "[PushButton]$btnNext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnNext);

            FrmMigrationInfo = new CustomWin()
            {
                Tag = "[CustomWin]$frmMigrationInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FrmMigrationInfo);

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

            LinkLabel0 = new Link()
            {
                Tag = "[Link]$linkLabel0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinkLabel0);

            PnlButtons = new GroupBox()
            {
                Tag = "[GroupBox]$pnlButtons",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlButtons);

            PnlHeader = new GroupBox()
            {
                Tag = "[GroupBox]$pnlHeader",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnlHeader);

            PnlInfos = new GroupBox()
            {
                Tag = "[GroupBox]$pnlInfos",
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

            TxtboxFolder = new TextField()
            {
                Tag = "[TextField]$txtboxFolder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TxtboxFolder);

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

            WhatOccursDuringProjectMigration = new Link()
            {
                Tag = "[Link]$frmMigrationInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WhatOccursDuringProjectMigration);

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
