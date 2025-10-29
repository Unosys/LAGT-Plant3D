// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]CSV to Plant 3D Mapping|$SpecMigration_EditMapping|#1", Parent = typeof(MainWin))]
    public partial class CsvToPlantDMappingClassMappingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  Window ClassMappingWIN;
        public  Window GeometryMappingWIN;
        public  Window PropertyTranslationWIN;

        partial void OnInitialize();

        public CsvToPlantDMappingClassMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClassMappingWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$ClassMappings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassMappingWIN);

            GeometryMappingWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$GeomMappings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeometryMappingWIN);

            PropertyTranslationWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$UtilityMappings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTranslationWIN);
        }
    }
}
