// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Password Security|$PdfPasswordSecurityEditorForm|#1", Parent = typeof(PDFExportOptionsDLG), GUIType = GuiType.UIA)]
    public partial class PasswordSecurityDLG : Pane
    {
        public  PushButton BtnCancel;
        public  PushButton OKPB;
        public  Pane GrpBoxPermissionsPANE;
        public  CheckBox EnableTextAccessForCK;
        public  CheckBox EnableCopyingOfTextCK;
        public  StaticText ChangesAllowedST;
        public  StaticText PrintingAllowedST;
        public  TextField ChangesAllowedTF;
        public  StaticText None1ST;
        public  PushButton None1PB;
        public  TextField PrintingAllowedTF;
        public  StaticText None2ST;
        public  PushButton None2PB;
        public  StaticText ChangePermissionsPasswordST;
        public  TextField ChangePermissionsPasswordTF;
        public  StaticText PasswordTextEdit1ST;
        public  CheckBox RestricteditingAndPrintingCK;
        public  StaticText DocumentOpenPasswordST;
        public  TextField DocumentOpenPasswordTF;
        public  StaticText PasswordTextEdit2ST;
        public  CheckBox RequireAPasswordToCK;
        public  TitleBar PasswordSecurityCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PasswordSecurityDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            OKPB = new PushButton()
            {
                Tag = "[Pane]The XtraLayoutControl|$layoutControl1|#1/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            GrpBoxPermissionsPANE = new Pane()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GrpBoxPermissionsPANE);

            EnableTextAccessForCK = new CheckBox()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[CheckBox]Enable text access for screen reader devices for the *|$chbEnableScreenReaders|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnableTextAccessForCK);

            EnableCopyingOfTextCK = new CheckBox()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[CheckBox]*Enable copying of text, images and other content*|$chbEnableCoping|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnableCopyingOfTextCK);

            ChangesAllowedST = new StaticText()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[StaticText]Changes Allowed:|$lbChangesAllowed|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangesAllowedST);

            PrintingAllowedST = new StaticText()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[StaticText]Printing Allowed:|$lbPrintingAllowed|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrintingAllowedST);

            ChangesAllowedTF = new TextField()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[TextField]Changes Allowed:|$lkpChangesAllowed|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangesAllowedTF);

            None1ST = new StaticText()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[TextField]Changes Allowed:|$lkpChangesAllowed|#3/[StaticText]None|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(None1ST);

            None1PB = new PushButton()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[TextField]Changes Allowed:|$lkpChangesAllowed|#3/[PushButton]None|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(None1PB);

            PrintingAllowedTF = new TextField()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[TextField]Printing Allowed:|$lkpPrintingAllowed|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrintingAllowedTF);

            None2ST = new StaticText()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[TextField]Printing Allowed:|$lkpPrintingAllowed|#2/[StaticText]None|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(None2ST);

            None2PB = new PushButton()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[TextField]Printing Allowed:|$lkpPrintingAllowed|#2/[PushButton]None|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(None2PB);

            ChangePermissionsPasswordST = new StaticText()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[StaticText]Change Permissions Password:|$lbPermissionsPassword|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangePermissionsPasswordST);

            ChangePermissionsPasswordTF = new TextField()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[TextField]Change Permissions Password:|$tePermissionsPassword|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangePermissionsPasswordTF);

            PasswordTextEdit1ST = new StaticText()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[TextField]Change Permissions Password:|$tePermissionsPassword|#1/[StaticText]PasswordTextEdit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTextEdit1ST);

            RestricteditingAndPrintingCK = new CheckBox()
            {
                Tag = "[Pane]grpBoxPermissions|$grpBoxPermissions|#1/[CheckBox]Restrict *|$chbRestrict|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RestricteditingAndPrintingCK);

            DocumentOpenPasswordST = new StaticText()
            {
                Tag = "[StaticText]Document Open Password:|$lbOpenPassword|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DocumentOpenPasswordST);

            DocumentOpenPasswordTF = new TextField()
            {
                Tag = "[TextField]Document Open Password:|$teOpenPassword|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DocumentOpenPasswordTF);

            PasswordTextEdit2ST = new StaticText()
            {
                Tag = "[TextField]Document Open Password:|$teOpenPassword|#1/[StaticText]PasswordTextEdit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordTextEdit2ST);

            RequireAPasswordToCK = new CheckBox()
            {
                Tag = "[CheckBox]Require a password to *|$chbOpenPassword|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RequireAPasswordToCK);

            PasswordSecurityCTL = new TitleBar()
            {
                Tag = "[TitleBar]Password Security|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PasswordSecurityCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Password Security|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
