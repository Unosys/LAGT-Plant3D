// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Ortho Table Setup|$Window_BOMSetup", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class OrthoDWGSettingsTableSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar OrthoTableSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;
        public  ListBox ListBoxLB;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable1LBI;
        public  StaticText PipingBOM1ST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable2LBI;
        public  StaticText EquipmentBOMST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable3LBI;
        public  StaticText NozzleListST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable4LBI;
        public  StaticText SteelBOMST;
        public  ListBoxItem AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable5LBI;
        public  StaticText SpoolListST;
        public  PageList PageListPG;
        public  Window SettingsWIN;
        public  StaticText SettingsST;
        public  Window TableLayoutWIN;
        public  StaticText TableLayoutST;
        public  CustomWin CustomWin1WIN;
        public  CustomWin CustomWin2WIN;
        public  PopupList PopupListPL;
        public  CheckBox CheckBox1CK;
        public  StaticText EnablePipingBOMInST;
        public  CustomWin CustomWin3WIN;
        public  ListView ListViewLV;
        public  PushButton ManageComponentsPB;
        public  PushButton AddColumnPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;

        partial void OnInitialize();

        public OrthoDWGSettingsTableSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OrthoTableSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Ortho Table Setup|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoTableSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Ortho Table Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Ortho Table Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Ortho Table Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ListBoxLB = new ListBox()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable1LBI = new ListBoxItem()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable1LBI);

            PipingBOM1ST = new StaticText()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#1/[StaticText]Piping BOM|$TextBlock_TableType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingBOM1ST);

            AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable2LBI = new ListBoxItem()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable2LBI);

            EquipmentBOMST = new StaticText()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#2/[StaticText]Equipment BOM|$TextBlock_TableType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentBOMST);

            AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable3LBI = new ListBoxItem()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable3LBI);

            NozzleListST = new StaticText()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#3/[StaticText]Nozzle List|$TextBlock_TableType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzleListST);

            AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable4LBI = new ListBoxItem()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable4LBI);

            SteelBOMST = new StaticText()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#4/[StaticText]Steel BOM|$TextBlock_TableType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SteelBOMST);

            AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable5LBI = new ListBoxItem()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupOrthoBOMSetupDlgBOMTable5LBI);

            SpoolListST = new StaticText()
            {
                Tag = "[ListBox]$ListView_TableTypes|#1/[ListBoxItem]#5/[StaticText]Spool List|$TextBlock_TableType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolListST);

            PageListPG = new PageList()
            {
                Tag = "[PageList]$TabControl_Table|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PageListPG);

            SettingsWIN = new Window()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsWIN);

            SettingsST = new StaticText()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]Settings|$TabItem_Settings|#2/[StaticText]Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SettingsST);

            TableLayoutWIN = new Window()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutWIN);

            TableLayoutST = new StaticText()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[StaticText]Table Layout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutST);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CustomWin]$UserControl_BOMSetupLayout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            PopupListPL = new PopupList()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CustomWin]$UserControl_BOMSetupLayout|#1/[PopupList]$ComboBox_Layout|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            CheckBox1CK = new CheckBox()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CheckBox]$CheckBox_EnableTable|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBox1CK);

            EnablePipingBOMInST = new StaticText()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[StaticText]Enable  Piping BOM  in Orthos:|$TextBlock_EnableTable|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnablePipingBOMInST);

            CustomWin3WIN = new CustomWin()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CustomWin]$UserControl_BOMSetupTable|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin3WIN);

            ListViewLV = new ListView()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CustomWin]$UserControl_BOMSetupTable|#2/[ListView]$TableGrid|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            ManageComponentsPB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CustomWin]$UserControl_BOMSetupTable|#2/[PushButton]Manage Components|$Button_ManageComponents|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManageComponentsPB);

            AddColumnPB = new PushButton()
            {
                Tag = "[PageList]$TabControl_Table|#1/[Window]$TabItem_TableLayout|#1/[CustomWin]$UserControl_BOMSetupTabs|#1/[CustomWin]$UserControl_BOMSetupTable|#2/[PushButton]Add Column|$Button_AddColumn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddColumnPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Button_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$Button_OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
