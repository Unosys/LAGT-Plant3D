// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupPipeSpecObjectMappingDLG : Pane
    {
        public  Pane ObjectMappingPANE;
        public  Link LookupList;
        public  PushButton CancelPB;
        public  Window Window1WIN;
        public  Window Window2WIN;
        public  Window Window3WIN;
        public  Window Window4WIN;

        partial void OnInitialize();

        public ProjectSetupPipeSpecObjectMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ObjectMappingPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pipeSpecObjectMappingUserCtrl|#1/[GroupBox]$m_groupBoxSpecMapping|#1/[PageList]$m_tabControlSpecObjects|#2/[Pane]Object Mapping|$m_tabPageSpecObjects|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ObjectMappingPANE);

            LookupList = new Link()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pipeSpecObjectMappingUserCtrl|#1/[GroupBox]$m_groupBoxSpecMapping|#1/[PageList]$m_tabControlSpecObjects|#2/[Pane]$m_tabPageSpecProperties|#1/[Pane]$m_panelProperties|#1/[ListView]$m_dataGridViewProperties|#1/[CustomWin]#5/[Link]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookupList);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Window1WIN = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pipeSpecObjectMappingUserCtrl|#1/[GroupBox]$m_groupBoxSpecMapping|#1/[PageList]$m_tabControlPnIdObjects|#1/[Window]$m_tabPageLines|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Window1WIN);

            Window2WIN = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pipeSpecObjectMappingUserCtrl|#1/[GroupBox]$m_groupBoxSpecMapping|#1/[PageList]$m_tabControlPnIdObjects|#1/[Window]$m_tabPageValves|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Window2WIN);

            Window3WIN = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pipeSpecObjectMappingUserCtrl|#1/[GroupBox]$m_groupBoxSpecMapping|#1/[PageList]$m_tabControlPnIdObjects|#1/[Window]$m_tabPageFittings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Window3WIN);

            Window4WIN = new Window()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pipeSpecObjectMappingUserCtrl|#1/[GroupBox]$m_groupBoxSpecMapping|#1/[PageList]$m_tabControlPnIdObjects|#1/[Window]$m_tabPageSpecialty|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Window4WIN);
        }
    }
}
