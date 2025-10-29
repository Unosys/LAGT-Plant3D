// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$CreateConnectionDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class CreateConnectionDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox PreviewGB;
        public  PushButton BtnCancel;
        public  PushButton BtnHelp;
        public  PushButton BtnOk;
        public  GroupBox GroupBoxPreview;
        public  StaticText M_OPCPreviewLabel;
        public  Table OPCDataGridView;
        public  GroupBox OPCListPanel;
        public  GroupBox PreviewPanel;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CreateConnectionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PreviewGB = new GroupBox()
            {
                Tag = "[GroupBox]Preview|$groupBoxPreview|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewGB);

            BtnCancel = new PushButton()
            {
                Tag = "[Pane]Select Offpage Connector to Connect to:|$splitHoriz|#1/[Pane]$2951128|#2/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            BtnOk = new PushButton()
            {
                Tag = "[PushButton]$btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOk);

            GroupBoxPreview = new GroupBox()
            {
                Tag = "[GroupBox]$groupBoxPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxPreview);

            M_OPCPreviewLabel = new StaticText()
            {
                Tag = "[StaticText]$m_OPCPreviewLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_OPCPreviewLabel);

            OPCDataGridView = new Table()
            {
                Tag = "[Table]$OPCDataGridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OPCDataGridView);

            OPCListPanel = new GroupBox()
            {
                Tag = "[GroupBox]$OPCListPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OPCListPanel);

            PreviewPanel = new GroupBox()
            {
                Tag = "[GroupBox]$previewPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviewPanel);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Connection|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
