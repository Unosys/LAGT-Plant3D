// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Drawing Checker|$DWGCheckerProgressDlg", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class DrawingChecker : Pane
    {
        public  PushButton CancelPB;
        public  PushButton HelpPB;
        public  Pane PanePANE;
        public  CustomWin CheckingAnnotationsWIN;
        public  StaticText CheckingAnnotationsST;
        public  StaticText DrawingValidationProgressST;
        public  TitleBar DrawingCheckerCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public DrawingChecker()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$btnHelp|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            CheckingAnnotationsWIN = new CustomWin()
            {
                Tag = "[Pane]$panel1|#1/[CustomWin]<Checking Annotations*|$m_checkerProgress|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckingAnnotationsWIN);

            CheckingAnnotationsST = new StaticText()
            {
                Tag = "[Pane]$panel1|#1/[StaticText]<Checking Annotations*|$m_checkerStauts|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckingAnnotationsST);

            DrawingValidationProgressST = new StaticText()
            {
                Tag = "[Pane]$panel1|#1/[StaticText]Drawing Validation Progress|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingValidationProgressST);

            DrawingCheckerCTL = new TitleBar()
            {
                Tag = "[TitleBar]Drawing Checker|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingCheckerCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Drawing Checker|$TitleBar|#1/[CustomWin]System Menu Bar|$DWGCheckerProgressDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Drawing Checker|$TitleBar|#1/[CustomWin]System Menu Bar|$DWGCheckerProgressDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Drawing Checker|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
