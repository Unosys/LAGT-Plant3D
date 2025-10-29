// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Edit Long Description Style|$LongDescriptionEditorDialog", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class CatalogBuilderEditLongDescriptionStyleDLG : Autodesk.GUIHarness.Window
    {
        public  PushButton Ok;
        public  PushButton Apply;
        public  PushButton Cancel;
        public  PushButton Help;
        public  TreeView ClassTreeView;
        public  TreeViewItem EngineeringItems;
        public  TreeViewItem PipeRunComponent;
        public  TreeViewItem Adapter;
        public  TreeViewItem BleedRing;
        public  TreeViewItem BlindDisk;
        public  TreeViewItem Cap;
        public  TreeViewItem Coupling;
        public  TreeViewItem Cross;
        public  TreeViewItem Crossover;
        public  TreeViewItem Elbow;
        public  TreeViewItem PipeBend;
        public  TreeViewItem ElbowSideOutlet;
        public  TreeViewItem Flange;
        public  TreeViewItem BlindFlange;
        public  TreeViewItem Instrument;
        public  TreeViewItem InlineInstrument;
        public  TreeViewItem Nipple;
        public  TreeViewItem Nozzle;
        public  TreeViewItem Olet;
        public  TreeViewItem OrificePlate;
        public  TreeViewItem Pipe;
        public  TreeViewItem Plug;
        public  TreeViewItem Reducer;
        public  TreeViewItem Swage;
        public  TreeViewItem SpacerDisk;
        public  TreeViewItem SpectacleBlind;
        public  TreeViewItem Sleeve;
        public  TreeViewItem Strainer;
        public  TreeViewItem Support;
        public  TreeViewItem SingleBranchFitting;
        public  TreeViewItem Lateral;
        public  TreeViewItem Tee;
        public  TreeViewItem TeeCrossover;
        public  TreeViewItem Wye;
        public  TreeViewItem TeeSideOutlet;
        public  TreeViewItem Valve;
        public  TreeViewItem ValveActuator;
        public  TreeViewItem ValveBody;
        public  TreeViewItem Fasteners;
        public  TreeViewItem Collar;
        public  TreeViewItem StubEnd;
        public  TreeViewItem Gasket;
        public  TreeViewItem ReinforcementRing;
        public  TreeViewItem BackingRing;
        public  TreeViewItem Clamp;
        public  TreeViewItem Gland;
        public  TreeViewItem BoltSet;
        public  StaticText StyleLabel;
        public  PopupList StylesComboBox;
        public  PushButton DeleteButton;
        public  PushButton SaveAsButton;
        public  GroupBox LDFEditorGroupBox;
        public  StaticText LDFormula;
        public  StaticText LDFormulaLabel;
        public  PushButton AddRowButton;
        public  PushButton RemoveRowButton;
        public  Pane WfiWindowsFormsHost;

        partial void OnInitialize();

        public CatalogBuilderEditLongDescriptionStyleDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Ok = new PushButton()
            {
                Tag = "[PushButton]$Ok",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Ok);

            Apply = new PushButton()
            {
                Tag = "[PushButton]$Apply",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Apply);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$Cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]$Help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            ClassTreeView = new TreeView()
            {
                Tag = "[TreeView]$ClassTreeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassTreeView);

            EngineeringItems = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$EngineeringItems",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItems);

            PipeRunComponent = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$PipeRunComponent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeRunComponent);

            Adapter = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Adapter",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Adapter);

            BleedRing = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$BleedRing",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BleedRing);

            BlindDisk = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$BlindDisk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlindDisk);

            Cap = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Cap",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cap);

            Coupling = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Coupling",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Coupling);

            Cross = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Cross",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cross);

            Crossover = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Crossover",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Crossover);

            Elbow = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Elbow",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Elbow);

            PipeBend = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$PipeBend",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeBend);

            ElbowSideOutlet = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$ElbowSideOutlet",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowSideOutlet);

            Flange = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Flange",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Flange);

            BlindFlange = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$BlindFlange",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlindFlange);

            Instrument = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Instrument",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Instrument);

            InlineInstrument = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$InlineInstrument",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InlineInstrument);

            Nipple = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Nipple",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Nipple);

            Nozzle = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Nozzle",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Nozzle);

            Olet = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Olet",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Olet);

            OrificePlate = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$OrificePlate",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrificePlate);

            Pipe = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Pipe",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pipe);

            Plug = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Plug",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plug);

            Reducer = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Reducer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Reducer);

            Swage = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Swage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Swage);

            SpacerDisk = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$SpacerDisk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpacerDisk);

            SpectacleBlind = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$SpectacleBlind",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpectacleBlind);

            Sleeve = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Sleeve",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Sleeve);

            Strainer = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Strainer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Strainer);

            Support = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Support",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Support);

            SingleBranchFitting = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$SingleBranchFitting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SingleBranchFitting);

            Lateral = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Lateral",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Lateral);

            Tee = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Tee",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tee);

            TeeCrossover = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$TeeCrossover",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TeeCrossover);

            Wye = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Wye",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Wye);

            TeeSideOutlet = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$TeeSideOutlet",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TeeSideOutlet);

            Valve = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Valve",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Valve);

            ValveActuator = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$ValveActuator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValveActuator);

            ValveBody = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$ValveBody",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValveBody);

            Fasteners = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Fasteners",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Fasteners);

            Collar = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Collar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Collar);

            StubEnd = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$StubEnd",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StubEnd);

            Gasket = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Gasket",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Gasket);

            ReinforcementRing = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$ReinforcementRing",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReinforcementRing);

            BackingRing = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$BackingRing",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackingRing);

            Clamp = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Clamp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Clamp);

            Gland = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$Gland",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Gland);

            BoltSet = new TreeViewItem()
            {
                Tag = "[TreeViewItem]$BoltSet",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltSet);

            StyleLabel = new StaticText()
            {
                Tag = "[StaticText]$StyleLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StyleLabel);

            StylesComboBox = new PopupList()
            {
                Tag = "[PopupList]$StylesComboBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StylesComboBox);

            DeleteButton = new PushButton()
            {
                Tag = "[PushButton]$DeleteButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteButton);

            SaveAsButton = new PushButton()
            {
                Tag = "[PushButton]$SaveAsButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsButton);

            LDFEditorGroupBox = new GroupBox()
            {
                Tag = "[GroupBox]$LDFEditorGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LDFEditorGroupBox);

            LDFormula = new StaticText()
            {
                Tag = "[StaticText]$LDFormula",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LDFormula);

            LDFormulaLabel = new StaticText()
            {
                Tag = "[StaticText]$LDFormulaLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LDFormulaLabel);

            AddRowButton = new PushButton()
            {
                Tag = "[PushButton]$AddRowButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddRowButton);

            RemoveRowButton = new PushButton()
            {
                Tag = "[PushButton]$RemoveRowButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveRowButton);

            WfiWindowsFormsHost = new Pane()
            {
                Tag = "[Pane]$wfi:WindowsFormsHost",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WfiWindowsFormsHost);
        }
    }
}
