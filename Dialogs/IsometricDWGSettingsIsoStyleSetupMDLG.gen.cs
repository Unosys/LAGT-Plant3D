// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class IsometricDWGSettingsIsoStyleSetupMDLG : Pane
    {
        public  PushButton CancelPB;
        public  PopupList SizingMethodPL;

        partial void OnInitialize();

        public IsometricDWGSettingsIsoStyleSetupMDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$68830|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            SizingMethodPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_isometricPathsUserCtrl|#1/[Pane]$panel_IsoStyleSetup|#1/[GroupBox]Spools|$groupBox_Spools|#5/[PopupList]Sizing method:|$comboBox_SpoolSizing|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizingMethodPL);
        }
    }
}
