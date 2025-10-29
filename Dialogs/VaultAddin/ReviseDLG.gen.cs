// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmVaultRevise", Parent = typeof(PROJECTMANAGERDLG))]
    public partial class ReviseDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TextField M_TxtBoxComments;
        public  StaticText EnterCommentsST;
        public  GroupBox SelectNewRevisionGB;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  RadioButton M_RadioBtnPrimary;
        public  StaticText CurrentRevisionAStandardST;
        public  PushButton CancelPB;
        public  PushButton OK;
        public  TitleBar ReviseAcaddwgCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReviseDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_TxtBoxComments = new TextField()
            {
                Tag = "[TextField]Enter Comments:|$m_TxtBoxComments|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_TxtBoxComments);

            EnterCommentsST = new StaticText()
            {
                Tag = "[StaticText]Enter Comments:|$m_LblEnterComments|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterCommentsST);

            SelectNewRevisionGB = new GroupBox()
            {
                Tag = "[GroupBox]Select New Revision|$m_GroupBoxSelectRevision|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectNewRevisionGB);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[GroupBox]Select New Revision|$m_GroupBoxSelectRevision|#1/[RadioButton]$m_RadioBtnTeritiary|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[GroupBox]Select New Revision|$m_GroupBoxSelectRevision|#1/[RadioButton]$m_RadioBtnSecondary|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            M_RadioBtnPrimary = new RadioButton()
            {
                Tag = "[GroupBox]Select New Revision|$m_GroupBoxSelectRevision|#1/[RadioButton]$m_RadioBtnPrimary|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_RadioBtnPrimary);

            CurrentRevisionAStandardST = new StaticText()
            {
                Tag = "[StaticText]Current revision: A (Standard Alphabetic Format)|$m_LblCurrentRevision|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentRevisionAStandardST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_BtnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_BtnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            ReviseAcaddwgCTL = new TitleBar()
            {
                Tag = "[TitleBar]Revise - acad*|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReviseAcaddwgCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Revise - acad*|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultRevise|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Revise - acad*|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultRevise|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Revise - acad*|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
