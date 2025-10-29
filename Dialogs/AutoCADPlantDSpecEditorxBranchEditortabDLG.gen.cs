// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]$SpecAndCatalogV2Window")]
    public partial class AutoCADPlantDSpecEditorxBranchEditortabDLG : SpecEditorDLG
    {
        public  TextField TextField1TF;
        public  Pane Pane3PANE;
        public  PushButton EditLegendPB;
        public  PushButton ApplyToSelectedCellsPB;

        partial void OnInitialize();

        public AutoCADPlantDSpecEditorxBranchEditortabDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TextField1TF = new TextField()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_BranchTableEditorV2|#1/[CustomWin]$UserControl_BranchTable|#1/[Pane]$CenterScrollViewer|#2/[TextField]#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            Pane3PANE = new Pane()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_BranchTableEditorV2|#1/[CustomWin]$UserControl_BranchTable|#1/[Pane]$BranchTableScrollBar|#1/[TextField]#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            EditLegendPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_BranchTableEditorV2|#1/[CustomWin]$UserControl_BranchTable|#1/[PushButton]$EditLegend|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditLegendPB);

            ApplyToSelectedCellsPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_BranchTableEditorV2|#1/[CustomWin]$UserControl_BranchTable|#1/[PushButton]$ApplyToTableButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyToSelectedCellsPB);
        }
    }
}
