// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Conversion Failed", Parent = typeof(MainWin))]
    public partial class PandIDProjectConversionFailedLockDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText FailToGetAnExclusiveLock;

        partial void OnInitialize();

        public PandIDProjectConversionFailedLockDLG()
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
                Tag = "[StaticText]Fail to get an exclusive lock for file ?ProcessPower.dcf?|#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FailToGetAnExclusiveLock);
        }
    }
}
