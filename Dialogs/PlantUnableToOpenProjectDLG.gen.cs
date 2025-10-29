// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Unable to Open Project", Parent = typeof(Plant3D))]
    public partial class PlantUnableToOpenProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DirectUIHWND1;
        public  CustomWin CtrlNotifySink1;
        public  PushButton OK;

        partial void OnInitialize();

        public PlantUnableToOpenProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DirectUIHWND1 = new CustomWin()
            {
                Tag = "[CustomWin][DirectUIHWND]$0|[DirectUIHWND]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DirectUIHWND1);

            CtrlNotifySink1 = new CustomWin()
            {
                Tag = "[CustomWin][CtrlNotifySink]$0|[CtrlNotifySink]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CtrlNotifySink1);

            OK = new PushButton()
            {
                Tag = "[PushButton]$0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
