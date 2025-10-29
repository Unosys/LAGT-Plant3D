// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Component Group|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AddComponentGroupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar AddComponentGroupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;
        public  StaticText GroupNameST;
        public  TextField GroupNameTF;
        public  Pane PanePANE;
        public  CustomWin CustomWinWIN;
        public  StaticText ChooseBOMComponentsToST;
        public  ListBox ChooseBOMComponentsToLB;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem1LBI;
        public  CheckBox CheckBox1CK;
        public  StaticText BoltST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem2LBI;
        public  CheckBox CheckBox2CK;
        public  StaticText BendST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem3LBI;
        public  CheckBox CheckBox3CK;
        public  StaticText CapST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem4LBI;
        public  CheckBox CheckBox4CK;
        public  StaticText ClampST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem5LBI;
        public  CheckBox CheckBox5CK;
        public  StaticText CouplingST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem6LBI;
        public  CheckBox CheckBox6CK;
        public  StaticText CrossST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem7LBI;
        public  CheckBox CheckBox7CK;
        public  StaticText ElbowST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem8LBI;
        public  CheckBox CheckBox8CK;
        public  StaticText FlangeST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem9LBI;
        public  CheckBox CheckBox9CK;
        public  StaticText BlindFlangeST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem10LBI;
        public  CheckBox CheckBox10CK;
        public  StaticText FilterST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem11LBI;
        public  CheckBox CheckBox11CK;
        public  StaticText InstrumentInlineST;
        public  PushButton CancelPB;
        public  StaticText CancelST;
        public  PushButton AddComponentGroupPB;
        public  StaticText AddComponentGroupST;

        partial void OnInitialize();

        public AddComponentGroupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AddComponentGroupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Add Component Group|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddComponentGroupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Add Component Group|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Add Component Group|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Component Group|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Add Component Group|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Add Component Group|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            GroupNameST = new StaticText()
            {
                Tag = "[StaticText]Group Name:|$TextBlock_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupNameST);

            GroupNameTF = new TextField()
            {
                Tag = "[TextField]Group Name:|$GroupNameTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupNameTF);

            PanePANE = new Pane()
            {
                Tag = "[TextField]Group Name:|$GroupNameTextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            ChooseBOMComponentsToST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[StaticText]Choose BOM Components to annotate together:|$TextBlock_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseBOMComponentsToST);

            ChooseBOMComponentsToLB = new ListBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChooseBOMComponentsToLB);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem1LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem1LBI);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#1/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            BoltST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#1/[StaticText]Bolt|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem2LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem2LBI);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#2/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            BendST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#2/[StaticText]Bend|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BendST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem3LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem3LBI);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#3/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox3CK);

            CapST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#3/[StaticText]Cap|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CapST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem4LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem4LBI);

            CheckBox4CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#4/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox4CK);

            ClampST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#4/[StaticText]Clamp|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClampST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem5LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem5LBI);

            CheckBox5CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#5/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox5CK);

            CouplingST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#5/[StaticText]Coupling|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CouplingST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem6LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem6LBI);

            CheckBox6CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#6/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox6CK);

            CrossST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#6/[StaticText]Cross|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CrossST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem7LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem7LBI);

            CheckBox7CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#7/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox7CK);

            ElbowST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#7/[StaticText]Elbow|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ElbowST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem8LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem8LBI);

            CheckBox8CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#8/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox8CK);

            FlangeST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#8/[StaticText]Flange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FlangeST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem9LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem9LBI);

            CheckBox9CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#9/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox9CK);

            BlindFlangeST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#9/[StaticText]Blind Flange|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlindFlangeST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem10LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem10LBI);

            CheckBox10CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#10/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox10CK);

            FilterST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#10/[StaticText]Filter|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilterST);

            AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem11LBI = new ListBoxItem()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupComponentItem11LBI);

            CheckBox11CK = new CheckBox()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#11/[CheckBox]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox11CK);

            InstrumentInlineST = new StaticText()
            {
                Tag = "[CustomWin]$local:IsometricAddDialogTree_1|#1/[ListBox]Choose BOM Components to annotate together:|$AllComponentsListBox|#1/[ListBoxItem]Autodesk*|#11/[StaticText]Instrument (Inline)|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentInlineST);

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

            AddComponentGroupPB = new PushButton()
            {
                Tag = "[PushButton]Add Component Group|$Add|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddComponentGroupPB);

            AddComponentGroupST = new StaticText()
            {
                Tag = "[PushButton]Add Component Group|$Add|#1/[StaticText]Add Component Group|$strContent|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddComponentGroupST);
        }
    }
}
