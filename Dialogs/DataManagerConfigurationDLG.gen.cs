// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class DataManagerConfigurationDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton DeleteViewPB;
        public  PushButton CreateViewPB;
        public  PushButton NewLevelPB;
        public  PopupList ScopePL;

        partial void OnInitialize();

        public DataManagerConfigurationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            DeleteViewPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[PushButton]Delete View|$m_buttonRemoveView|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteViewPB);

            CreateViewPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[PushButton]Create View|$m_buttonNewView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateViewPB);

            NewLevelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[PushButton]New Level*|$m_btnNewLevel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewLevelPB);

            ScopePL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_dm3dConfigUserControl|#1/[Pane]$m_dataManagerConfigUserControl|#1/[GroupBox]Customized views|$m_viewsGroupBox|#1/[Pane]$splitContainer1|#1/[Pane]#2/[Pane]$m_viewsPanel|#1/[Pane]$CustomizedViewUserControl|#1/[GroupBox]A New Customized View - Drawing Data|$m_groupBox|#1/[Pane]$m_viewNamePanel|#1/[PopupList]Scope:|$m_comboBoxScope|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScopePL);
        }
    }
}
