// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SetUserDialog", Parent = typeof(Desktop))]
    public partial class JobProcessor_FirstSettings : Pane
    {
        public  TextField UserNameTF;
        public  TextField ServerTF;
        public  PushButton OKPB;

        partial void OnInitialize();

        public JobProcessor_FirstSettings()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            UserNameTF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel1/[TextField]$mUserNameTb",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserNameTF);

            ServerTF = new TextField()
            {
                Tag = "[Pane]$tableLayoutPanel1/[TextField]$mServerTb",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ServerTF);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$mOkBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
