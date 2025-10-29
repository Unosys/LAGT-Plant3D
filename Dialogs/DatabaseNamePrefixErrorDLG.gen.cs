// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Database Name Prefix Test", Parent = typeof(Plant3D))]
    public partial class DatabaseNamePrefixErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  CustomWin Icon1;
        public  StaticText TheDatabasePrefixCannotCon;

        partial void OnInitialize();

        public DatabaseNamePrefixErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$2",
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

            TheDatabasePrefixCannotCon = new StaticText()
            {
                Tag = "[StaticText]The database prefix cannot contain the following characters:??\\ ? : ? ? ? < > ? =|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheDatabasePrefixCannotCon);
        }
    }
}
