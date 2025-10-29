// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]UnableToOpenProjectDLG", Parent = typeof(Plant3D))]
    public partial class UnableToOpenProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  DirectUIHWND1Class DirectUIHWND1;

        partial void OnInitialize();

        public UnableToOpenProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DirectUIHWND1 = new DirectUIHWND1Class()
            {
                Tag = "[CustomWin][DirectUIHWND]$0|[DirectUIHWND]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DirectUIHWND1);
        }

        public partial class DirectUIHWND1Class : CustomWin
        {
            public CtrlNotifySink1Class CtrlNotifySink1;

            partial void OnInitialize();

            public DirectUIHWND1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][DirectUIHWND]$0|[DirectUIHWND]#1";
                ParentType = this.GetType();

                CtrlNotifySink1 = new CtrlNotifySink1Class()
                {
                    Tag = "[CustomWin][CtrlNotifySink]$0|[CtrlNotifySink]#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CtrlNotifySink1);
            }
        }

        public partial class CtrlNotifySink1Class : CustomWin
        {
            public PushButton OK;

            partial void OnInitialize();

            public CtrlNotifySink1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][CtrlNotifySink]$0|[CtrlNotifySink]#1";
                ParentType = this.GetType();

                OK = new PushButton()
                {
                    Tag = "[PushButton]$0|OK|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(OK);
            }
        }
    }
}
