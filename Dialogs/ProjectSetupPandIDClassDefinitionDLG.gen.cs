// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupPandIDClassDefinitionDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView M_treeView;
        public  TreeViewItem GeneralSettingsTVI;
        public  TreeViewItem PIDDWGSettingsTVI;
        public  TreeViewItem EndConnectionsTVI;
        public  TreeViewItem LineSettingsTVI;
        public  TreeViewItem ExportAndImportSettingsTVI;
        public  TreeViewItem PathsTVI;
        public  TreeViewItem DataManagerConfigurationTVI;
        public  TreeViewItem PIDClassDefinitionsTVI;
        public  TreeViewItem EngineeringItemsTVI;
        public  TreeViewItem EquipmentTVI;
        public  TreeViewItem BlowersTVI;
        public  TreeViewItem AxialBlowerTVI;
        public  TreeViewItem CentrifugalBlowerTVI;
        public  TreeViewItem GeneralBlowerTVI;
        public  TreeViewItem PositiveDisplacementBlowerTVI;
        public  TreeViewItem RadialBlowerTVI;
        public  TreeViewItem CompressorsTVI;
        public  TreeViewItem ConveyorsTVI;
        public  TreeViewItem CrushersTVI;
        public  TreeViewItem DriersTVI;
        public  TreeViewItem EnergySymbolsTVI;
        public  TreeViewItem FiltersTVI;
        public  TreeViewItem FurnacesTVI;
        public  TreeViewItem HeatExchangersTVI;
        public  TreeViewItem MechanicalDriversTVI;
        public  TreeViewItem MiscellaneousEquipmentTVI;
        public  TreeViewItem MixingEquipmentTVI;
        public  TreeViewItem NuclearReactorsTVI;
        public  TreeViewItem PumpsTVI;
        public  TreeViewItem TanksTVI;
        public  TreeViewItem InlineAssetsTVI;
        public  TreeViewItem InstrumentationTVI;
        public  TreeViewItem LinesTVI;
        public  TreeViewItem NozzlesTVI;
        public  TreeViewItem NonEngineeringItemsTVI;
        public  TreeViewItem PipeLineGroupTVI;
        public  TreeViewItem SignalLineGroupTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox ClassSettingsEngineeringItemsGB;
        public  GroupBox SymbolGB;
        public  PushButton M_btnAdd2TP;
        public  PushButton RemoveSymbolPB;
        public  PopupList PopupList1PL;
        public  PushButton DropDownButton1PB;
        public  PushButton M_btnAddStyle;
        public  PushButton EditSymbolPB;
        public  PushButton EditBlock1PB;
        public  StaticText NoPreviewAvailableST;
        public  GroupBox PropertiesGB;
        public  PushButton RemovePB;
        public  Table DataGridViewTBL;
        public  Pane VerticalScrollBarPANE;
        public  CustomWin TopRowWIN;
        public  Header PropertyNameCTL;
        public  Header PropertyDescriptionCTL;
        public  Header DisplayNameCTL;
        public  Header DefaultValueCTL;
        public  Header PropertyTypeCTL;
        public  Header AcquisitionCTL;
        public  Header ReadOnlyCTL;
        public  Header VisibleCTL;
        public  CustomWin Row0WIN;
        public  CustomWin PropertyNameRow0WIN;
        public  CustomWin PropertyDescriptionRow0WIN;
        public  CustomWin DisplayNameRow0WIN;
        public  CustomWin DefaultValueRow0WIN;
        public  CustomWin PropertyTypeRow0WIN;
        public  CustomWin AcquisitionRow0WIN;
        public  CustomWin ReadOnlyRow0WIN;
        public  CustomWin VisibleRow0WIN;
        public  PushButton EditPB;
        public  PushButton M_btnAddProperty;
        public  GroupBox TagFormatGB;
        public  PushButton DeletePB;
        public  PushButton ModifyPB;
        public  PushButton NewPB;
        public  ListBox ListBoxLB;
        public  GroupBox AnnotationGB;
        public  PushButton RemoveAnnotationPB;
        public  PopupList PopupList2PL;
        public  PushButton DropDownButton2PB;
        public  PushButton AddAnnotationPB;
        public  PushButton EditAnnotationPB;
        public  PushButton EditBlock2PB;
        public  Pane NoPreviewAvailablePANE;
        public  Pane Pane7PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupPandIDClassDefinitionDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$4853528|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            M_treeView = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$4853528|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeView);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            EndConnectionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]End Connections|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndConnectionsTVI);

            LineSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Line Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Export and Import Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Paths|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]Data Manager Configuration|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            PIDClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDClassDefinitionsTVI);

            EngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItemsTVI);

            EquipmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTVI);

            BlowersTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Blowers|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlowersTVI);

            AxialBlowerTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Blowers|#1/[TreeViewItem]Axial Blower|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AxialBlowerTVI);

            CentrifugalBlowerTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Blowers|#1/[TreeViewItem]Centrifugal Blower|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CentrifugalBlowerTVI);

            GeneralBlowerTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Blowers|#1/[TreeViewItem]General Blower|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralBlowerTVI);

            PositiveDisplacementBlowerTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Blowers|#1/[TreeViewItem]Positive Displacement Blower|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PositiveDisplacementBlowerTVI);

            RadialBlowerTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Blowers|#1/[TreeViewItem]Radial Blower|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadialBlowerTVI);

            CompressorsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Compressors|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompressorsTVI);

            ConveyorsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Conveyors|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConveyorsTVI);

            CrushersTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Crushers|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CrushersTVI);

            DriersTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Driers|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DriersTVI);

            EnergySymbolsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Energy Symbols|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnergySymbolsTVI);

            FiltersTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Filters|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FiltersTVI);

            FurnacesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Furnaces|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FurnacesTVI);

            HeatExchangersTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Heat Exchangers|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeatExchangersTVI);

            MechanicalDriversTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Mechanical Drivers|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MechanicalDriversTVI);

            MiscellaneousEquipmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Miscellaneous Equipment|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MiscellaneousEquipmentTVI);

            MixingEquipmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Mixing Equipment|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MixingEquipmentTVI);

            NuclearReactorsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Nuclear Reactors|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NuclearReactorsTVI);

            PumpsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Pumps|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PumpsTVI);

            TanksTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Tanks|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TanksTVI);

            InlineAssetsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Inline Assets|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InlineAssetsTVI);

            InstrumentationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Instrumentation|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentationTVI);

            LinesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Lines|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinesTVI);

            NozzlesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Engineering Items|#1/[TreeViewItem]Nozzles|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzlesTVI);

            NonEngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Non Engineering Items|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NonEngineeringItemsTVI);

            PipeLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Pipe Line Group|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineGroupTVI);

            SignalLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2/[TreeViewItem]P*|#6/[TreeViewItem]Signal Line Group|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignalLineGroupTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6491818|#1/[Pane]$m_splitVert|#1/[Pane]$16254756|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            ClassSettingsEngineeringItemsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassSettingsEngineeringItemsGB);

            SymbolGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolGB);

            M_btnAdd2TP = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]Add to Tool Palette *|$m_btnAdd2TP|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAdd2TP);

            RemoveSymbolPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]Remove Symbol*|$m_btnRemoveStyle|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveSymbolPB);

            PopupList1PL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PopupList]$m_comboBoxGraphical|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList1PL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PopupList]$m_comboBoxGraphical|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            M_btnAddStyle = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]Add Symbols*|$m_btnAddStyle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddStyle);

            EditSymbolPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]Edit Symbol*|$m_btnModifyStyle|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditSymbolPB);

            EditBlock1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[PushButton]Edit Block*|$m_btnEditStyle|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditBlock1PB);

            NoPreviewAvailableST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[StaticText]No preview available|$m_PreviewStatic|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPreviewAvailableST);

            PropertiesGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesGB);

            RemovePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Remove|$m_btnRemoveProperties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            DataGridViewTBL = new Table()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[Pane]Vertical Scroll Bar|$14091766|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            PropertyNameCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameCTL);

            PropertyDescriptionCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Description|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyDescriptionCTL);

            DisplayNameCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Display Name|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameCTL);

            DefaultValueCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Default Value|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueCTL);

            PropertyTypeCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Type|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTypeCTL);

            AcquisitionCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Acquisition|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionCTL);

            ReadOnlyCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Read Only|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadOnlyCTL);

            VisibleCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Visible|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisibleCTL);

            Row0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row0WIN);

            PropertyNameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Name Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameRow0WIN);

            PropertyDescriptionRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Description Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyDescriptionRow0WIN);

            DisplayNameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Display Name Row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameRow0WIN);

            DefaultValueRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Default Value Row 0|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueRow0WIN);

            PropertyTypeRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Type Row 0|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTypeRow0WIN);

            AcquisitionRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Acquisition Row 0|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionRow0WIN);

            ReadOnlyRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Read Only Row 0|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadOnlyRow0WIN);

            VisibleRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Visible Row 0|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisibleRow0WIN);

            EditPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Edit*|$m_btnEditProperties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditPB);

            M_btnAddProperty = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Add*|$m_btnAddProperty|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAddProperty);

            TagFormatGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagFormatGB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]Delete|$m_btnDeleteTag|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            ModifyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]Modify*|$m_btnModifyTag|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifyPB);

            NewPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]New*|$m_btnNewTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewPB);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[ListBox]$m_listBoxTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            AnnotationGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationGB);

            RemoveAnnotationPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PushButton]Remove Annotation*|$m_btnRemoveAnn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveAnnotationPB);

            PopupList2PL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PopupList]$m_comboBoxAnn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupList2PL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PopupList]$m_comboBoxAnn|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            AddAnnotationPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PushButton]Add Annotation*|$m_btnAddAnn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAnnotationPB);

            EditAnnotationPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PushButton]Edit Annotation*|$m_btnModifyAnn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditAnnotationPB);

            EditBlock2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[PushButton]Edit Block*|$m_btnEditAnn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditBlock2PB);

            NoPreviewAvailablePANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5902766|#1/[Pane]$m_splitVert|#1/[Pane]$5575106|#2/[Pane]$m_classPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Engineering Items|$m_groupBox|#1/[GroupBox]Annotation|$m_groupBoxAnn|#4/[Pane]No preview available|$19792096|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPreviewAvailablePANE);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4785714|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4785714|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4785714|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4785714|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$4785714|#2/[PushButton]Apply|$m_btnSave|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            ProjectSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
