// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(Plant3D))]
    public partial class ErrorCannotOpenCADWorxDataFileDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OkPB;
        public  StaticText CannotOpenSpecDataFileTlb;

        partial void OnInitialize();

        public ErrorCannotOpenCADWorxDataFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OkPB = new PushButton()
            {
                Tag = "$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OkPB);

            CannotOpenSpecDataFileTlb = new StaticText()
            {
                Tag = "$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CannotOpenSpecDataFileTlb);
        }
    }
}
