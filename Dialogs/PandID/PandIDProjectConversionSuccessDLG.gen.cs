// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Conversion Success", Parent = typeof(MainWin))]
    public partial class PandIDProjectConversionSuccessDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText YourProjectHasBeenSuccessf;

        partial void OnInitialize();

        public PandIDProjectConversionSuccessDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|#1|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            YourProjectHasBeenSuccessf = new StaticText()
            {
                Tag = "[StaticText]Your project has been successfully converted to SQL Express server database.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YourProjectHasBeenSuccessf);
        }
    }
}
