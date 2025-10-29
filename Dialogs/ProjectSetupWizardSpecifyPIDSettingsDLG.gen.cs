// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup Wizard (Page 3 of 6)|$CreateProjectWizard", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupWizardSpecifyPIDSettingsDLG : Pane
    {
        public  ListBox M_listboxTemplate;
        public  ListBoxItem PIPLBI;
        public  ListBoxItem ISALBI;
        public  PushButton M_btnPIDDwgDir;
        public  TextField M_editPIDDwgDir;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  PushButton M_buttonBack;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyPIDSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_listboxTemplate = new ListBox()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pagePIDSettings/[ListBox]Select the PID symbology standard to be used:|$m_listboxTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listboxTemplate);

            PIPLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pagePIDSettings/[ListBox]Select the PID symbology standard to be used:|$m_listboxTemplate/[ListBoxItem]PIP",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIPLBI);

            ISALBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pagePIDSettings/[ListBox]Select the PID symbology standard to be used:|$m_listboxTemplate/[ListBoxItem]ISA",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ISALBI);

            M_btnPIDDwgDir = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pagePIDSettings/[PushButton]**|$m_btnPIDDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnPIDDwgDir);

            M_editPIDDwgDir = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]$pagePIDSettings/[TextField]Specify the directory where PID drawings are stored:|$m_editPIDDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editPIDDwgDir);

            M_buttonCancel = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]Cancel|$m_buttonCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonCancel);

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]Next >>|$m_buttonNext",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            M_buttonBack = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[PushButton]<< Back|$m_buttonBack",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonBack);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup Wizard (Page 3 of 6)|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
