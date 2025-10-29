// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Add Property", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class IsometricDWGSettingsIsoStyleSetupAddPropertyDLG : Pane
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
        public  TreeViewItem P3dLineGroupTVI;
        public  StaticText P3dLineGroupST;
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
        public  ListBoxItem CommentLBI;
        public  CheckBox CheckBox5CK;
        public  StaticText CommentST;
        public  ListBoxItem DescriptionLBI;
        public  CheckBox CheckBox6CK;
        public  StaticText DescriptionST;
        public  ListBoxItem InsulationSpecLBI;
        public  CheckBox CheckBox7CK;
        public  StaticText InsulationSpecST;
        public  ListBoxItem InsulationThicknessLBI;
        public  CheckBox CheckBox8CK;
        public  StaticText InsulationThicknessST;
        public  ListBoxItem InsulationTypeLBI;
        public  CheckBox CheckBox9CK;
        public  StaticText InsulationTypeST;
        public  ListBoxItem LineNumberTagLBI;
        public  CheckBox CheckBox10CK;
        public  StaticText LineNumberTagST;
        public  ListBoxItem LockChangeAtLBI;
        public  CheckBox CheckBox11CK;
        public  StaticText LockChangeAtST;
        public  ListBoxItem LockChangeByLBI;
        public  CheckBox CheckBox12CK;
        public  StaticText LockChangeByST;
        public  ListBoxItem LockedLineStatusLBI;
        public  CheckBox CheckBox13CK;
        public  StaticText LockedLineStatusST;
        public  ListBoxItem NominalSizeLBI;
        public  CheckBox CheckBox14CK;
        public  StaticText NominalSizeST;
        public  ListBoxItem NominalSpecLBI;
        public  CheckBox CheckBox15CK;
        public  StaticText NominalSpecST;
        public  ListBoxItem NumberLBI;
        public  CheckBox CheckBox16CK;
        public  StaticText NumberST;
        public  Window PCFWIN;
        public  StaticText PCFST;
        public  PushButton AddPropertyPB;
        public  StaticText AddPropertyST;
        public  PushButton CancelPB;
        public  StaticText CancelST;

        partial void OnInitialize();

        public IsometricDWGSettingsIsoStyleSetupAddPropertyDLG()
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
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DWIN);

            Plant3DST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[StaticText]Plant 3D|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DST);

            ClassST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[StaticText]Class:|$TextBlock_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassST);

            TreeViewTV = new TreeView()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[TreeView]$ClassTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            P3dLineGroupTVI = new TreeViewItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]P3d Line Group|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dLineGroupTVI);

            P3dLineGroupST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[TreeView]$ClassTreeView|#1/[TreeViewItem]P3d Line Group|#1/[StaticText]P3d Line Group|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dLineGroupST);

            PropertyST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[StaticText]Property:|$TextBlock_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyST);

            PropertyLB = new ListBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyLB);

            AcquisitionPropertiesLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]AcquisitionProperties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionPropertiesLBI);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]AcquisitionProperties|#1/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            AcquisitionPropertiesST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]AcquisitionProperties|#1/[StaticText]AcquisitionProperties|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionPropertiesST);

            CenterOfGravityXLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity X|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityXLBI);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity X|#2/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            CenterOfGravityXST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity X|#2/[StaticText]Center of Gravity X|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityXST);

            CenterOfGravityYLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Y|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityYLBI);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Y|#3/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox3CK);

            CenterOfGravityYST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Y|#3/[StaticText]Center of Gravity Y|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityYST);

            CenterOfGravityZLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Z|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityZLBI);

            CheckBox4CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Z|#4/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox4CK);

            CenterOfGravityZST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Center of Gravity Z|#4/[StaticText]Center of Gravity Z|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterOfGravityZST);

            CommentLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Comment|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentLBI);

            CheckBox5CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Comment|#5/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox5CK);

            CommentST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Comment|#5/[StaticText]Comment|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentST);

            DescriptionLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Description|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionLBI);

            CheckBox6CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Description|#6/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox6CK);

            DescriptionST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Description|#6/[StaticText]Description|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionST);

            InsulationSpecLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Spec|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationSpecLBI);

            CheckBox7CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Spec|#7/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox7CK);

            InsulationSpecST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Spec|#7/[StaticText]Insulation Spec|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationSpecST);

            InsulationThicknessLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Thickness|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationThicknessLBI);

            CheckBox8CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Thickness|#8/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox8CK);

            InsulationThicknessST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Thickness|#8/[StaticText]Insulation Thickness|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationThicknessST);

            InsulationTypeLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Type|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationTypeLBI);

            CheckBox9CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Type|#9/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox9CK);

            InsulationTypeST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Insulation Type|#9/[StaticText]Insulation Type|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InsulationTypeST);

            LineNumberTagLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Line Number Tag|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumberTagLBI);

            CheckBox10CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Line Number Tag|#10/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox10CK);

            LineNumberTagST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Line Number Tag|#10/[StaticText]Line Number Tag|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumberTagST);

            LockChangeAtLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Lock Change At|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LockChangeAtLBI);

            CheckBox11CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Lock Change At|#11/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox11CK);

            LockChangeAtST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Lock Change At|#11/[StaticText]Lock Change At|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LockChangeAtST);

            LockChangeByLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Lock Change By|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LockChangeByLBI);

            CheckBox12CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Lock Change By|#12/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox12CK);

            LockChangeByST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Lock Change By|#12/[StaticText]Lock Change By|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LockChangeByST);

            LockedLineStatusLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Locked Line Status|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LockedLineStatusLBI);

            CheckBox13CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Locked Line Status|#13/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox13CK);

            LockedLineStatusST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Locked Line Status|#13/[StaticText]Locked Line Status|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LockedLineStatusST);

            NominalSizeLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Nominal Size|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalSizeLBI);

            CheckBox14CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Nominal Size|#14/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox14CK);

            NominalSizeST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Nominal Size|#14/[StaticText]Nominal Size|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalSizeST);

            NominalSpecLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Nominal Spec|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalSpecLBI);

            CheckBox15CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Nominal Spec|#15/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox15CK);

            NominalSpecST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Nominal Spec|#15/[StaticText]Nominal Spec|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NominalSpecST);

            NumberLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Number|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberLBI);

            CheckBox16CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Number|#16/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox16CK);

            NumberST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]Plant 3D|$Plant3DTabItem|#1/[ListBox]Property:|$PlantPropertyListBox|#1/[ListBoxItem]Number|#16/[StaticText]Number|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NumberST);

            PCFWIN = new Window()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]PCF|$PCFTabItem|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFWIN);

            PCFST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl|#1/[Window]PCF|$PCFTabItem|#2/[StaticText]PCF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PCFST);

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
