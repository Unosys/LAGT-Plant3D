// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupEndConnectionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView M_treeView;
        public  GroupBox AutodeskProcessPowerPnPProjectSetupGSPreviewCtrl;
        public  PushButton M_btnAddBlock;
        public  PushButton M_btnCancel;
        public  PushButton M_btnEditBlock;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOk;
        public  PushButton M_btnRemoveBlock;
        public  PushButton M_btnSave;
        public  ComboBox M_comboBox;
        public  CustomWin M_endConnectorUserCtrl;
        public  GroupBox M_groupbox;
        public  GroupBox M_groupBox2;
        public  CustomWin M_splitHorz;
        public  CustomWin M_splitVert;
        public  GroupBox SystemWindowsFormsSplitterPanel;
        public  GroupBox SystemWindowsFormsSplitterPanel2;
        public  GroupBox SystemWindowsFormsSplitterPanel3;
        public  GroupBox SystemWindowsFormsSplitterPanel4;

        partial void OnInitialize();

        public PandIDProjectSetupEndConnectionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            M_treeView = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]#1/[Pane]$m_splitVert/[Pane]#1/[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            AutodeskProcessPowerPnPProjectSetupGSPreviewCtrl = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBox2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerPnPProjectSetupGSPreviewCtrl);

            M_btnAddBlock = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$17764422|#1/[Pane]$m_splitVert|#1/[Pane]$1575054|#2/[Pane]$m_endConnectorUserCtrl|#1/[GroupBox]End connections|$m_groupbox|#1/[GroupBox]$m_groupBox2|#1/[PushButton]Add Block*|$m_btnAddBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddBlock);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnEditBlock = new PushButton()
            {
                Tag = "[PushButton]$m_btnEditBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnEditBlock);

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

            M_btnRemoveBlock = new PushButton()
            {
                Tag = "[PushButton]$m_btnRemoveBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRemoveBlock);

            M_btnSave = new PushButton()
            {
                Tag = "[PushButton]$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnSave);

            M_comboBox = new ComboBox()
            {
                Tag = "[ComboBox]$m_comboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_comboBox);

            M_endConnectorUserCtrl = new CustomWin()
            {
                Tag = "[CustomWin]$m_endConnectorUserCtrl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_endConnectorUserCtrl);

            M_groupbox = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupbox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupbox);

            M_groupBox2 = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBox2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBox2);

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
