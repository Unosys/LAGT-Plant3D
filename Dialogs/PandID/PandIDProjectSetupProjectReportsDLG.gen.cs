// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupProjectReportsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnNew;
        public  ListBox M_listBox;
        public  PushButton M_btnModify;

        partial void OnInitialize();

        public PandIDProjectSetupProjectReportsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnNew = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5246688|#1/[Pane]$m_splitVert|#1/[Pane]$7867210|#2/[Pane]$m_reportsUserControl|#1/[GroupBox]Project reports|$groupBox1|#1/[PushButton]$m_btnNew|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnNew);

            M_listBox = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5246688|#1/[Pane]$m_splitVert|#1/[Pane]$7867210|#2/[Pane]$m_reportsUserControl|#1/[GroupBox]Project reports|$groupBox1|#1/[ListBox]Defined reports:|$m_listBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listBox);

            M_btnModify = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5246688|#1/[Pane]$m_splitVert|#1/[Pane]$7867210|#2/[Pane]$m_reportsUserControl|#1/[GroupBox]Project reports|$groupBox1|#1/[PushButton]$m_btnModify",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModify);
        }
    }
}
