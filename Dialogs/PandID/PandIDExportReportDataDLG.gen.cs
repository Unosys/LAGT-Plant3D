// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]ExportReportDataDLG")]
    public partial class PandIDExportReportDataDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_buttonBrowse;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonHelp;
        public  PushButton M_buttonOK;
        public  ComboBox M_comboBoxSettings;
        public  GroupBox M_groupBoxNodes;
        public  StaticText M_labelFile;
        public  StaticText M_labelSettings;
        public  RadioButton M_radioActiveNode;
        public  RadioButton M_radioChildNodes;
        public  TextField M_textBoxFile;

        partial void OnInitialize();

        public PandIDExportReportDataDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_buttonBrowse = new PushButton()
            {
                Tag = "[PushButton]$m_buttonBrowse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonBrowse);

            M_buttonCancel = new PushButton()
            {
                Tag = "[PushButton]$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonHelp = new PushButton()
            {
                Tag = "[PushButton]$m_buttonHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonHelp);

            M_buttonOK = new PushButton()
            {
                Tag = "[PushButton]$m_buttonOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonOK);

            M_comboBoxSettings = new ComboBox()
            {
                Tag = "[ComboBox]$m_comboBoxSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBoxSettings);

            M_groupBoxNodes = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxNodes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxNodes);

            M_labelFile = new StaticText()
            {
                Tag = "[StaticText]$m_labelFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelFile);

            M_labelSettings = new StaticText()
            {
                Tag = "[StaticText]$m_labelSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelSettings);

            M_radioActiveNode = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioActiveNode",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioActiveNode);

            M_radioChildNodes = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioChildNodes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioChildNodes);

            M_textBoxFile = new TextField()
            {
                Tag = "[TextField]$m_textBoxFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxFile);
        }
    }
}
