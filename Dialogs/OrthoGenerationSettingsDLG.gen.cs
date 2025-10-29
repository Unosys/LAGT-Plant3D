// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Ortho Generation Settings|$OrthoGenerationSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class OrthoGenerationSettingsDLG : Pane
    {
        public  PushButton BtnCancel;
        public  PushButton OkPB;
        public  PushButton ClosePB;
        public  CheckBox Use3DModelLayersCK;
        public  PopupList PopupList1PL;
        public  PushButton Open4PB;

        partial void OnInitialize();

        public OrthoGenerationSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            OkPB = new PushButton()
            {
                Tag = "[PushButton]Ok|$btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Ortho Generation Settings|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Use3DModelLayersCK = new CheckBox()
            {
                Tag = "[Pane]$panel1|#1/[GroupBox]Layer Setup|$groupBoxLayerSetup|#1/[CheckBox]$cbUseLayerAsModel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Use3DModelLayersCK);

            PopupList1PL = new PopupList()
            {
                Tag = "[Pane]$panel1|#1/[GroupBox]Layer Setup|$groupBoxLayerSetup|#1/[PopupList]$cmbModelProperties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList1PL);

            Open4PB = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[GroupBox]Layer Setup|$groupBoxLayerSetup|#1/[PopupList]$cmbModelProperties|#1/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open4PB);
        }
    }
}
