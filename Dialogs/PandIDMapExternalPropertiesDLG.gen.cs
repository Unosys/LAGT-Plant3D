// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Map External Properties|$Window_1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class PandIDMapExternalPropertiesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar MapExternalPropertiesCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;
        public  StaticText ExternalDataReferenceST;
        public  ListView ExternalDataReferenceLV;
        public  ListViewItem AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem1LVI;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay1WIN;
        public  StaticText Plant3DClassST;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay2WIN;
        public  TextField TextField1TF;
        public  Pane Pane1PANE;
        public  ListViewItem AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem2LVI;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay3WIN;
        public  StaticText ReferenceDataSourceST;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay4WIN;
        public  PushButton AddDataSourcePB;
        public  StaticText AddDataSourceST;
        public  ListViewItem AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem3LVI;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay5WIN;
        public  StaticText ReferencedTableST;
        public  CustomWin ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay6WIN;
        public  TextField TextField2TF;
        public  Pane Pane2PANE;
        public  PushButton MapPropertiesPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public PandIDMapExternalPropertiesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            MapExternalPropertiesCTL = new TitleBar()
            {
                Tag = "[TitleBar]Map External Properties|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MapExternalPropertiesCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Map External Properties|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Map External Properties|$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Map External Properties|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Map External Properties|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Map External Properties|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ExternalDataReferenceST = new StaticText()
            {
                Tag = "[StaticText]External Data Reference|$DataReferenceTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExternalDataReferenceST);

            ExternalDataReferenceLV = new ListView()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExternalDataReferenceLV);

            AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem1LVI = new ListViewItem()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem1LVI);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay1WIN = new CustomWin()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay1WIN);

            Plant3DClassST = new StaticText()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#1/[StaticText]Plant 3D Class|$dataGrid_nameCellTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassST);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay2WIN = new CustomWin()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay2WIN);

            TextField1TF = new TextField()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#2/[TextField]$dataGrid_valueCell2TextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            Pane1PANE = new Pane()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#1/[CustomWin]Item: Autodesk*|#2/[TextField]$dataGrid_valueCell2TextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem2LVI = new ListViewItem()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem2LVI);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay3WIN = new CustomWin()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay3WIN);

            ReferenceDataSourceST = new StaticText()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#1/[StaticText]Reference Data Source|$dataGrid_nameCellTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReferenceDataSourceST);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay4WIN = new CustomWin()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay4WIN);

            AddDataSourcePB = new PushButton()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#2/[PushButton]Add Data Source*|$AddDataSourceBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddDataSourcePB);

            AddDataSourceST = new StaticText()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#2/[CustomWin]Item: Autodesk*|#2/[PushButton]Add Data Source*|$AddDataSourceBtn|#1/[StaticText]Add Data Source*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddDataSourceST);

            AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem3LVI = new ListViewItem()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItem3LVI);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay5WIN = new CustomWin()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay5WIN);

            ReferencedTableST = new StaticText()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#1/[StaticText]Referenced Table|$dataGrid_nameCellTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReferencedTableST);

            ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay6WIN = new CustomWin()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ItemAutodeskProcessPowerProjectManagerUIProjectSetupExternalDatabaseDataGridRowSourceItemColumnDisplay6WIN);

            TextField2TF = new TextField()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#2/[TextField]$dataGrid_valueCell2TextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            Pane2PANE = new Pane()
            {
                Tag = "[ListView]External Data Reference|$DataReferenceDataGrid|#1/[ListViewItem]Autodesk*|#3/[CustomWin]Item: Autodesk*|#2/[TextField]$dataGrid_valueCell2TextBox|#1/[Pane]$PART_ContentHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            MapPropertiesPB = new PushButton()
            {
                Tag = "[PushButton]Map Properties|$MapPropertiesBtn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MapPropertiesPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelBtn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
