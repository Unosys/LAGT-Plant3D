// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]#1", Parent = typeof(SelectExcelFilesValidatingDLG), GUIType = GuiType.UIA)]
    public partial class NoExcelMSGDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  StaticText NoExcelInstallationWasST;
        public  TitleBar TitleBarCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public NoExcelMSGDLG()
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

            NoExcelInstallationWasST = new StaticText()
            {
                Tag = "[StaticText]No Excel installation was found|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoExcelInstallationWasST);

            TitleBarCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBarCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
