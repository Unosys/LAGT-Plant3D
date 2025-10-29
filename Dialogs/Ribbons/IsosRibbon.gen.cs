// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]Ribbon|$59419/[CustomWin]Ribbon|$16719/[CustomWin]Ribbon|$7/[Pane]#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class IsosRibbon : RibbonDialogClassP3D
    {
        public  ExportPanelClass ExportPanel;

        partial void OnInitialize();

        public IsosRibbon()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ExportPanel = new ExportPanelClass()
            {
                Tag = "[CustomWin]$PNP.ID_TabIsometrics_PanelBarScrollViewer/[CustomWin]Export|$ID_PanelPCFExport",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportPanel);
        }

        public partial class ExportPanelClass : CustomWin
        {
            public PushButton PCFExportPB;

            partial void OnInitialize();

            public ExportPanelClass()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin]$PNP.ID_TabIsometrics_PanelBarScrollViewer/[CustomWin]Export|$ID_PanelPCFExport";
                ParentType = this.GetType();

                PCFExportPB = new PushButton()
                {
                    Tag = "[CustomWin]$ID_PP_PCFEXPORT_RibbonItemControl/[PushButton]$ID_PP_PCFEXPORT",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(PCFExportPB);
            }
        }
    }
}
