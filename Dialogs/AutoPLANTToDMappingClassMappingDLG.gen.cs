// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]AutoPLANT to Plant 3D Mapping|$SpecMigration_EditMapping", Parent = typeof(SpecEditorDLG), GUIType = GuiType.UIA)]
    public partial class AutoPLANTToDMappingClassMappingDLG : Window
    {
        public  StaticText ClassMappingST;
        public  StaticText GeometryMappingST;
        public  StaticText PropertyTranslationST;
        public  PushButton AddScriptButton;
        public  PushButton PushButton1PB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public AutoPLANTToDMappingClassMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClassMappingST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$ClassMappings/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassMappingST);

            GeometryMappingST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$GeomMappings/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeometryMappingST);

            PropertyTranslationST = new StaticText()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]$UtilityMappings/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTranslationST);

            AddScriptButton = new PushButton()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Geometry Mapping|$GeomMappings|#3/[CustomWin]$SpecMigration_EditClassMapping|#1/[PushButton]+[2]|$AddScriptButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddScriptButton);

            PushButton1PB = new PushButton()
            {
                Tag = "[PageList]$MainTabControl|#1/[Window]Class Mapping|$ClassMappings|#3/[CustomWin]$SpecMigration_EditClassMapping|#1/[PushButton]+|$AddButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
