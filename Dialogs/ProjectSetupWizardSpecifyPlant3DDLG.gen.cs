// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup Wizard (Page 4 of 6)|$CreateProjectWizard", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ProjectSetupWizardSpecifyPlant3DDLG : Pane
    {
        public  TextField M_editRelFilesDir;
        public  PushButton M_btnRelFilesDir;
        public  TextField M_edit3DDwgDir;
        public  PushButton M_btn3DDwgDir;
        public  PushButton M_btn3DSheetsDir;
        public  TextField M_edit3DSheetsDir;
        public  TextField M_editOrthoDir;
        public  PushButton M_btnOrthoDir;
        public  PushButton M_buttonCancel;
        public  PushButton M_buttonNext;
        public  PushButton M_buttonBack;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupWizardSpecifyPlant3DDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_editRelFilesDir = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]The wizard has collected enough information to create your project*|$page3DSettings/[TextField]Specify the directory where supporting files (such as spreadsheets or Word documents) are stored:|$m_editRelFilesDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editRelFilesDir);

            M_btnRelFilesDir = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]The wizard has collected enough information to create your project*|$page3DSettings/[PushButton]**[1]|$m_btnRelFilesDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnRelFilesDir);

            M_edit3DDwgDir = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]The wizard has collected enough information to create your project*|$page3DSettings/[TextField]Plant 3D model DWG file directory:|$m_edit3DDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_edit3DDwgDir);

            M_btn3DDwgDir = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]The wizard has collected enough information to create your project*|$page3DSettings/[PushButton]**[2]|$m_btn3DDwgDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btn3DDwgDir);

            M_btn3DSheetsDir = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]The wizard has collected enough information to create your project*|$page3DSettings/[PushButton]**[3]|$m_btn3DSheetsDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btn3DSheetsDir);

            M_edit3DSheetsDir = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]The wizard has collected enough information to create your project*|$page3DSettings/[TextField]Spec sheets directory:|$m_edit3DSheetsDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_edit3DSheetsDir);

            M_editOrthoDir = new TextField()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]The wizard has collected enough information to create your project*|$page3DSettings/[TextField]Orthographic output directory:|$m_editOrthoDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_editOrthoDir);

            M_btnOrthoDir = new PushButton()
            {
                Tag = "[Pane]$m_wizardSetup/[Pane]The wizard has collected enough information to create your project*|$page3DSettings/[PushButton]**[4]|$m_btnOrthoDir",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOrthoDir);

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
                Tag = "[TitleBar]Project Setup Wizard (Page 4 of 6)|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
