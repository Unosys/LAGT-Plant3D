// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Select Class Property|$Select3dObjectDefinitionPropertyDlg|#1", Parent = typeof(AddJointDLG), GUIType = GuiType.UIA)]
    public partial class SelectClassProperty : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  TreeView ClassTV;
        public  TreeViewItem PipeRunComponentTVI;
        public  TreeViewItem FastenersTVI;
        public  StaticText ClassST;
        public  Pane Pane3PANE;
        public  ListBox PropertiesLB;
        public  ScrollBar PropertiesSB;
        public  ListBoxItem CompatibleStandardLBI;
        public  ListBoxItem ContentIsoSymbolDefinitionLBI;
        public  ListBoxItem DesignPressureFactorLBI;
        public  ListBoxItem DesignStdLBI;
        public  ListBoxItem EngagementLengthLBI;
        public  ListBoxItem FacingLBI;
        public  ListBoxItem FlangeStdLBI;
        public  ListBoxItem FlangeThicknessLBI;
        public  ListBoxItem GasketStdLBI;
        public  ListBoxItem ItemCodeLBI;
        public  ListBoxItem LongDescriptionFamilyLBI;
        public  ListBoxItem LongDescriptionSizeLBI;
        public  ListBoxItem ManufacturerLBI;
        public  ListBoxItem MatchingPipeODLBI;
        public  ListBoxItem MaterialLBI;
        public  ListBoxItem MaterialCodeLBI;
        public  ListBoxItem NominalDiameterLBI;
        public  ListBoxItem PortUnitLBI;
        public  ListBoxItem PressureClassLBI;
        public  ListBoxItem ScheduleLBI;
        public  ListBoxItem ShopFieldLBI;
        public  ListBoxItem ShortDescriptionLBI;
        public  ListBoxItem SizeLBI;
        public  StaticText PropertiesST;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TitleBar SelectClassPropertyCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectClassProperty()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$splitContainer1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$395128|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            ClassTV = new TreeView()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$395128|#1/[TreeView]Class:|$m_objectDefinitionTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassTV);

            PipeRunComponentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$395128|#1/[TreeView]Class:|$m_objectDefinitionTreeView|#1/[TreeViewItem]Pipe Run Component|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeRunComponentTVI);

            FastenersTVI = new TreeViewItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$395128|#1/[TreeView]Class:|$m_objectDefinitionTreeView|#1/[TreeViewItem]Fasteners|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FastenersTVI);

            ClassST = new StaticText()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$395128|#1/[StaticText]Class:|$m_objectCategoryLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassST);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            PropertiesLB = new ListBox()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesLB);

            PropertiesSB = new ScrollBar()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ScrollBar]Properties:|$Vertical ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesSB);

            CompatibleStandardLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Compatible Standard|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompatibleStandardLBI);

            ContentIsoSymbolDefinitionLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Content Iso Symbol Definition|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentIsoSymbolDefinitionLBI);

            DesignPressureFactorLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Design Pressure Factor|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignPressureFactorLBI);

            DesignStdLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Design Std|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignStdLBI);

            EngagementLengthLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Engagement Length|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthLBI);

            FacingLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Facing|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FacingLBI);

            FlangeStdLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Flange Std|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeStdLBI);

            FlangeThicknessLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Flange Thickness|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeThicknessLBI);

            GasketStdLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Gasket Std|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GasketStdLBI);

            ItemCodeLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Item Code|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemCodeLBI);

            LongDescriptionFamilyLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Long Description (Family)|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionFamilyLBI);

            LongDescriptionSizeLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Long Description (Size)|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionSizeLBI);

            ManufacturerLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Manufacturer|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManufacturerLBI);

            MatchingPipeODLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Matching Pipe OD|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MatchingPipeODLBI);

            MaterialLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Material|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialLBI);

            MaterialCodeLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Material Code|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaterialCodeLBI);

            NominalDiameterLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Nominal Diameter|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalDiameterLBI);

            PortUnitLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Port Unit|#18",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PortUnitLBI);

            PressureClassLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Pressure Class|#19",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PressureClassLBI);

            ScheduleLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Schedule|#20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScheduleLBI);

            ShopFieldLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Shop*|#21",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShopFieldLBI);

            ShortDescriptionLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Short Description|#22",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShortDescriptionLBI);

            SizeLBI = new ListBoxItem()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[ListBox]Properties:|$m_objectPropertyListBox|#1/[ListBoxItem]Size|#23",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SizeLBI);

            PropertiesST = new StaticText()
            {
                Tag = "[Pane]$splitContainer1|#1/[Pane]$199316|#2/[StaticText]Properties:|$m_objectPropertyLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_button_help|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_button_cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_button_ok|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            SelectClassPropertyCTL = new TitleBar()
            {
                Tag = "[TitleBar]Select Class Property|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectClassPropertyCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Select Class Property|$TitleBar|#1/[CustomWin]System Menu Bar|$Select3dObjectDefinitionPropertyDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Select Class Property|$TitleBar|#1/[CustomWin]System Menu Bar|$Select3dObjectDefinitionPropertyDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Class Property|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
