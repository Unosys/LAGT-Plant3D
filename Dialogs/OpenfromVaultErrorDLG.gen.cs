// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OpenfromVaultErrorDLG : Window
    {
        public  PushButton OKPB;
        public  StaticText CouldNotLoadFileST;
        public  PushButton Close1PB;

        partial void OnInitialize();

        public OpenfromVaultErrorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CouldNotLoadFileST = new StaticText()
            {
                Tag = "[StaticText]Could not load file or assembly 'Autodesk*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CouldNotLoadFileST);

            Close1PB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);
        }
    }
}
