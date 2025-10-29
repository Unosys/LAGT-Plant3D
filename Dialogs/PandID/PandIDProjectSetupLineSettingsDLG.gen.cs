// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupLineSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText Label1;
        public  PushButton M_btnCancel;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOk;
        public  PushButton M_btnSave;
        public  CheckBox M_checkBoxAutoCorner;
        public  CheckBox M_checkBoxMaintainInline;
        public  ComboBox M_comboBoxGap;
        public  ComboBox M_comboBoxVgrip;
        public  GroupBox M_groupBoxGapSymbol;
        public  GroupBox M_groupBoxLineCross;
        public  GroupBox M_groupBoxMain;
        public  GroupBox M_groupBoxStandoff;
        public  GroupBox M_groupBoxVgrip;
        public  StaticText M_labelGapWidth;
        public  StaticText M_labelSymbol;
        public  CustomWin M_lineSettingsUserCtrl;
        public  CustomWin M_pictureBoxVgrip;
        public  CustomWin M_pictureGap;
        public  CustomWin M_pictureGapSymbol;
        public  CustomWin M_pictureLoop;
        public  CustomWin M_pictureStandoffHorz;
        public  RadioButton M_radioGap;
        public  RadioButton M_radioLoop;
        public  CustomWin M_splitHorz;
        public  CustomWin M_splitVert;
        public  StaticText M_StaticGripSettings;
        public  TextField M_textBoxStandoff;
        public  TextField M_textBoxWidth;
        public  TreeView M_treeView;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public PandIDProjectSetupLineSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_btnSave = new PushButton()
            {
                Tag = "[PushButton]$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            M_checkBoxAutoCorner = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkBoxAutoCorner",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxAutoCorner);

            M_checkBoxMaintainInline = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkBoxMaintainInline",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkBoxMaintainInline);

            M_comboBoxGap = new ComboBox()
            {
                Tag = "[ComboBox]$m_comboBoxGap",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBoxGap);

            M_comboBoxVgrip = new ComboBox()
            {
                Tag = "[ComboBox]$m_comboBoxVgrip",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBoxVgrip);

            M_groupBoxGapSymbol = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxGapSymbol",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxGapSymbol);

            M_groupBoxLineCross = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxLineCross",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxLineCross);

            M_groupBoxMain = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxMain",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxMain);

            M_groupBoxStandoff = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxStandoff",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxStandoff);

            M_groupBoxVgrip = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBoxVgrip",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBoxVgrip);

            M_labelGapWidth = new StaticText()
            {
                Tag = "[StaticText]$m_labelGapWidth",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelGapWidth);

            M_labelSymbol = new StaticText()
            {
                Tag = "[StaticText]$m_labelSymbol",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelSymbol);

            M_lineSettingsUserCtrl = new CustomWin()
            {
                Tag = "[CustomWin]$m_lineSettingsUserCtrl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lineSettingsUserCtrl);

            M_pictureBoxVgrip = new CustomWin()
            {
                Tag = "[CustomWin]$m_pictureBoxVgrip",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pictureBoxVgrip);

            M_pictureGap = new CustomWin()
            {
                Tag = "[CustomWin]$m_pictureGap",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pictureGap);

            M_pictureGapSymbol = new CustomWin()
            {
                Tag = "[CustomWin]$m_pictureGapSymbol",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pictureGapSymbol);

            M_pictureLoop = new CustomWin()
            {
                Tag = "[CustomWin]$m_pictureLoop",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pictureLoop);

            M_pictureStandoffHorz = new CustomWin()
            {
                Tag = "[CustomWin]$m_pictureStandoffHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pictureStandoffHorz);

            M_radioGap = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioGap",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioGap);

            M_radioLoop = new RadioButton()
            {
                Tag = "[RadioButton]$m_radioLoop",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_radioLoop);

            M_splitHorz = new CustomWin()
            {
                Tag = "[CustomWin]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_splitHorz);

            M_splitVert = new CustomWin()
            {
                Tag = "[CustomWin]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_splitVert);

            M_StaticGripSettings = new StaticText()
            {
                Tag = "[StaticText]$m_StaticGripSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_StaticGripSettings);

            M_textBoxStandoff = new TextField()
            {
                Tag = "[TextField]$m_textBoxStandoff",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxStandoff);

            M_textBoxWidth = new TextField()
            {
                Tag = "[TextField]$m_textBoxWidth",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBoxWidth);

            M_treeView = new TreeView()
            {
                Tag = "[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            SystemWindowsFormsSplitterPanel = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel);

            SystemWindowsFormsSplitterPanel2 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel2);

            SystemWindowsFormsSplitterPanel3 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel3);

            SystemWindowsFormsSplitterPanel4 = new GroupBox()
            {
                Tag = "[GroupBox]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsFormsSplitterPanel4);
        }
    }
}
