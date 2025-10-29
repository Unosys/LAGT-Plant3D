// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Catalog Properties|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUtilityCatalogPartsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Window GeneralPropertiesWIN;
        public  Window SizesWIN;

        partial void OnInitialize();

        public SpecUtilityCatalogPartsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            GeneralPropertiesWIN = new Window()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]$TabItem_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralPropertiesWIN);

            SizesWIN = new Window()
            {
                Tag = "[PageList]$PropertiesTabControl|#1/[Window]$TabItem_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizesWIN);
        }
    }
}
