// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Settings|$frmVaultCheckinSettings|#1")]
    public partial class CheckInSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PopupList PopupListPL;
        public  PushButton OpenPB;
        public  CheckBox CreateVisualizationAttachmentCK;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CheckInSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PopupListPL = new PopupList()
            {
                Tag = "[GroupBox]$groupBoxVisualAttachment|#1/[PopupList]$comboViz|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            OpenPB = new PushButton()
            {
                Tag = "[GroupBox]$groupBoxVisualAttachment|#1/[PopupList]$comboViz|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CreateVisualizationAttachmentCK = new CheckBox()
            {
                Tag = "[GroupBox]$groupBoxVisualAttachment|#1/[CheckBox]Create visualization attachment|$chkboxVisualAttachment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateVisualizationAttachmentCK);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Settings|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
