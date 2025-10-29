// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]Ribbon|$59419/[CustomWin]Ribbon|$16719/[CustomWin]Ribbon|$7/[Pane]#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class StructureRibbon : RibbonDialogClassP3D
    {
        public  ExportPanelClass ExportPanel;

        partial void OnInitialize();

        public StructureRibbon()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ExportPanel = new ExportPanelClass()
            {
                Tag = "[CustomWin]$PNP.ID_TabStructural_PanelBarScrollViewer/[CustomWin]Export|$ID_PanelStructure_Export",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportPanel);
        }

        public partial class ExportPanelClass : CustomWin
        {
            public PushButton AdvanceSteelXMLExportPB;

            partial void OnInitialize();

            public ExportPanelClass()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin]$PNP.ID_TabStructural_PanelBarScrollViewer/[CustomWin]Export|$ID_PanelStructure_Export";
                ParentType = this.GetType();

                AdvanceSteelXMLExportPB = new PushButton()
                {
                    Tag = "[CustomWin]$STRUCT_ADVANCESTEEL_EXPORT_RibbonItemControl/[PushButton]$STRUCT_ADVANCESTEEL_EXPORT",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(AdvanceSteelXMLExportPB);
            }
        }
    }
}
