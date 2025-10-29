// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]LightingLightingUnitsMsgDLG", Parent = typeof(Plant3D))]
    public partial class LightingLightingUnitsMsgDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DirectUIHWND;
        public  CustomWin CtrlNotifySink;
        public  PushButton OK;

        partial void OnInitialize();

        public LightingLightingUnitsMsgDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DirectUIHWND = new CustomWin()
            {
                Tag = "[CustomWin]$DirectUIHWND",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DirectUIHWND);

            CtrlNotifySink = new CustomWin()
            {
                Tag = "[CustomWin]$CtrlNotifySink",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CtrlNotifySink);

            OK = new PushButton()
            {
                Tag = "[PushButton]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);
        }
    }
}
