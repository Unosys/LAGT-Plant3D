// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]IE WebBrowser|$IEWebBrowserDlg", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class LinceseGetStartedDLG : ProductTestSuite.CommonFiles.AdDialogBox
    {
        public  PushButton Select2PB;
        public  TextField ServerNameTF;
        public  PushButton DonePB;

        partial void OnInitialize();

        public LinceseGetStartedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Select2PB = new PushButton()
            {
                Tag = "[GroupBox]$IEWebBrowserDlg.browser|#1/[GroupBox]#1/[Pane]#1/[Pane]#1/[Pane]#1/[ListBox]#1/[ListBoxItem]#2/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Select2PB);

            ServerNameTF = new TextField()
            {
                Tag = "[GroupBox]$IEWebBrowserDlg.browser|#1/[GroupBox]#1/[Pane]#1/[Pane]#1/[Pane]#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerNameTF);

            DonePB = new PushButton()
            {
                Tag = "[GroupBox]$IEWebBrowserDlg.browser|#1/[GroupBox]#1/[Pane]#1/[Pane]#1/[Pane]#1/[PushButton]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DonePB);
        }
    }
}
