// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]No New Validation Errors Detected", Parent = typeof(Plant3D))]
    public partial class PandIDNoNewValidationErrorsDetecDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DirectUIHWND1;
        public  CustomWin CtrlNotifySink1;
        public  PushButton OKPB;

        partial void OnInitialize();

        public PandIDNoNewValidationErrorsDetecDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DirectUIHWND1 = new CustomWin()
            {
                Tag = "[DirectUIHWND]$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DirectUIHWND1);

            CtrlNotifySink1 = new CustomWin()
            {
                Tag = "[CtrlNotifySink]$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CtrlNotifySink1);

            OKPB = new PushButton()
            {
                Tag = "$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
