// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Select Block|$ChooseBlockDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PandIDSelectBlockPandIDDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox AutodeskProcessPowerPnPProjectSetupGSPreviewCtrl;
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  GroupBox M_groupBox;
        public  StaticText M_labelBlkList;
        public  ListBox M_listBox;
        public  ScrollBar VerticalScrollBar;

        partial void OnInitialize();

        public PandIDSelectBlockPandIDDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutodeskProcessPowerPnPProjectSetupGSPreviewCtrl = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerPnPProjectSetupGSPreviewCtrl);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            M_groupBox = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupBox);

            M_labelBlkList = new StaticText()
            {
                Tag = "[StaticText]$m_labelBlkList",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelBlkList);

            M_listBox = new ListBox()
            {
                Tag = "[ListBox]$m_listBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBox);

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$m_listBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);
        }
    }
}
