// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Style can't be deleted", Parent = typeof(Pane))]
    public partial class PandIDStyleCanTBeDeletedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText CentrifugalBlowerStyleIs;

        partial void OnInitialize();

        public PandIDStyleCanTBeDeletedDLG()
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

            CentrifugalBlowerStyleIs = new StaticText()
            {
                Tag = "[StaticText]#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CentrifugalBlowerStyleIs);
        }
    }
}
