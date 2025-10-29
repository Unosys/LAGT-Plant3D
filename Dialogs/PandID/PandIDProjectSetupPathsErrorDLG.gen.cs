// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(Pane))]
    public partial class PandIDProjectSetupPathsErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText SpecifiedProjectDWGDirector;

        partial void OnInitialize();

        public PandIDProjectSetupPathsErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2|@(144,71)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]$20|[Icon]@(27,27)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            SpecifiedProjectDWGDirector = new StaticText()
            {
                Tag = "[StaticText]Specified Project DWG Directory doesn't exist|$65535|@(171,27)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifiedProjectDWGDirector);
        }
    }
}
