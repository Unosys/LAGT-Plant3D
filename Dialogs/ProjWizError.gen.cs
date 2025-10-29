// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(ProjectSetupWizardDLG), GUIType = GuiType.UIA)]
    public partial class ProjWizError : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText DuplicateProjectNamesAreST;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjWizError()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            DuplicateProjectNamesAreST = new StaticText()
            {
                Tag = "[StaticText]Duplicate project names are not allowed in the specified project directory*|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DuplicateProjectNamesAreST);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Error|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
