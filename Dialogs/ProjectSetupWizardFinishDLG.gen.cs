// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup Wizard (Page 6 of 6)|$CreateProjectWizard", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupWizardFinishDLG : Pane
    {
        public  CheckBox M_checkboxLaunchSetupDlg;
        public  PushButton M_buttonFinish;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonBack;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardFinishDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_checkboxLaunchSetupDlg = new CheckBox()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]Note: All symbols will be drawn in inches*|$pageFinish/[CheckBox]Edit additional project settings after creating project|$m_checkboxLaunchSetupDlg",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_checkboxLaunchSetupDlg);

            M_buttonFinish = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]Finish|$m_buttonFinish",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonFinish);

            M_buttonCancel = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]Cancel|$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonBack = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]<< Back|$m_buttonBack",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonBack);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 6 of 6)|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
