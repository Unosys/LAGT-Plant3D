// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Update Specs From Catalogs Settings|$SpecUpdateSettingWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class UpdateSpecsFromCatalogsSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public UpdateSpecsFromCatalogsSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$OkBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
