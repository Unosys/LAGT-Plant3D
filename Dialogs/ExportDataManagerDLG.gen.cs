// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Export Data|$PnPExportDataDlg")]
    public partial class ExportDataManagerDLG : Pane
    {
        public  PushButton HelpPB;
        public  PushButton Cancel;
        public  PushButton OKPB;
        public  PushButton BrowsePB;
        public  TextField EnterFileNameAndTF;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  PopupList SelectExportSettingsPL;
        public  PushButton DropDownButtonPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ExportDataManagerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_buttonHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_buttonOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            BrowsePB = new PushButton()
            {
                Tag = "[PushButton]Browse*|$m_buttonBrowse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            EnterFileNameAndTF = new TextField()
            {
                Tag = "[TextField]Enter file name and location for exported data:|$m_textBoxFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterFileNameAndTF);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[GroupBox]Include child nodes|$m_groupBoxNodes/[RadioButton]$m_radioActiveNode",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[GroupBox]Include child nodes|$m_groupBoxNodes/[RadioButton]$m_radioChildNodes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            SelectExportSettingsPL = new PopupList()
            {
                Tag = "[PopupList]Select export settings:|$m_comboBoxSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectExportSettingsPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]Select export settings:|$m_comboBoxSettings/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Export Data|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
