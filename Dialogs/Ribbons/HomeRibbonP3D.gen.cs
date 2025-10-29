// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]Ribbon|$59419/[CustomWin]Ribbon|$16719/[CustomWin]Ribbon|$7/[Pane]#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class HomeRibbonP3D : RibbonDialogClassP3D
    {
        public  PartInsertionPanelClass PartInsertionPanel;

        partial void OnInitialize();

        public HomeRibbonP3D()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PartInsertionPanel = new PartInsertionPanelClass()
            {
                Tag = "[CustomWin]$PNP.ID_TabHomePiping_PanelBarScrollViewer/[CustomWin]Part Insertion|$ID_PanelPartInsertion",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PartInsertionPanel);
        }

        public partial class PartInsertionPanelClass : CustomWin
        {
            public PushButton RoutePipePB;
            public PopupList LineNumberComboPL;

            partial void OnInitialize();

            public PartInsertionPanelClass()
            {
                InitializeComponent();
                OnInitialize();
            }

            private void InitializeComponent()
            {
                Tag = "[CustomWin]$PNP.ID_TabHomePiping_PanelBarScrollViewer/[CustomWin]Part Insertion|$ID_PanelPartInsertion";
                ParentType = this.GetType();

                RoutePipePB = new PushButton()
                {
                    Tag = "[CustomWin]$ID_PP_ROUTE_PIPE_RibbonItemControl/[PushButton]$ID_PP_ROUTE_PIPE",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(RoutePipePB);

                LineNumberComboPL = new PopupList()
                {
                    Tag = "[CustomWin]Line Number Combo|$pnpLineNumberCombo_RibbonItemControl/[PopupList]Line Number Combo|$pnpLineNumberCombo",
                    ParentType = this.GetType(),
                    Parent = this
                };
                DeclaredChildren.Add(LineNumberComboPL);
            }
        }
    }
}
