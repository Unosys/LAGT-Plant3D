// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Error", Parent = typeof(Pane))]
    public partial class PandIDAddRowErrorMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;

        partial void OnInitialize();

        public PandIDAddRowErrorMSG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
