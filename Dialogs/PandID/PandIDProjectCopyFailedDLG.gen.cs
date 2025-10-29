// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Copy Failed", Parent = typeof(MainWin))]
    public partial class PandIDProjectCopyFailedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText PnPCompletionStatusDatabaseCr;

        partial void OnInitialize();

        public PandIDProjectCopyFailedDLG()
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

            PnPCompletionStatusDatabaseCr = new StaticText()
            {
                Tag = "[StaticText]PnPCompletionStatus.DatabaseCreationFailed|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPCompletionStatusDatabaseCr);
        }
    }
}
