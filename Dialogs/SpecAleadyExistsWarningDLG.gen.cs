// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Warning|#1", Parent = typeof(ProjManUndocked), GUIType = GuiType.WIN32)]
    public partial class SpecAleadyExistsWarningDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  StaticText TheSpecFileAlreayST;

        partial void OnInitialize();

        public SpecAleadyExistsWarningDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YesPB = new PushButton()
            {
                Tag = "[PushButton]Yes|$6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[PushButton]No|$7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            TheSpecFileAlreayST = new StaticText()
            {
                Tag = "[StaticText]The spec file alreay exists in the project specifications folder*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheSpecFileAlreayST);
        }
    }
}
