// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Property|$IsometricAddProperty", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AddPropertyPropertyChanges : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar AddPropertyCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;
        public  Window Plant3DWIN;
        public  StaticText Plant3DST;
        public  Window PCFWIN;
        public  StaticText PCFST;
        public  Window SymbolsWIN;
        public  StaticText Symbols1ST;
        public  StaticText Symbols2ST;
        public  ListBox SymbolsLB;
        public  ListBoxItem CenterlineLBI;
        public  CheckBox CheckBox1CK;
        public  StaticText CenterlineST;
        public  ListBoxItem DiameterLBI;
        public  CheckBox CheckBox2CK;
        public  StaticText DiameterST;
        public  ListBoxItem DatumPointLBI;
        public  CheckBox CheckBox3CK;
        public  StaticText DatumPointST;
        public  PushButton AddPropertyPB;
        public  StaticText AddPropertyST;
        public  PushButton CancelPB;
        public  StaticText CancelST;

        partial void OnInitialize();

        public AddPropertyPropertyChanges()
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
                Tag = "[PageList]$AddPropertyTabControl/[Window]$TabItem_1|#1",
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

            PCFWIN = new Window()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]$TabItem_2|#2",
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
                Tag = "[PageList]$AddPropertyTabControl/[Window]$SymbolsTabItem|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsWIN);

            Symbols1ST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]$SymbolsTabItem|#3/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Symbols1ST);

            Symbols2ST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[StaticText]Symbols:|$TextBlock_6|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Symbols2ST);

            SymbolsLB = new ListBox()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsLB);

            CenterlineLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Centerline ?|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterlineLBI);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Centerline ?|#1/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            CenterlineST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Centerline ?|#1/[StaticText]Centerline ?|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterlineST);

            DiameterLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Diameter ?|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiameterLBI);

            CheckBox2CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Diameter ?|#2/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox2CK);

            DiameterST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Diameter ?|#2/[StaticText]Diameter ?|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiameterST);

            DatumPointLBI = new ListBoxItem()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Datum Point ?|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatumPointLBI);

            CheckBox3CK = new CheckBox()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Datum Point ?|#3/[CheckBox]$PropertyCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox3CK);

            DatumPointST = new StaticText()
            {
                Tag = "[PageList]$AddPropertyTabControl/[Window]Symbols|$SymbolsTabItem|#3/[ListBox]Symbols:|$SymbolListBox|#1/[ListBoxItem]Datum Point ?|#3/[StaticText]Datum Point ?|$PropertyNameTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatumPointST);

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
