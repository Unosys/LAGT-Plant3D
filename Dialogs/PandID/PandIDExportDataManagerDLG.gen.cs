// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$PnPExportDataDlg")]
    public partial class PandIDExportDataManagerDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;
        public  PushButton Browse;
        public  TextField EnterFileNameAndLocationF1;
        public  StaticText EnterFileNameAndLocationF2;
        public  StaticText IncludeChildNodes;
        public  RadioButton M_radioChildNodes;
        public  PopupList SelectExportSettings;
        public  StaticText SelectExportSettingsText;

        partial void OnInitialize();

        public PandIDExportDataManagerDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Help = new PushButton()
            {
                Tag = "[PushButton]#4|$m_buttonHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]#3|$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]#2|$m_buttonOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Browse = new PushButton()
            {
                Tag = "[PushButton]#1|$m_buttonBrowse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Browse);

            EnterFileNameAndLocationF1 = new TextField()
            {
                Tag = "[TextField]#1|$m_textBoxFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterFileNameAndLocationF1);

            EnterFileNameAndLocationF2 = new StaticText()
            {
                Tag = "[StaticText]#2|$m_labelFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterFileNameAndLocationF2);

            IncludeChildNodes = new StaticText()
            {
                Tag = "[StaticText]#1|$m_groupBoxNodes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncludeChildNodes);

            M_radioChildNodes = new RadioButton()
            {
                Tag = "[RadioButton]#1|$m_radioChildNodes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioChildNodes);

            SelectExportSettings = new PopupList()
            {
                Tag = "[PopupList]#1|$m_comboBoxSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectExportSettings);

            SelectExportSettingsText = new StaticText()
            {
                Tag = "[StaticText]#1|$m_labelSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectExportSettingsText);
        }
    }
}
