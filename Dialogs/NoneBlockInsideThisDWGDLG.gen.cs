// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]#1", Parent = typeof(AutoCADPlant3DCatalogBuilderApplicationDLG), GUIType = GuiType.UIA)]
    public partial class NoneBlockInsideThisDWGDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText NoneBlockInsideThisST;
        public  TitleBar TitleBarCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public NoneBlockInsideThisDWGDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            NoneBlockInsideThisST = new StaticText()
            {
                Tag = "[StaticText]None block inside this dwg agrees with Number of Port setting*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoneBlockInsideThisST);

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
