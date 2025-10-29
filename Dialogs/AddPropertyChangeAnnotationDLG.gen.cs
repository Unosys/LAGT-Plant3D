// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Property Change Annotation|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AddPropertyChangeAnnotationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;
        public  CustomWin CustomWinWIN;
        public  StaticText SpecifyThePropertyChangeST;
        public  StaticText ClassST;
        public  TreeView TreeViewTV;
        public  TreeViewItem PipingAndEquipmentTVI;
        public  PushButton PushButton1PB;
        public  StaticText PipingAndEquipmentST;
        public  TreeViewItem EquipmentTVI;
        public  PushButton PushButton2PB;
        public  StaticText EquipmentST;
        public  TreeViewItem BlowerTVI;
        public  StaticText BlowerST;
        public  TreeViewItem CentrifugeTVI;
        public  StaticText CentrifugeST;
        public  TreeViewItem ColumnsTVI;
        public  StaticText ColumnsST;
        public  TreeViewItem CompressorTVI;
        public  StaticText CompressorST;
        public  TreeViewItem ConveyorsTVI;
        public  StaticText ConveyorsST;
        public  TreeViewItem CycloneTVI;
        public  StaticText CycloneST;
        public  TreeViewItem DryerTVI;
        public  StaticText DryerST;
        public  TreeViewItem FilterTVI;
        public  StaticText FilterST;
        public  TreeViewItem FurnaceTVI;
        public  StaticText FurnaceST;
        public  TreeViewItem GlobalEquipmentTVI;
        public  StaticText GlobalEquipmentST;
        public  TreeViewItem HeaterTVI;
        public  StaticText HeaterST;
        public  TreeViewItem HeatExchangerTVI;
        public  StaticText HeatExchangerST;
        public  TreeViewItem MechanicalDriversTVI;
        public  StaticText MechanicalDriversST;
        public  TreeViewItem MixingEquipmentTVI;
        public  StaticText MixingEquipmentST;
        public  TreeViewItem MotorTVI;
        public  StaticText MotorST;
        public  TreeViewItem PumpTVI;
        public  StaticText PumpST;
        public  TreeViewItem ScrubberTVI;
        public  StaticText ScrubberST;
        public  TreeViewItem StrainerEquipmentTVI;
        public  StaticText StrainerEquipmentST;
        public  TreeViewItem TankTVI;
        public  StaticText TankST;
        public  TreeViewItem VesselTVI;
        public  StaticText VesselST;
        public  StaticText AnnotationNameST;
        public  TextField AnnotationNameTF;
        public  Pane PanePANE;
        public  StaticText PropertyST;
        public  ListBox PropertyLB;
        public  PushButton AddAnnotationPB;
        public  StaticText AddAnnotationST;
        public  PushButton CancelPB;
        public  StaticText CancelST;

        partial void OnInitialize();

        public AddPropertyChangeAnnotationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Add Property Change Annotation|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Property Change Annotation|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Property Change Annotation|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Add Property Change Annotation|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            SpecifyThePropertyChangeST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[StaticText]Specify the property change to annotate:|$TextBlock_6|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyThePropertyChangeST);

            ClassST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[StaticText]Class:|$TextBlock_1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassST);

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            PipingAndEquipmentTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingAndEquipmentTVI);

            PushButton1PB = new PushButton()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PipingAndEquipmentST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[StaticText]Piping and Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingAndEquipmentST);

            EquipmentTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTVI);

            PushButton2PB = new PushButton()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            EquipmentST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[StaticText]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentST);

            BlowerTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Blower|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlowerTVI);

            BlowerST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Blower|#1/[StaticText]Blower|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlowerST);

            CentrifugeTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Centrifuge|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CentrifugeTVI);

            CentrifugeST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Centrifuge|#2/[StaticText]Centrifuge|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CentrifugeST);

            ColumnsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Columns|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColumnsTVI);

            ColumnsST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Columns|#3/[StaticText]Columns|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ColumnsST);

            CompressorTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Compressor|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompressorTVI);

            CompressorST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Compressor|#4/[StaticText]Compressor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CompressorST);

            ConveyorsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Conveyors|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConveyorsTVI);

            ConveyorsST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Conveyors|#5/[StaticText]Conveyors|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConveyorsST);

            CycloneTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Cyclone|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CycloneTVI);

            CycloneST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Cyclone|#6/[StaticText]Cyclone|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CycloneST);

            DryerTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Dryer|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DryerTVI);

            DryerST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Dryer|#7/[StaticText]Dryer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DryerST);

            FilterTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Filter|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterTVI);

            FilterST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Filter|#8/[StaticText]Filter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterST);

            FurnaceTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Furnace|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FurnaceTVI);

            FurnaceST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Furnace|#9/[StaticText]Furnace|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FurnaceST);

            GlobalEquipmentTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Global Equipment|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GlobalEquipmentTVI);

            GlobalEquipmentST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Global Equipment|#10/[StaticText]Global Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GlobalEquipmentST);

            HeaterTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Heater|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaterTVI);

            HeaterST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Heater|#11/[StaticText]Heater|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaterST);

            HeatExchangerTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Heat Exchanger|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeatExchangerTVI);

            HeatExchangerST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Heat Exchanger|#12/[StaticText]Heat Exchanger|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeatExchangerST);

            MechanicalDriversTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Mechanical Drivers|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MechanicalDriversTVI);

            MechanicalDriversST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Mechanical Drivers|#13/[StaticText]Mechanical Drivers|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MechanicalDriversST);

            MixingEquipmentTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Mixing Equipment|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MixingEquipmentTVI);

            MixingEquipmentST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Mixing Equipment|#14/[StaticText]Mixing Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MixingEquipmentST);

            MotorTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Motor|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MotorTVI);

            MotorST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Motor|#15/[StaticText]Motor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MotorST);

            PumpTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Pump|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PumpTVI);

            PumpST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Pump|#16/[StaticText]Pump|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PumpST);

            ScrubberTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Scrubber|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScrubberTVI);

            ScrubberST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Scrubber|#17/[StaticText]Scrubber|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ScrubberST);

            StrainerEquipmentTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Strainer Equipment|#18",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StrainerEquipmentTVI);

            StrainerEquipmentST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Strainer Equipment|#18/[StaticText]Strainer Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StrainerEquipmentST);

            TankTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Tank|#19",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TankTVI);

            TankST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Tank|#19/[StaticText]Tank|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TankST);

            VesselTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Vessel|#20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VesselTVI);

            VesselST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]Piping and Equipment|#1/[TreeViewItem]Equipment|#1/[TreeViewItem]Vessel|#20/[StaticText]Vessel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VesselST);

            AnnotationNameST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[StaticText]Annotation Name:|$TextBlock_7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationNameST);

            AnnotationNameTF = new TextField()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TextField]Annotation Name:|$PlantPropertyNameTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationNameTF);

            PanePANE = new Pane()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[TextField]Annotation Name:|$PlantPropertyNameTextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            PropertyST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[StaticText]Property:|$TextBlock_2|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyST);

            PropertyLB = new ListBox()
            {
                Tag = "[CustomWin]$local:IsometricPlantClassPropUserControl_1|#1/[ListBox]Property:|$PlantPropertyListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyLB);

            AddAnnotationPB = new PushButton()
            {
                Tag = "[PushButton]Add Annotation|$AddAnnotation|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAnnotationPB);

            AddAnnotationST = new StaticText()
            {
                Tag = "[PushButton]Add Annotation|$AddAnnotation|#1/[StaticText]Add Annotation|$strContent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAnnotationST);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            CancelST = new StaticText()
            {
                Tag = "[PushButton]Cancel|$Cancel|#2/[StaticText]Cancel|$strContent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelST);
        }
    }
}
