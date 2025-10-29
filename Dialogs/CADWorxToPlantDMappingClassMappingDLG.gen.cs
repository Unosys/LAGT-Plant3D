// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]CADWorx to Plant 3D Mapping|$SpecMigration_EditMapping", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class CADWorxToPlantDMappingClassMappingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  Window ClassMappingWIN;
        public  StaticText ClassMappingST;
        public  Window GeometryMappingWIN;
        public  StaticText GeometryMappingST;
        public  Window PropertyTranslationWIN;
        public  StaticText PropertyTranslationST;

        partial void OnInitialize();

        public CADWorxToPlantDMappingClassMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]CADWorx to Plant 3D Mapping|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

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

            ClassMappingST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$ClassMappings|#1/[StaticText]Class Mapping|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassMappingST);

            GeometryMappingWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$GeomMappings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeometryMappingWIN);

            GeometryMappingST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$GeomMappings|#2/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeometryMappingST);

            PropertyTranslationWIN = new Window()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$UtilityMappings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTranslationWIN);

            PropertyTranslationST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$UtilityMappings|#3/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTranslationST);
        }
    }
}
