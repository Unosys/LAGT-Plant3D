// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Report Selection|$SheetSelectionDlg|#1")]
    public partial class ProjectReportSelectionDLG : Pane
    {
        public  PushButton OKPB;
        public  StaticText SelectProjectReportToST;
        public  PopupList SelectProjectReportToPL;
        public  PushButton DropDownButtonPB;
        public  TitleBar ProjectReportSelectionCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectReportSelectionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$button1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            SelectProjectReportToST = new StaticText()
            {
                Tag = "[StaticText]Select project report to import: |$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectProjectReportToST);

            SelectProjectReportToPL = new PopupList()
            {
                Tag = "[PopupList]Select project report to import: |$m_cbSheetNames|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectProjectReportToPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]Select project report to import: |$m_cbSheetNames|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            ProjectReportSelectionCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Report Selection|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectReportSelectionCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Report Selection|$TitleBar|#1/[CustomWin]System Menu Bar|$SheetSelectionDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Report Selection|$TitleBar|#1/[CustomWin]System Menu Bar|$SheetSelectionDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Report Selection|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
