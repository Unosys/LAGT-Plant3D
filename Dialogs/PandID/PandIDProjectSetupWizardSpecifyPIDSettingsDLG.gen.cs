// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupWizardSpecifyPIDSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnPIDDwgDir;
        public  PushButton M_buttonBack;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  TextField M_editPIDDwgDir;
        public  ListBox M_listboxTemplate;
        public  StaticText M_NotesLbl;
        public  StaticText M_PIDDwgsDirLbl;
        public  StaticText M_PIDStandardsLbl;
        public  CustomWin M_wizardSetup;
        public  GroupBox PagePIDSettings;

        partial void OnInitialize();

        public PandIDProjectSetupWizardSpecifyPIDSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnPIDDwgDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnPIDDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnPIDDwgDir);

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

            M_buttonNext = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup|#1/[PushButton]$m_buttonNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_buttonNext);

            M_editPIDDwgDir = new TextField()
            {
                Tag = "[TextField]$m_editPIDDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editPIDDwgDir);

            M_listboxTemplate = new ListBox()
            {
                Tag = "[ListBox]$m_listboxTemplate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_listboxTemplate);

            M_NotesLbl = new StaticText()
            {
                Tag = "[StaticText]$m_NotesLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_NotesLbl);

            M_PIDDwgsDirLbl = new StaticText()
            {
                Tag = "[StaticText]$m_PIDDwgsDirLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_PIDDwgsDirLbl);

            M_PIDStandardsLbl = new StaticText()
            {
                Tag = "[StaticText]$m_PIDStandardsLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_PIDStandardsLbl);

            M_wizardSetup = new CustomWin()
            {
                Tag = "[CustomWin]$m_wizardSetup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_wizardSetup);

            PagePIDSettings = new GroupBox()
            {
                Tag = "[GroupBox]$pagePIDSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PagePIDSettings);
        }
    }
}
