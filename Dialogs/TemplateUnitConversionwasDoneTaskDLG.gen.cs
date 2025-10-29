// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]#1", Parent = typeof(AutoCADPlant3DCatalogBuildSettingsDLG), GUIType = GuiType.UIA)]
    public partial class TemplateUnitConversionwasDoneTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText TemplateUnitConversionWasST;
        public  TitleBar TitleBarCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public TemplateUnitConversionwasDoneTaskDLG()
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

            TemplateUnitConversionWasST = new StaticText()
            {
                Tag = "[StaticText]Template unit conversion was done|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TemplateUnitConversionWasST);

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
