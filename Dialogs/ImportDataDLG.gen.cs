// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Import Data|$PnPImportDataDlg")]
    public partial class ImportDataDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PopupList SelectImportSettingsPL;
        public  PushButton DropDownButtonPB;
        public  StaticText SelectImportSettingsST;
        public  PushButton BrowsePB;
        public  TextField SelectFileToImportTF;
        public  StaticText SelectFileToImportST;
        public  TitleBar ImportDataCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ImportDataDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_buttonHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_buttonCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_buttonOK|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            SelectImportSettingsPL = new PopupList()
            {
                Tag = "[PopupList]Select import settings:|$m_comboBoxSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectImportSettingsPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]Select import settings:|$m_comboBoxSettings|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            SelectImportSettingsST = new StaticText()
            {
                Tag = "[StaticText]Select import settings:|$m_labelSettings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectImportSettingsST);

            BrowsePB = new PushButton()
            {
                Tag = "[PushButton]Browse*|$m_buttonBrowse|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            SelectFileToImportTF = new TextField()
            {
                Tag = "[TextField]Select file to import:|$m_textBoxFile|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFileToImportTF);

            SelectFileToImportST = new StaticText()
            {
                Tag = "[StaticText]Select file to import:|$m_labelFile|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFileToImportST);

            ImportDataCTL = new TitleBar()
            {
                Tag = "[TitleBar]Import Data|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportDataCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Import Data|$TitleBar|#1/[CustomWin]System Menu Bar|$PnPImportDataDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Import Data|$TitleBar|#1/[CustomWin]System Menu Bar|$PnPImportDataDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Import Data|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
