// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PandIDPipeLineGroupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton MapPB;

        partial void OnInitialize();

        public PandIDPipeLineGroupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3410374|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$3410374|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            MapPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]$m_groupBox|#1/[GroupBox]$m_groupBoxProperties|#2/[PushButton]$m_btnMapProperties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MapPB);
        }
    }
}
