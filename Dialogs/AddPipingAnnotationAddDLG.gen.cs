// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Annotation|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AddPipingAnnotationAddDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar AddAnnotationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;
        public  CustomWin CustomWin1WIN;
        public  Window StandardWIN;
        public  StaticText StandardST;
        public  CustomWin CustomWin2WIN;
        public  StaticText SpecifyAComponentAnnotateST;
        public  ListBox SpecifyAComponentAnnotateLB;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem1LBI;
        public  CheckBox CheckBox1CK;
        public  StaticText BendST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem2LBI;
        public  CheckBox CheckBox2CK;
        public  StaticText CapST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem3LBI;
        public  CheckBox CheckBox3CK;
        public  StaticText ClampST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem4LBI;
        public  CheckBox CheckBox4CK;
        public  StaticText CouplingST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem5LBI;
        public  CheckBox CheckBox5CK;
        public  StaticText CrossST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem6LBI;
        public  CheckBox CheckBox6CK;
        public  StaticText ElbowST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem7LBI;
        public  CheckBox CheckBox7CK;
        public  StaticText FlangeST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem8LBI;
        public  CheckBox CheckBox8CK;
        public  StaticText BlindFlangeST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem9LBI;
        public  CheckBox CheckBox9CK;
        public  StaticText FilterST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem10LBI;
        public  CheckBox CheckBox10CK;
        public  StaticText GasketST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem11LBI;
        public  CheckBox CheckBox11CK;
        public  StaticText InstrumentInlineST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem12LBI;
        public  CheckBox CheckBox12CK;
        public  StaticText InstrumentOfflineST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem13LBI;
        public  CheckBox CheckBox13CK;
        public  StaticText OletST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem14LBI;
        public  CheckBox CheckBox14CK;
        public  StaticText PipeST;
        public  CustomWin CustomWin3WIN;
        public  GroupBox GroupBox1GB;
        public  PushButton PushButton1PB;
        public  StaticText EndTypeST;
        public  PushButton PushButton2PB;
        public  Pane Pane1PANE;
        public  StaticText SpecifyAnEndtypeIfST;
        public  GroupBox GroupBox2GB;
        public  PushButton PushButton3PB;
        public  StaticText AdditionalConditionsST;
        public  PushButton PushButton4PB;
        public  Pane Pane2PANE;
        public  StaticText UseAdditionalConditionsToST;
        public  Window AdvancedWIN;
        public  StaticText AdvancedST;
        public  StaticText AnnotationNameST;
        public  TextField AnnotationNameTF;
        public  Pane Pane3PANE;
        public  PushButton AddAnnotationPB;
        public  StaticText AddAnnotationST;
        public  PushButton CancelPB;
        public  StaticText CancelST;

        partial void OnInitialize();

        public AddPipingAnnotationAddDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddAnnotationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Add Annotation|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAnnotationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Add Annotation|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Add Annotation|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Annotation|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Annotation|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Add Annotation|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            StandardWIN = new Window()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StandardWIN);

            StandardST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]$TabItem_1|#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StandardST);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            SpecifyAComponentAnnotateST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[StaticText]Specify a Component Annotate:|$TextBlock_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyAComponentAnnotateST);

            SpecifyAComponentAnnotateLB = new ListBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyAComponentAnnotateLB);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem1LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem1LBI);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#1/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            BendST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#1/[StaticText]Bend|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BendST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem2LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem2LBI);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#2/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            CapST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#2/[StaticText]Cap|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CapST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem3LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem3LBI);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#3/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox3CK);

            ClampST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#3/[StaticText]Clamp|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClampST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem4LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem4LBI);

            CheckBox4CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#4/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox4CK);

            CouplingST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#4/[StaticText]Coupling|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CouplingST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem5LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem5LBI);

            CheckBox5CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#5/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox5CK);

            CrossST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#5/[StaticText]Cross|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CrossST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem6LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem6LBI);

            CheckBox6CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#6/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox6CK);

            ElbowST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#6/[StaticText]Elbow|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem7LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem7LBI);

            CheckBox7CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#7/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox7CK);

            FlangeST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#7/[StaticText]Flange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem8LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem8LBI);

            CheckBox8CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#8/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox8CK);

            BlindFlangeST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#8/[StaticText]Blind Flange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlindFlangeST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem9LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem9LBI);

            CheckBox9CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#9/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox9CK);

            FilterST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#9/[StaticText]Filter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem10LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem10LBI);

            CheckBox10CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#10/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox10CK);

            GasketST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#10/[StaticText]Gasket|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GasketST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem11LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem11LBI);

            CheckBox11CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#11/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox11CK);

            InstrumentInlineST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#11/[StaticText]Instrument (Inline)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentInlineST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem12LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem12LBI);

            CheckBox12CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#12/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox12CK);

            InstrumentOfflineST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#12/[StaticText]Instrument (Offline)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentOfflineST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem13LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem13LBI);

            CheckBox13CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#13/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox13CK);

            OletST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#13/[StaticText]Olet|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OletST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem14LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem14LBI);

            CheckBox14CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#14/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox14CK);

            PipeST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#1/[ListBox]Specify a Component Annotate:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#14/[StaticText]Pipe|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeST);

            CustomWin3WIN = new CustomWin()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin3WIN);

            GroupBox1GB = new GroupBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$EndTypeExpander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox1GB);

            PushButton1PB = new PushButton()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$EndTypeExpander|#1/[PushButton]$ExpanderButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            EndTypeST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$EndTypeExpander|#1/[PushButton]$ExpanderButton|#1/[StaticText]End Type|$TextBlock_7|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndTypeST);

            PushButton2PB = new PushButton()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$EndTypeExpander|#1/[PushButton]$ExpanderButton|#1/[PushButton]$AddEndType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            Pane1PANE = new Pane()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$EndTypeExpander|#1/[Pane]$ScrollViewer_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            SpecifyAnEndtypeIfST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[StaticText]Specify an endtype if you want to limit dimensioning to a component of a specific endtype (eg*|$EndTypeListTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyAnEndtypeIfST);

            GroupBox2GB = new GroupBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$ConditionsExpander|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox2GB);

            PushButton3PB = new PushButton()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$ConditionsExpander|#2/[PushButton]$ExpanderButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            AdditionalConditionsST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$ConditionsExpander|#2/[PushButton]$ExpanderButton|#1/[StaticText]Additional Conditions|$TextBlock_8|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdditionalConditionsST);

            PushButton4PB = new PushButton()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$ConditionsExpander|#2/[PushButton]$ExpanderButton|#1/[PushButton]$AddCondition|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            Pane2PANE = new Pane()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[GroupBox]$ConditionsExpander|#2/[Pane]$ScrollViewer_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            UseAdditionalConditionsToST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Standard|$TabItem_1|#1/[CustomWin]$UserControl_1|#2/[StaticText]Use Additional Conditions to specify piping components of a specific status, service or other condition*|$ConditionListTextBlock|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseAdditionalConditionsToST);

            AdvancedWIN = new Window()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]Advanced|$TabItem_2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedWIN);

            AdvancedST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[PageList]$AddAnchorTabControl|#1/[Window]$TabItem_2|#2/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdvancedST);

            AnnotationNameST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[StaticText]Annotation Name:|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationNameST);

            AnnotationNameTF = new TextField()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[TextField]Annotation Name:|$AnchorNameTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationNameTF);

            Pane3PANE = new Pane()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTemplate_1|#1/[TextField]Annotation Name:|$AnchorNameTextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

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
