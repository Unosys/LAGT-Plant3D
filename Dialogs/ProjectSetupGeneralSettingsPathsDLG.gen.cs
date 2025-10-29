// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupGeneralSettingsPathsDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton EditDWGPB;
        public  PushButton OrthoDwgPB;
        public  PushButton P3dDwtPB;
        public  PushButton EquipSnapshotsDirPB;
        public  PushButton SpecDirPB;
        public  PushButton P3dDwgPB;
        public  PushButton PnIdDwtPB;
        public  PushButton PnIdDwgPB;

        partial void OnInitialize();

        public ProjectSetupGeneralSettingsPathsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$133738|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            EditDWGPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[PushButton]$m_EditPssButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditDWGPB);

            OrthoDwgPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[PushButton]$m_btnOrthoDwg|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDwgPB);

            P3dDwtPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[PushButton]$m_btnP3dDwt|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dDwtPB);

            EquipSnapshotsDirPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[PushButton]$m_btnEquipSnapshotsDir|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipSnapshotsDirPB);

            SpecDirPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[PushButton]$m_btnSpecDir|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecDirPB);

            P3dDwgPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[PushButton]$m_btnP3dDwg|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dDwgPB);

            PnIdDwtPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[PushButton]$m_btnPnIdDwt|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnIdDwtPB);

            PnIdDwgPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pathsUserControl|#1/[GroupBox]$m_groupBoxProjectPath|#1/[PushButton]$m_btnPnIdDwg|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnIdDwgPB);
        }
    }
}
