// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupSQLExpressDatabaseSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnOk;
        public  PushButton AddPB;
        public  PushButton RemovePB;

        partial void OnInitialize();

        public PandIDProjectSetupSQLExpressDatabaseSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOk = new PushButton()
            {
                Tag = "[PushButton]$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOk);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_databaseSetupUserControl|#1/[GroupBox]$m_xdbDataSroucesGroupBox|#2/[Pane]$m_xdbPanel|#1/[Pane]elementHost1|$m_xdbHost|#1/[Pane]elementHost1|#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]Add|$AddDataSourceBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            RemovePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_databaseSetupUserControl|#1/[GroupBox]$m_xdbDataSroucesGroupBox|#2/[Pane]$m_xdbPanel|#1/[Pane]elementHost1|$m_xdbHost|#1/[Pane]elementHost1|#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PushButton]Remove|$RomoveDataSourceBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);
        }
    }
}
