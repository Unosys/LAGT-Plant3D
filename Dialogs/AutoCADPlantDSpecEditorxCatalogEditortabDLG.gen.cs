// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]$SpecAndCatalogV2Window", Parent = typeof(Desktop))]
    public partial class AutoCADPlantDSpecEditorxCatalogEditortabDLG : SpecEditorDLG
    {
        public  PushButton SavePB;
        public  PushButton FamilyPB;
        public  PushButton SizePB;
        public  PushButton PropertyEditorPB;
        public  PushButton SaveToCatalogPB;
        public  PushButton ManageSizePB;
        public  PushButton RemoveFromCatalogPB;
        public  PushButton CreateComponentPB;
        public  PushButton DropdownPB;
        public  PushButton DuplicateComponentPB;
        public  PushButton PushButton31PB;
        public  PushButton PopUpButton;
        public  PushButton ImportFromExcel;
        public  Image SizePreivewImage;
        public  PushButton AddPB;
        public  PushButton DuplicatePB;
        public  PushButton RemovePB;
        public  TextField MatchingPipeODTF;
        public  ScrollBar ScrollBar1SB;

        partial void OnInitialize();

        public AutoCADPlantDSpecEditorxCatalogEditortabDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SavePB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$SaveButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

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

            PropertyEditorPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[PushButton]$PropertyEditorButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyEditorPB);

            SaveToCatalogPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[PushButton]$SaveToCatalogBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveToCatalogPB);

            ManageSizePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[CustomWin]$UserControl_PartSizeList|#1/[PushButton]$ManageSizeBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManageSizePB);

            RemoveFromCatalogPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[PushButton]$DelComponent|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveFromCatalogPB);

            CreateComponentPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[PushButton]$CreateComponentBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateComponentPB);

            DropdownPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[PushButton]$DropdownBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropdownPB);

            DuplicateComponentPB = new PushButton()
            {
                Tag = "[Windows]*/[PushButton]$DupComponent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DuplicateComponentPB);

            PushButton31PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[PushButton]$DropdownBtn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton31PB);

            PopUpButton = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_CatalogEditor/[CustomWin]$UserControl_1/[PushButton]$PopUpButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopUpButton);

            ImportFromExcel = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$ImportFromExcel|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportFromExcel);

            SizePreivewImage = new Image()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[CustomWin]$UserControl_PartSizeList|#1/[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_PartSizeProps|#1/[Image]$SizePreivewImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizePreivewImage);

            AddPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[CustomWin]$UserControl_PartSizeList|#1/[PushButton]$Button_3|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            DuplicatePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[CustomWin]$UserControl_PartSizeList|#1/[PushButton]$Button_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DuplicatePB);

            RemovePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[CustomWin]$UserControl_PartSizeList|#1/[PushButton]$Button_1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            MatchingPipeODTF = new TextField()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[CustomWin]$UserControl_PartSizeList|#1/[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_PartSizeProps|#1/[ListView]$dataGrid|#2/[ListViewItem]#3/[CustomWin]#2/[TextField]$dataGrid_Required_double_TextBoxTemplate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODTF);

            ScrollBar1SB = new ScrollBar()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[Pane]$PartFamilyPropsScrollViewer|#1/[ScrollBar]$VerticalScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScrollBar1SB);
        }
    }
}
