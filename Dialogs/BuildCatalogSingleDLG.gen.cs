// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Build Catalog|$Window_1", Parent = typeof(Desktop), GUIType = GuiType.UIA)]
    public partial class BuildCatalogSingleDLG : Autodesk.GUIHarness.MainWin
    {
        public  PushButton SaveAsNewPB;
        public  PushButton AddToExistingPB;
        public  PushButton ContentPackPB;

        partial void OnInitialize();

        public BuildCatalogSingleDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SaveAsNewPB = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#1/[CustomWin]Catalog|$ID_CatalogPanel|#1/[ListBox]Catalog|$mRibbonPanelView|#1/[ListViewItem]#2/[CustomWin]Save*|$ID_SaveAsNew_RibbonItemControl|#1/[PushButton]$ID_SaveAsNew",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsNewPB);

            AddToExistingPB = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#1/[CustomWin]Catalog|$ID_CatalogPanel|#1/[ListBox]Catalog|$mRibbonPanelView|#1/[ListViewItem]#4/[CustomWin]Add to*|$ID_AddToExisting_RibbonItemControl|#1/[PushButton]$ID_AddToExisting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddToExistingPB);

            ContentPackPB = new PushButton()
            {
                Tag = "[ListBox]#2/[ListViewItem]#1/[CustomWin]ID_TabHome|$ID_TabHome_PanelBarScrollViewer|#1/[ListBox]$mMainTabPanels|#1/[ListViewItem]#1/[CustomWin]Catalog|$ID_CatalogPanel|#1/[ListBox]Catalog|$mRibbonPanelView|#1/[ListViewItem]#6/[CustomWin]Content*|$ID_ContentPack_RibbonItemControl|#1/[PushButton]$ID_ContentPack",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentPackPB);
        }
    }
}
