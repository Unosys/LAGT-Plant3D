// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupWizardFinishDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_buttonBack;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonFinish;
        public  CheckBox M_checkboxLaunchSetupDlg;
        public  StaticText M_finishPageLbl;
        public  CustomWin M_wizardSetup;
        public  GroupBox PageFinish;

        partial void OnInitialize();

        public PandIDProjectSetupWizardFinishDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_buttonBack = new PushButton()
            {
                Tag = "[PushButton]$m_buttonBack",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonBack);

            M_buttonCancel = new PushButton()
            {
                Tag = "[PushButton]$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonFinish = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]Finish|$m_buttonFinish|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonFinish);

            M_checkboxLaunchSetupDlg = new CheckBox()
            {
                Tag = "[CheckBox]$m_checkboxLaunchSetupDlg",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkboxLaunchSetupDlg);

            M_finishPageLbl = new StaticText()
            {
                Tag = "[StaticText]$m_finishPageLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_finishPageLbl);

            M_wizardSetup = new CustomWin()
            {
                Tag = "[CustomWin]$m_wizardSetup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_wizardSetup);

            PageFinish = new GroupBox()
            {
                Tag = "[GroupBox]$pageFinish",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageFinish);
        }
    }
}
