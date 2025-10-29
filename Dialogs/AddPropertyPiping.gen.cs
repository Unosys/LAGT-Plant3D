// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Property|$IsometricAddProperty|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AddPropertyPiping : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar AddPropertyCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;
        public  Window Plant3DWIN;
        public  StaticText Plant3DST;
        public  StaticText ClassST;
        public  TreeView TreeViewTV;
        public  TreeViewItem PipingAndEquipmentTVI;
        public  PushButton PushButton1PB;
        public  StaticText PipingAndEquipmentST;
        public  TreeViewItem PipeRunComponentTVI;
        public  PushButton PushButton2PB;
        public  StaticText PipeRunComponentST;
        public  TreeViewItem AdapterTVI;
        public  StaticText AdapterST;
        public  TreeViewItem BleedRingTVI;
        public  StaticText BleedRingST;
        public  TreeViewItem BlindDiskTVI;
        public  StaticText BlindDiskST;
        public  TreeViewItem CapTVI;
        public  StaticText CapST;
        public  TreeViewItem CouplingTVI;
        public  StaticText CouplingST;
        public  TreeViewItem CrossTVI;
        public  StaticText CrossST;
        public  TreeViewItem CrossoverTVI;
        public  StaticText CrossoverST;
        public  TreeViewItem ElbowTVI;
        public  PushButton PushButton3PB;
        public  StaticText ElbowST;
        public  TreeViewItem PipeBendTVI;
        public  StaticText PipeBendST;
        public  TreeViewItem ElbowSideOutletTVI;
        public  StaticText ElbowSideOutletST;
        public  TreeViewItem FlangeTVI;
        public  StaticText FlangeST;
        public  TreeViewItem BlindFlangeTVI;
        public  StaticText BlindFlangeST;
        public  TreeViewItem InstrumentTVI;
        public  PushButton PushButton4PB;
        public  StaticText InstrumentST;
        public  TreeViewItem InlineInstrumentTVI;
        public  StaticText InlineInstrumentST;
        public  TreeViewItem NippleTVI;
        public  StaticText NippleST;
        public  TreeViewItem NozzleTVI;
        public  StaticText NozzleST;
        public  TreeViewItem OletTVI;
        public  StaticText OletST;
        public  TreeViewItem OrificePlateTVI;
        public  StaticText OrificePlateST;
        public  StaticText PropertyST;
        public  ListBox PropertyLB;
        public  ListBoxItem AcquisitionPropertiesLBI;
        public  CheckBox CheckBox1CK;
        public  StaticText AcquisitionPropertiesST;
        public  ListBoxItem CenterOfGravityXLBI;
        public  CheckBox CheckBox2CK;
        public  StaticText CenterOfGravityXST;
        public  ListBoxItem CenterOfGravityYLBI;
        public  CheckBox CheckBox3CK;
        public  StaticText CenterOfGravityYST;
        public  ListBoxItem CenterOfGravityZLBI;
        public  CheckBox CheckBox4CK;
        public  StaticText CenterOfGravityZST;
        public  ListBoxItem CompatibleStandardLBI;
        public  CheckBox CheckBox5CK;
        public  StaticText CompatibleStandardST;
        public  ListBoxItem ComponentDesignationLBI;
        public  CheckBox CheckBox6CK;
        public  StaticText ComponentDesignationST;
        public  ListBoxItem ConnectionPortCountLBI;
        public  CheckBox CheckBox7CK;
        public  StaticText ConnectionPortCountST;
        public  ListBoxItem ContentIsoSymbolDefinitionLBI;
        public  CheckBox CheckBox8CK;
        public  StaticText ContentIsoSymbolDefinitionST;
        public  ListBoxItem COPElevationPort1LBI;
        public  CheckBox CheckBox9CK;
        public  StaticText COPElevationPort1ST;
        public  ListBoxItem DesignPressureFactorLBI;
        public  CheckBox CheckBox10CK;
        public  StaticText DesignPressureFactorST;
        public  ListBoxItem DesignStdLBI;
        public  CheckBox CheckBox11CK;
        public  StaticText DesignStdST;
        public  ListBoxItem EndTypeLBI;
        public  CheckBox CheckBox12CK;
        public  StaticText EndTypeST;
        public  ListBoxItem EngagementLengthLBI;
        public  CheckBox CheckBox13CK;
        public  StaticText EngagementLengthST;
        public  ListBoxItem FacingLBI;
        public  CheckBox CheckBox14CK;
        public  StaticText FacingST;
        public  ListBoxItem FlangeStdLBI;
        public  CheckBox CheckBox15CK;
        public  StaticText FlangeStdST;
        public  ListBoxItem FlangeThicknessLBI;
        public  CheckBox CheckBox16CK;
        public  StaticText FlangeThicknessST;
        public  Window PCFWIN;
        public  StaticText PCFST;
        public  Window SymbolsWIN;
        public  StaticText SymbolsST;
        public  Window SpecialPropertiesWIN;
        public  StaticText SpecialPropertiesST;
        public  PushButton AddPropertyPB;
        public  StaticText AddPropertyST;
        public  PushButton CancelPB;
        public  StaticText CancelST;

        partial void OnInitialize();

        public AddPropertyPiping()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddPropertyCTL = new TitleBar()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Add Property|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            Plant3DWIN = new Window()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DWIN);

            Plant3DST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]$TabItem_1|#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DST);

            ClassST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[StaticText]Class:|$TextBlock_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassST);

            TreeViewTV = new TreeView()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            PipingAndEquipmentTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingAndEquipmentTVI);

            PushButton1PB = new PushButton()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PipingAndEquipmentST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[StaticText]Piping and Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingAndEquipmentST);

            PipeRunComponentTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeRunComponentTVI);

            PushButton2PB = new PushButton()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PipeRunComponentST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[StaticText]Pipe Run Component|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeRunComponentST);

            AdapterTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Adapter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdapterTVI);

            AdapterST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Adapter|#1/[StaticText]Adapter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdapterST);

            BleedRingTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Bleed Ring|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BleedRingTVI);

            BleedRingST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Bleed Ring|#2/[StaticText]Bleed Ring|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BleedRingST);

            BlindDiskTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Blind Disk|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlindDiskTVI);

            BlindDiskST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Blind Disk|#3/[StaticText]Blind Disk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlindDiskST);

            CapTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Cap|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CapTVI);

            CapST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Cap|#4/[StaticText]Cap|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CapST);

            CouplingTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Coupling|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CouplingTVI);

            CouplingST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Coupling|#5/[StaticText]Coupling|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CouplingST);

            CrossTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Cross|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CrossTVI);

            CrossST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Cross|#6/[StaticText]Cross|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CrossST);

            CrossoverTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Crossover|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CrossoverTVI);

            CrossoverST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Crossover|#7/[StaticText]Crossover|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CrossoverST);

            ElbowTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Elbow|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowTVI);

            PushButton3PB = new PushButton()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Elbow|#8/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            ElbowST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Elbow|#8/[StaticText]Elbow|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowST);

            PipeBendTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Elbow|#8/[TreeViewItem]Pipe Bend|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeBendTVI);

            PipeBendST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Elbow|#8/[TreeViewItem]Pipe Bend|#1/[StaticText]Pipe Bend|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeBendST);

            ElbowSideOutletTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Elbow Side Outlet|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowSideOutletTVI);

            ElbowSideOutletST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Elbow Side Outlet|#9/[StaticText]Elbow Side Outlet|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowSideOutletST);

            FlangeTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Flange|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeTVI);

            FlangeST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Flange|#10/[StaticText]Flange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeST);

            BlindFlangeTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Blind Flange|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlindFlangeTVI);

            BlindFlangeST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Blind Flange|#11/[StaticText]Blind Flange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlindFlangeST);

            InstrumentTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Instrument|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentTVI);

            PushButton4PB = new PushButton()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Instrument|#12/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            InstrumentST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Instrument|#12/[StaticText]Instrument|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentST);

            InlineInstrumentTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Instrument|#12/[TreeViewItem]Inline Instrument|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InlineInstrumentTVI);

            InlineInstrumentST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Instrument|#12/[TreeViewItem]Inline Instrument|#1/[StaticText]Inline Instrument|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InlineInstrumentST);

            NippleTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Nipple|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NippleTVI);

            NippleST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Nipple|#13/[StaticText]Nipple|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NippleST);

            NozzleTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Nozzle|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzleTVI);

            NozzleST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Nozzle|#14/[StaticText]Nozzle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzleST);

            OletTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Olet|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OletTVI);

            OletST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Olet|#15/[StaticText]Olet|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OletST);

            OrificePlateTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Orifice Plate|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrificePlateTVI);

            OrificePlateST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Pipe Run Component|#1/[TreeViewItem]Orifice Plate|#16/[StaticText]Orifice Plate|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrificePlateST);

            PropertyST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[StaticText]Property:|$TextBlock_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyST);

            PropertyLB = new ListBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyLB);

            AcquisitionPropertiesLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Acquisition Properties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionPropertiesLBI);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Acquisition Properties|#1/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            AcquisitionPropertiesST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Acquisition Properties|#1/[StaticText]Acquisition Properties|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionPropertiesST);

            CenterOfGravityXLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity X|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityXLBI);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity X|#2/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            CenterOfGravityXST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity X|#2/[StaticText]Center of Gravity X|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityXST);

            CenterOfGravityYLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Y|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityYLBI);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Y|#3/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox3CK);

            CenterOfGravityYST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Y|#3/[StaticText]Center of Gravity Y|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityYST);

            CenterOfGravityZLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Z|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityZLBI);

            CheckBox4CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Z|#4/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox4CK);

            CenterOfGravityZST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Z|#4/[StaticText]Center of Gravity Z|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityZST);

            CompatibleStandardLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Compatible Standard|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompatibleStandardLBI);

            CheckBox5CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Compatible Standard|#5/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox5CK);

            CompatibleStandardST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Compatible Standard|#5/[StaticText]Compatible Standard|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompatibleStandardST);

            ComponentDesignationLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Component Designation|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComponentDesignationLBI);

            CheckBox6CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Component Designation|#6/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox6CK);

            ComponentDesignationST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Component Designation|#6/[StaticText]Component Designation|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComponentDesignationST);

            ConnectionPortCountLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Connection Port Count|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectionPortCountLBI);

            CheckBox7CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Connection Port Count|#7/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox7CK);

            ConnectionPortCountST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Connection Port Count|#7/[StaticText]Connection Port Count|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConnectionPortCountST);

            ContentIsoSymbolDefinitionLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Content Iso Symbol Definition|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentIsoSymbolDefinitionLBI);

            CheckBox8CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Content Iso Symbol Definition|#8/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox8CK);

            ContentIsoSymbolDefinitionST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Content Iso Symbol Definition|#8/[StaticText]Content Iso Symbol Definition|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentIsoSymbolDefinitionST);

            COPElevationPort1LBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]COP Elevation (Port 1)|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(COPElevationPort1LBI);

            CheckBox9CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]COP Elevation (Port 1)|#9/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox9CK);

            COPElevationPort1ST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]COP Elevation (Port 1)|#9/[StaticText]COP Elevation (Port 1)|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(COPElevationPort1ST);

            DesignPressureFactorLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Design Pressure Factor|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignPressureFactorLBI);

            CheckBox10CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Design Pressure Factor|#10/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox10CK);

            DesignPressureFactorST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Design Pressure Factor|#10/[StaticText]Design Pressure Factor|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignPressureFactorST);

            DesignStdLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Design Std|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignStdLBI);

            CheckBox11CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Design Std|#11/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox11CK);

            DesignStdST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Design Std|#11/[StaticText]Design Std|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DesignStdST);

            EndTypeLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]End Type|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeLBI);

            CheckBox12CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]End Type|#12/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox12CK);

            EndTypeST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]End Type|#12/[StaticText]End Type|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeST);

            EngagementLengthLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Engagement Length|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthLBI);

            CheckBox13CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Engagement Length|#13/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox13CK);

            EngagementLengthST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Engagement Length|#13/[StaticText]Engagement Length|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngagementLengthST);

            FacingLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Facing|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FacingLBI);

            CheckBox14CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Facing|#14/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox14CK);

            FacingST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Facing|#14/[StaticText]Facing|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FacingST);

            FlangeStdLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Flange Std|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeStdLBI);

            CheckBox15CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Flange Std|#15/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox15CK);

            FlangeStdST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Flange Std|#15/[StaticText]Flange Std|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeStdST);

            FlangeThicknessLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Flange Thickness|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeThicknessLBI);

            CheckBox16CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Flange Thickness|#16/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox16CK);

            FlangeThicknessST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$TabItem_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Flange Thickness|#16/[StaticText]Flange Thickness|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeThicknessST);

            PCFWIN = new Window()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]PCF|$TabItem_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFWIN);

            PCFST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]$TabItem_2|#2/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFST);

            SymbolsWIN = new Window()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Symbols|$SymbolsTabItem|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsWIN);

            SymbolsST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]$SymbolsTabItem|#3/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsST);

            SpecialPropertiesWIN = new Window()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Special Properties|$SpecialProperties|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecialPropertiesWIN);

            SpecialPropertiesST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]$SpecialProperties|#4/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecialPropertiesST);

            AddPropertyPB = new PushButton()
            {
                Tag = "[PushButton]Add Property|$AddPropertyBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyPB);

            AddPropertyST = new StaticText()
            {
                Tag = "[PushButton]Add Property|$AddPropertyBtn|#1/[StaticText]Add Property|$strContent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2/[StaticText]Cancel|$strContent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);
        }
    }
}
