// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error")]
    public partial class ErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText SpecifiedDrawingTemplateFil;

        partial void OnInitialize();

        public ErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]#1|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]#1|[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            SpecifiedDrawingTemplateFil = new StaticText()
            {
                Tag = "[StaticText]#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifiedDrawingTemplateFil);
        }
    }
}
