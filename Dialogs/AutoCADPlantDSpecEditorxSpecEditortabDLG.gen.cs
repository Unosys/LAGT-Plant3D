// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Spec Editor for AutoCAD Plant 3D *|$SpecAndCatalogV2Window")]
    public partial class AutoCADPlantDSpecEditorxSpecEditortabDLG : SpecEditorDLG
    {
        public  PushButton FamilyPB;
        public  PushButton SizePB;
        public  Window PartFamilyPropertiesWIN;
        public  StaticText PartFamilyPropertiesST;
        public  Window PartSizePropertiesWIN;
        public  StaticText PartSizeProperties1ST;

        partial void OnInitialize();

        public AutoCADPlantDSpecEditorxSpecEditortabDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FamilyPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogComponents|#2/[PushButton]$FamilyTab|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FamilyPB);

            SizePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogComponents|#2/[PushButton]$SizeTab|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizePB);

            PartFamilyPropertiesWIN = new Window()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[PageList]$PropertyTab|#1/[Window]Part Family Properties|$PartFamilyPropertiesTab|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartFamilyPropertiesWIN);

            PartFamilyPropertiesST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[PageList]$PropertyTab|#1/[Window]Part Family Properties|$PartFamilyPropertiesTab|#1/[StaticText]Part Family Properties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartFamilyPropertiesST);

            PartSizePropertiesWIN = new Window()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[PageList]$PropertyTab|#1/[Window]Part Size Properties|$PartSizePropertiesTab|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartSizePropertiesWIN);

            PartSizeProperties1ST = new StaticText()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[PageList]$PropertyTab|#1/[Window]Part Size Properties|$PartSizePropertiesTab|#2/[StaticText]Part Size Properties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartSizeProperties1ST);
        }
    }
}
