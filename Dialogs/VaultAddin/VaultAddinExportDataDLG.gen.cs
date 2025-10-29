// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Export", Parent = typeof(Plant3D))]
    public partial class VaultAddinExportDataDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  DirectUIHWND1Class DirectUIHWND1;

        partial void OnInitialize();

        public VaultAddinExportDataDLG()
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
            public CtrlNotifySink2Class CtrlNotifySink2;

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
                    Tag = "[CustomWin][CtrlNotifySink]$0[1]|[CtrlNotifySink]#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CtrlNotifySink1);

                CtrlNotifySink2 = new CtrlNotifySink2Class()
                {
                    Tag = "[CustomWin][CtrlNotifySink]$0[2]|[CtrlNotifySink]#2",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(CtrlNotifySink2);
            }
        }

        public partial class CtrlNotifySink1Class : CustomWin
        {
            public PushButton Cancel;

            partial void OnInitialize();

            public CtrlNotifySink1Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][CtrlNotifySink]$0[1]|[CtrlNotifySink]#1";
                ParentType = this.GetType();

                Cancel = new PushButton()
                {
                    Tag = "[PushButton]$0|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Cancel);
            }
        }

        public partial class CtrlNotifySink2Class : CustomWin
        {
            public PushButton Export;

            partial void OnInitialize();

            public CtrlNotifySink2Class()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin][CtrlNotifySink]$0[2]|[CtrlNotifySink]#2";
                ParentType = this.GetType();

                Export = new PushButton()
                {
                    Tag = "[PushButton]$0|#1",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(Export);
            }
        }
    }
}
