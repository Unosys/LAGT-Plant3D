// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$Window_1", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class ProjectCompareProgramDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar ProjectCompareCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  StaticText CompareFileDifferencesUsingST;
        public  StaticText SelectProgramToUseST;
        public  PushButton BrowsePB;
        public  StaticText BrowseST;
        public  StaticText ChooseAnApplicationThatST;
        public  PushButton CompareFilesPB;
        public  StaticText CompareFilesST;
        public  PushButton CancelPB;
        public  StaticText CancelST;

        partial void OnInitialize();

        public ProjectCompareProgramDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ProjectCompareCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectCompareCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Compare|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CompareFileDifferencesUsingST = new StaticText()
            {
                Tag = "[StaticText]Compare file differences using an external program|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompareFileDifferencesUsingST);

            SelectProgramToUseST = new StaticText()
            {
                Tag = "[StaticText]Select program to use for comparison|$TextBlock_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectProgramToUseST);

            BrowsePB = new PushButton()
            {
                Tag = "[PushButton]$Button_1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            BrowseST = new StaticText()
            {
                Tag = "[PushButton]Browse|$Button_1|#1/[StaticText]Browse|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowseST);

            ChooseAnApplicationThatST = new StaticText()
            {
                Tag = "[StaticText]Choose an application that supports text file comparison*|$TextBlock_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseAnApplicationThatST);

            CompareFilesPB = new PushButton()
            {
                Tag = "[PushButton]Compare Files|$Button_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompareFilesPB);

            CompareFilesST = new StaticText()
            {
                Tag = "[PushButton]Compare Files|$Button_2|#2/[StaticText]Compare Files|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompareFilesST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Button_3|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$Button_3|#3/[StaticText]Cancel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);
        }
    }
}
