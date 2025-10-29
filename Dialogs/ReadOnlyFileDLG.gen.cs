// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DwgOfflineReadOnly", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class ReadOnlyFileDLG : Pane
    {
        public  PushButton HelpPB;
        public  PushButton OKPB;
        public  StaticText ThisFileIsReadonlyST;
        public  TitleBar ReadOnlyFileCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReadOnlyFileDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]$btnHelp|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ThisFileIsReadonlyST = new StaticText()
            {
                Tag = "[StaticText]$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisFileIsReadonlyST);

            ReadOnlyFileCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadOnlyFileCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]$DwgOfflineReadOnly|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]$DwgOfflineReadOnly|#1/[MenuItem]$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
