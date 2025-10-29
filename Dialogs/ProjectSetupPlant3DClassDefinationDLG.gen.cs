// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupPlant3DClassDefinationDLG : Pane
    {
        public  PushButton EditPB;
        public  ListView ListViewLV;
        public  PushButton NewPB;
        public  PushButton AddPB;

        partial void OnInitialize();

        public ProjectSetupPlant3DClassDefinationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            EditPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Blower|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Edit*|$m_btnEditProperties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditPB);

            ListViewLV = new ListView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Blower|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[ListView]$m_dataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            NewPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Blower|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]New*|$m_btnNewTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewPB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Blower|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Add*|$m_btnAddProperty|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);
        }
    }
}
