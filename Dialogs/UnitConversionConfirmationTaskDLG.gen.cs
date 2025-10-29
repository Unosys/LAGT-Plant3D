// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Unit conversion confirmation|#1", Parent = typeof(AutoCADPlant3DCatalogBuildSettingsDLG), GUIType = GuiType.UIA)]
    public partial class UnitConversionConfirmationTaskDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  PushButton Cancel;
        public  StaticText DoYouReallyWantST;
        public  TitleBar UnitConversionConfirmationCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public UnitConversionConfirmationTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            DoYouReallyWantST = new StaticText()
            {
                Tag = "[StaticText]Do you really want to do unit conversion?|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoYouReallyWantST);

            UnitConversionConfirmationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Unit conversion confirmation|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UnitConversionConfirmationCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Unit conversion confirmation|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
