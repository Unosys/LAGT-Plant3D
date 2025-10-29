// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(MainWin))]
    public partial class PandIDPMUSQLServerInstanceErrorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText SQLServerInstanceIsNotSpe;

        partial void OnInitialize();

        public PandIDPMUSQLServerInstanceErrorDLG()
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

            SQLServerInstanceIsNotSpe = new StaticText()
            {
                Tag = "[StaticText]SQL Server instance is not specified.|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SQLServerInstanceIsNotSpe);
        }
    }
}
