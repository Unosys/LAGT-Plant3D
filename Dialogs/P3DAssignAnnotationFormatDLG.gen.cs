// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$TagformatSetupDlg", Parent = typeof(Plant3D))]
    public partial class P3DAssignAnnotationFormatDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnMoreless;
        public  PushButton HelpPB;
        public  PushButton OKPB;
        public  Pane PanePANE;
        public  Pane UniquePANE;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  PushButton M_btnExpression;
        public  PushButton M_btnProject;
        public  PushButton M_btnDraw;
        public  PushButton M_btnClass;
        public  StaticText DelimiterST;
        public  StaticText FieldST;
        public  PushButton M_btnCancel;
        public  CustomWin NumberOfSubparts1WIN;
        public  CustomWin SpinnerWIN;
        public  PushButton ForwardPB;
        public  PushButton BackwardPB;
        public  CustomWin NumberOfSubparts2WIN;
        public  StaticText NumberOfSubpartsST;
        public  StaticText OvalTagStyleST;
        public  StaticText AnnotationNameST;
        public  TitleBar AssignAnnotationFormatCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public P3DAssignAnnotationFormatDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnMoreless = new PushButton()
            {
                Tag = "[PushButton]$m_btnMoreless|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnMoreless);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            PanePANE = new Pane()
            {
                Tag = "[Pane]$panel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            UniquePANE = new Pane()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UniquePANE);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1/[TextField]$m_tboxDelimiter|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1/[TextField]$m_tboxField|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            M_btnExpression = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1/[PushButton]$m_btnExpression|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnExpression);

            M_btnProject = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1/[PushButton]$m_btnProject|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnProject);

            M_btnDraw = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1/[PushButton]$m_btnDraw|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDraw);

            M_btnClass = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1/[PushButton]$m_btnClass|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnClass);

            DelimiterST = new StaticText()
            {
                Tag = "[Pane]$panel1|#1/[StaticText]Delimiter|$m_lblDelimiterText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DelimiterST);

            FieldST = new StaticText()
            {
                Tag = "[Pane]$panel1|#1/[StaticText]Field|$m_lblFieldText|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldST);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            NumberOfSubparts1WIN = new CustomWin()
            {
                Tag = "[CustomWin]Number of Subparts:|$m_numOfSubparts|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfSubparts1WIN);

            SpinnerWIN = new CustomWin()
            {
                Tag = "[CustomWin]Number of Subparts:|$m_numOfSubparts|#1/[CustomWin]Spinner|$30084538|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpinnerWIN);

            ForwardPB = new PushButton()
            {
                Tag = "[CustomWin]Number of Subparts:|$m_numOfSubparts|#1/[CustomWin]Spinner|$30084538|#2/[PushButton]Forward|$SmallIncrement|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ForwardPB);

            BackwardPB = new PushButton()
            {
                Tag = "[CustomWin]Number of Subparts:|$m_numOfSubparts|#1/[CustomWin]Spinner|$30084538|#2/[PushButton]Backward|$SmallDecrement|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackwardPB);

            NumberOfSubparts2WIN = new CustomWin()
            {
                Tag = "[CustomWin]Number of Subparts:|$m_numOfSubparts|#1/[CustomWin]Number of Subparts:|$m_numOfSubparts|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfSubparts2WIN);

            NumberOfSubpartsST = new StaticText()
            {
                Tag = "[StaticText]Number of Subparts:|$m_lblSubpartsText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberOfSubpartsST);

            OvalTagStyleST = new StaticText()
            {
                Tag = "[StaticText]Oval Tag Style|$m_labelClass|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OvalTagStyleST);

            AnnotationNameST = new StaticText()
            {
                Tag = "[StaticText]Annotation Name:|$m_lblClassText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationNameST);

            AssignAnnotationFormatCTL = new TitleBar()
            {
                Tag = "[TitleBar]Assign Annotation Format|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignAnnotationFormatCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Assign Annotation Format|$TitleBar|#1/[CustomWin]System Menu Bar|$TagformatSetupDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Assign Annotation Format|$TitleBar|#1/[CustomWin]System Menu Bar|$TagformatSetupDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Assign Annotation Format|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
