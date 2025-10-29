// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$ViewConnectedOffpageConnectDLG", Parent = typeof(Plant3D))]
    public partial class ViewConnectedOffpageConnectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox AutodeskProcessPowerPnIDGUIUtilOPCGsPreviewCtrl;
        public  PushButton Chevron;
        public  ScrollBar ConnectedLineSegmentProperties;
        public  StaticText Label1;
        public  PushButton M_btnCancel;
        public  PushButton M_btnDisconnect;
        public  PushButton M_btnHelp;
        public  PushButton M_btnOK;
        public  GroupBox M_groupGrid;
        public  GroupBox M_groupPreivew;
        public  GroupBox M_panelPreview;
        public  Table OPCDataGridView;
        public  ToolBar ToolStrip1;
        public  PushButton ToolStripButton_accept;
        public  PushButton ToolStripButton_acceptall;

        partial void OnInitialize();

        public ViewConnectedOffpageConnectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutodeskProcessPowerPnIDGUIUtilOPCGsPreviewCtrl = new GroupBox()
            {
                Tag = "[GroupBox]$m_panelPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerPnIDGUIUtilOPCGsPreviewCtrl);

            Chevron = new PushButton()
            {
                Tag = "[PushButton]$chevron",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Chevron);

            ConnectedLineSegmentProperties = new ScrollBar()
            {
                Tag = "[ScrollBar]$OPCDataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectedLineSegmentProperties);

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

            M_btnDisconnect = new PushButton()
            {
                Tag = "[PushButton]$m_btnDisconnect",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDisconnect);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnOK = new PushButton()
            {
                Tag = "[PushButton]$m_btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOK);

            M_groupGrid = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupGrid",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupGrid);

            M_groupPreivew = new GroupBox()
            {
                Tag = "[GroupBox]$m_groupPreivew",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_groupPreivew);

            M_panelPreview = new GroupBox()
            {
                Tag = "[GroupBox]$m_panelPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_panelPreview);

            OPCDataGridView = new Table()
            {
                Tag = "[Table]$OPCDataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OPCDataGridView);

            ToolStrip1 = new ToolBar()
            {
                Tag = "[ToolBar]$toolStrip1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolStrip1);

            ToolStripButton_accept = new PushButton()
            {
                Tag = "[PushButton]$toolStripButton_accept",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolStripButton_accept);

            ToolStripButton_acceptall = new PushButton()
            {
                Tag = "[PushButton]$toolStripButton_acceptall",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolStripButton_acceptall);
        }
    }
}
