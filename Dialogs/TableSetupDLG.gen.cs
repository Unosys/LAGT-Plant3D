// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Table Setup|$IsoTBTableSetupDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class TableSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane TableLayoutPANE;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton M_selectIdsFileBtn;
        public  CheckBox UseCustomDescriptionCK;
        public  CheckBox CreateSeparateFabricationAndCK;

        partial void OnInitialize();

        public TableSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TableLayoutPANE = new Pane()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]$m_tabTableLayout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPANE);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            M_selectIdsFileBtn = new PushButton()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]Settings|$m_tabTableSettings|#1/[GroupBox]$m_BOMSettingsGroup|#1/[GroupBox]Descriptions|$m_BOMDescriptionGroupBox|#3/[PushButton]$m_selectIdsFileBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_selectIdsFileBtn);

            UseCustomDescriptionCK = new CheckBox()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]Settings|$m_tabTableSettings|#1/[GroupBox]$m_BOMSettingsGroup|#1/[GroupBox]Descriptions|$m_BOMDescriptionGroupBox|#3/[CheckBox]$m_customCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseCustomDescriptionCK);

            CreateSeparateFabricationAndCK = new CheckBox()
            {
                Tag = "[PageList]$m_tabControl|#1/[Pane]Settings|$m_tabTableSettings|#1/[GroupBox]$m_BOMSettingsGroup|#1/[CheckBox]$m_createFabErecCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateSeparateFabricationAndCK);
        }
    }
}
