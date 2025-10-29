// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Copy Failed", Parent = typeof(MainWin))]
    public partial class PandIDProjectCopyFailedLockDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText FailToGetAnExclusiveLock;

        partial void OnInitialize();

        public PandIDProjectCopyFailedLockDLG()
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

            FailToGetAnExclusiveLock = new StaticText()
            {
                Tag = "[StaticText]Fail to get an exclusive lock for file ?PIP_Metric_PnIdPart.xml?|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FailToGetAnExclusiveLock);
        }
    }
}
