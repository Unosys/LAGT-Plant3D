// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$OptionsForm", Parent = typeof(VaultPro), GUIType = GuiType.UIA)]
    public partial class VM_OptionsDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  CheckBox UndoCheckOutDialogCK;
        public  PushButton SettingsPB_UndoCheckOut;
        public  CheckBox CheckInDialogCK;
        public  PushButton SettingsPB_CheckIn;
        public  PushButton SettingsPB_File;
        public  PushButton PromptsPB;
        public  PushButton BrowseForProjectFilePB;
        public  PushButton DocumentPreviewersPB;
        public  PopupList ColorThemePL;
        public  PopupList DefaultSettingsForViewingPL;
        public  TextField ProjectFileTF;

        partial void OnInitialize();

        public VM_OptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$m_cancelButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$m_okButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            UndoCheckOutDialogCK = new CheckBox()
            {
                Tag = "[Pane]$m_dialogSuppressionGroupBox/[CheckBox]$m_undoCheckOutCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UndoCheckOutDialogCK);

            SettingsPB_UndoCheckOut = new PushButton()
            {
                Tag = "[Pane]$m_dialogSuppressionGroupBox/[PushButton]$m_undoCheckOutSettingsButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsPB_UndoCheckOut);

            CheckInDialogCK = new CheckBox()
            {
                Tag = "[Pane]$m_dialogSuppressionGroupBox/[CheckBox]$m_checkInCheckBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInDialogCK);

            SettingsPB_CheckIn = new PushButton()
            {
                Tag = "[Pane]$m_dialogSuppressionGroupBox/[PushButton]$m_checkInSettingsButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsPB_CheckIn);

            SettingsPB_File = new PushButton()
            {
                Tag = "[Pane]$m_generalOptionsGroupBox/[PushButton]$btnFileOpenBehavior",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsPB_File);

            PromptsPB = new PushButton()
            {
                Tag = "[Pane]$m_generalOptionsGroupBox/[PushButton]$m_promptsButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PromptsPB);

            BrowseForProjectFilePB = new PushButton()
            {
                Tag = "[Pane]$m_groupBoxInventorProjectFileOptions/[PushButton]$m_button_BrowseForProjectFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowseForProjectFilePB);

            DocumentPreviewersPB = new PushButton()
            {
                Tag = "[Pane]$m_generalOptionsGroupBox/[PushButton]$m_documentPreviewButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DocumentPreviewersPB);

            ColorThemePL = new PopupList()
            {
                Tag = "[Pane]$m_generalOptionsGroupBox/[PopupList]$m_skinsComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColorThemePL);

            DefaultSettingsForViewingPL = new PopupList()
            {
                Tag = "[Pane]$m_generalOptionsGroupBox/[PopupList]$m_invViewerComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultSettingsForViewingPL);

            ProjectFileTF = new TextField()
            {
                Tag = "[Pane]$m_groupBoxInventorProjectFileOptions/[TextField]$m_textBox_ProjectFilePath",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectFileTF);
        }
    }
}
