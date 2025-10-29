// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(Plant3D))]
    public partial class StyleAlreadyExistsInDrawingErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText StyleTestAlreadyExistsInD;

        partial void OnInitialize();

        public StyleAlreadyExistsInDrawingErrorDLG()
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

            StyleTestAlreadyExistsInD = new StaticText()
            {
                Tag = "[StaticText]Style Test already exists in drawing!|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleTestAlreadyExistsInD);
        }
    }
}
