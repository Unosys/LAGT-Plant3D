// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$TagformatSetupDlg")]
    public partial class P3DTagFormatSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnClass;
        public  PushButton M_btnProject;
        public  PushButton M_btnDraw;
        public  Pane Pane1PANE;
        public  PushButton M_btnMoreless;
        public  PushButton M_btnCancel;
        public  PushButton M_btnExpression;

        partial void OnInitialize();

        public P3DTagFormatSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnClass = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1/[PushButton]$m_btnClass|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnClass);

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

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$panel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            M_btnMoreless = new PushButton()
            {
                Tag = "[PushButton]$m_btnMoreless",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnMoreless);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnExpression = new PushButton()
            {
                Tag = "[Pane]$panel1|#1/[Pane]Unique|$fieldsUserControl|#1/[PushButton]$m_btnExpression|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnExpression);
        }
    }
}
