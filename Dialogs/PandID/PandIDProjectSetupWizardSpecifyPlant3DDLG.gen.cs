// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$CreateProjectWizard", Parent = typeof(Plant3D))]
    public partial class PandIDProjectSetupWizardSpecifyPlant3DDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btn3DDwgDir;
        public  PushButton M_btn3DSheetsDir;
        public  PushButton M_btnOrthoDir;
        public  PushButton M_btnRelFilesDir;
        public  PushButton M_buttonBack;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  TextField M_edit3DDwgDir;
        public  TextField M_edit3DSheetsDir;
        public  TextField M_editOrthoDir;
        public  TextField M_editRelFilesDir;
        public  StaticText M_orthoDirLbl;
        public  StaticText M_PipingDwgsDirLbl;
        public  StaticText M_relFilesLbl;
        public  StaticText M_SpecSheetsDirLbl;
        public  CustomWin M_wizardSetup;
        public  GroupBox Page3DSettings;

        partial void OnInitialize();

        public PandIDProjectSetupWizardSpecifyPlant3DDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btn3DDwgDir = new PushButton()
            {
                Tag = "[PushButton]$m_btn3DDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btn3DDwgDir);

            M_btn3DSheetsDir = new PushButton()
            {
                Tag = "[PushButton]$m_btn3DSheetsDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btn3DSheetsDir);

            M_btnOrthoDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnOrthoDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOrthoDir);

            M_btnRelFilesDir = new PushButton()
            {
                Tag = "[PushButton]$m_btnRelFilesDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRelFilesDir);

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

            M_edit3DDwgDir = new TextField()
            {
                Tag = "[TextField]$m_edit3DDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_edit3DDwgDir);

            M_edit3DSheetsDir = new TextField()
            {
                Tag = "[TextField]$m_edit3DSheetsDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_edit3DSheetsDir);

            M_editOrthoDir = new TextField()
            {
                Tag = "[TextField]$m_editOrthoDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editOrthoDir);

            M_editRelFilesDir = new TextField()
            {
                Tag = "[TextField]$m_editRelFilesDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editRelFilesDir);

            M_orthoDirLbl = new StaticText()
            {
                Tag = "[StaticText]$m_orthoDirLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_orthoDirLbl);

            M_PipingDwgsDirLbl = new StaticText()
            {
                Tag = "[StaticText]$m_PipingDwgsDirLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_PipingDwgsDirLbl);

            M_relFilesLbl = new StaticText()
            {
                Tag = "[StaticText]$m_relFilesLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_relFilesLbl);

            M_SpecSheetsDirLbl = new StaticText()
            {
                Tag = "[StaticText]$m_SpecSheetsDirLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_SpecSheetsDirLbl);

            M_wizardSetup = new CustomWin()
            {
                Tag = "[CustomWin]$m_wizardSetup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_wizardSetup);

            Page3DSettings = new GroupBox()
            {
                Tag = "[GroupBox]$page3DSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Page3DSettings);
        }
    }
}
