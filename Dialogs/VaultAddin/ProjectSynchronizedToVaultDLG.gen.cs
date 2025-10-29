// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Synchronized to Vault", Parent = typeof(Plant3D))]
    public partial class ProjectSynchronizedToVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  DirectUIHWND1Class DirectUIHWND1;

        partial void OnInitialize();

        public ProjectSynchronizedToVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DirectUIHWND1 = new DirectUIHWND1Class()
            {
                Tag = "[DirectUIHWND]$0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DirectUIHWND1);
        }

        public partial class DirectUIHWND1Class : CustomWin
        {
            public CtrlNotifySink1Class CtrlNotifySink1;
            public CtrlNotifySink2Class CtrlNotifySink2;

            partial void OnInitialize();

            public DirectUIHWND1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[DirectUIHWND]$0";
                ParentType = this.GetType();

                CtrlNotifySink1 = new CtrlNotifySink1Class()
                {
                    Tag = "[CtrlNotifySink]$0[1]",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CtrlNotifySink1);

                CtrlNotifySink2 = new CtrlNotifySink2Class()
                {
                    Tag = "[CtrlNotifySink]$0[2]",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CtrlNotifySink2);
            }
        }

        public partial class CtrlNotifySink1Class : CustomWin
        {
            public CustomWin ReferToTheLogfileAtAHre;

            partial void OnInitialize();

            public CtrlNotifySink1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CtrlNotifySink]$0[1]";
                ParentType = this.GetType();

                ReferToTheLogfileAtAHre = new CustomWin()
                {
                    Tag = "[SysLink]$0",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(ReferToTheLogfileAtAHre);
            }
        }

        public partial class CtrlNotifySink2Class : CustomWin
        {
            public PushButton OK;

            partial void OnInitialize();

            public CtrlNotifySink2Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CtrlNotifySink]$0[2]";
                ParentType = this.GetType();

                OK = new PushButton()
                {
                    Tag = "$0",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(OK);
            }
        }
    }
}
