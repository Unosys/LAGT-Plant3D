// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(MainWin))]
    public partial class PandIDProjectXMLFileErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText TheFileYouSelectedIsNotA;

        partial void OnInitialize();

        public PandIDProjectXMLFileErrorDLG()
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

            TheFileYouSelectedIsNotA = new StaticText()
            {
                Tag = "[StaticText]The file you selected is not a AutoCAD Plant 3D Project XML file. Please try again.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheFileYouSelectedIsNotA);
        }
    }
}
