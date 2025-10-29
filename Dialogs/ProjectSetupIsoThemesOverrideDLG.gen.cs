// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectSetupIsoThemesOverrideDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListBox OverrideThemesLB;
        public  PushButton CancelPB;
        public  PushButton StartsWithPB;
        public  PushButton EndsWithPB;
        public  PushButton OnlyContainPB;
        public  PushButton PipingDetailsPB;

        partial void OnInitialize();

        public ProjectSetupIsoThemesOverrideDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OverrideThemesLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert|#1/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#2/[CustomWin]$UserControl_1|#1/[ListBox]$ThemeListView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OverrideThemesLB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2491740|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            StartsWithPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]#1/[Window]#2/[CustomWin]$UserControl_1|#1/[CustomWin]#4/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StartsWithPB);

            EndsWithPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]#1/[Window]#2/[CustomWin]$UserControl_1|#1/[CustomWin]#5/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndsWithPB);

            OnlyContainPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]#1/[Window]#2/[CustomWin]$UserControl_1|#1/[CustomWin]#6/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OnlyContainPB);

            PipingDetailsPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#2/[CustomWin]$UserControl_1|#1/[CustomWin]#4/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingDetailsPB);
        }
    }
}
