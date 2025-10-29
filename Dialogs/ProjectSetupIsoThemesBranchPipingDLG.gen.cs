// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ProjectSetupIsoThemesBranchPipingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListBox BranchPipingThemesLB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  PushButton EnablePB;
        public  PushButton PipingDetailsPB;
        public  PushButton StartsWithPB;
        public  PushButton EndsWithPB;
        public  PushButton Contains9PB;
        public  PushButton DoesNotContainPB;

        partial void OnInitialize();

        public ProjectSetupIsoThemesBranchPipingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BranchPipingThemesLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]*/[Pane]$m_splitVert/[Pane]*/[Pane]*/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl/[Window]#3/[CustomWin]$UserControl_1/[ListBox]$ThemeListView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BranchPipingThemesLB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2491740|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2491740|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$2491740|#2/[PushButton]Apply|$m_btnSave|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            EnablePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#3/[CustomWin]$UserControl_1|#1/[CustomWin]#3/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnablePB);

            PipingDetailsPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#3/[CustomWin]$UserControl_1|#1/[CustomWin]#4/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingDetailsPB);

            StartsWithPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#3/[CustomWin]$UserControl_1|#1/[CustomWin]#5/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StartsWithPB);

            EndsWithPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#3/[CustomWin]$UserControl_1|#1/[CustomWin]#6/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndsWithPB);

            Contains9PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#3/[CustomWin]$UserControl_1|#1/[CustomWin]#7/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Contains9PB);

            DoesNotContainPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[PageList]$IsometricThemeTabCtrl|#1/[Window]#3/[CustomWin]$UserControl_1|#1/[CustomWin]#8/[PushButton]$CollapsiblePanel_Button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoesNotContainPB);
        }
    }
}
