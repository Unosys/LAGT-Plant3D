// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]$SpecAndCatalogV2Window")]
    public partial class SpecEditorDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TitleBar AutodeskAutoCADPlant3DCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton RestorePB;
        public  PushButton ClosePB;
        public  PushButton MaximizePB;
        public  ListViewItem Item1;
        public  Menu MenuMNU;
        public  MenuItem FileMI;
        public  StaticText FileST;
        public  MenuItem New;
        public  MenuItem NewSpec;
        public  MenuItem NewSpecFromExisting;
        public  MenuItem NewCatalogFromExisting;
        public  MenuItem OpenSpecmenu;
        public  MenuItem OpenCatalog;
        public  MenuItem OpenRecent;
        public  MenuItem ClearList;
        public  MenuItem Convert;
        public  MenuItem MigrateSpecsCatalogs;
        public  MenuItem MigrateCW;
        public  MenuItem MigrateSpecsCatalogsFromCSV;
        public  MenuItem MigrateSettings;
        public  MenuItem AutoPlantSetting;
        public  MenuItem CADWorxSetting;
        public  MenuItem CSVSetting;
        public  MenuItem Save;
        public  MenuItem SaveAs;
        public  MenuItem SaveAll;
        public  MenuItem ExportToCatalogBuilder;
        public  MenuItem Export;
        public  MenuItem CloseMenu;
        public  MenuItem CloseAll;
        public  MenuItem PrintPreview;
        public  MenuItem Print;
        public  MenuItem Exit;
        public  MenuItem EditMI;
        public  StaticText EditST;
        public  MenuItem Undo;
        public  MenuItem Redo;
        public  MenuItem Cut;
        public  MenuItem Copy;
        public  MenuItem Paste;
        public  MenuItem SpecsMI;
        public  StaticText SpecsST;
        public  MenuItem EditValveOperators;
        public  MenuItem LayoutAndSettings;
        public  MenuItem UseAsBranch;
        public  MenuItem CheckForCatalogUpdates;
        public  MenuItem AssignWallThickness;
        public  MenuItem BatchAssignLDStyles;
        public  MenuItem SynchronizeSpecWithCat;
        public  MenuItem SpecUpdateSettings;
        public  MenuItem CatalogsMI;
        public  StaticText CatalogsST;
        public  MenuItem ModifyCatalogProperties;
        public  MenuItem DuplicateComponent;
        public  MenuItem EditBoltLengthMapping;
        public  MenuItem ImperialUnitsEdit;
        public  MenuItem MetricUnitsEdit;
        public  MenuItem ToolsMI;
        public  MenuItem LaunchCatalogBuilder;
        public  MenuItem MigrateSpecsAndCatalogs;
        public  MenuItem ModifySharedContentFolder;
        public  MenuItem HelpMI;
        public  MenuItem Help;
        public  MenuItem ShowWelcomeScreen;
        public  PushButton PushButton2PB;
        public  PushButton PushButton3PB;
        public  PushButton SavePB;
        public  PushButton PushButton5PB;
        public  PushButton PushButton6PB;
        public  PushButton PushButton7PB;
        public  PushButton PushButton8PB;
        public  PushButton CutPB;
        public  PushButton CopyPB;
        public  PushButton PastePB;
        public  PushButton AddNotesToGroupButton;
        public  PushButton ExportToExcel;
        public  PushButton ImportFromExcel;
        public  PushButton SpecPB;
        public  PushButton BranchTablePB;
        public  PushButton CatalogEditor;
        public  ListView SpecSheetListView;
        public  ListViewItem SpecSheetEditorRow1LVI;
        public  ListViewItem SpecSheetEditorRow2LVI;
        public  ListViewItem BoltSetRow3LVI;
        public  PushButton PropertyEditorPB;
        public  PushButton EditInCatalogPB;
        public  PushButton PushButton14PB;
        public  TextField ManufacturerTF;
        public  PushButton BlockNamePB;
        public  PushButton ValveOperatorPB;
        public  ListView CatalogBrowserLV;

        partial void OnInitialize();

        public SpecEditorDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            AutodeskAutoCADPlant3DCTL = new TitleBar()
            {
                Tag = "[TitleBar]$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutodeskAutoCADPlant3DCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]$TitleBar|#1/[CustomWin]System Menu Bar|$SystemMenuBar|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            RestorePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Restore|$Restore|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RestorePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            Item1 = new ListViewItem()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_CatalogPartGroupSelection|#2/[CustomWin]$UserControl_1|#3/[ListView]$CatalogPartListView|#1/[ListViewItem]Autodesk*[5]|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Item1);

            MenuMNU = new Menu()
            {
                Tag = "[Menu]$MainMenu|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MenuMNU);

            FileMI = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileMI);

            FileST = new StaticText()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[StaticText]_File|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileST);

            New = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$New",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(New);

            NewSpec = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$New/[MenuItem]$NewSpec",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewSpec);

            NewSpecFromExisting = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$New/[MenuItem]$NewSpecFromExisting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewSpecFromExisting);

            NewCatalogFromExisting = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$New/[MenuItem]$NewCatalogFromExisting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewCatalogFromExisting);

            OpenSpecmenu = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$OpenSpec",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenSpecmenu);

            OpenCatalog = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$OpenCatalog",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenCatalog);

            OpenRecent = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$OpenRecent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenRecent);

            ClearList = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$OpenRecent/[MenuItem]$ClearList",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClearList);

            Convert = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Convert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Convert);

            MigrateSpecsCatalogs = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Convert/[MenuItem]$MigrateSpecsCatalogs",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigrateSpecsCatalogs);

            MigrateCW = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Convert/[MenuItem]$MigrateCW",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigrateCW);

            MigrateSpecsCatalogsFromCSV = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Convert/[MenuItem]$MigrateSpecsCatalogsFromCSV",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigrateSpecsCatalogsFromCSV);

            MigrateSettings = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Convert/[MenuItem]$MigrateSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigrateSettings);

            AutoPlantSetting = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Convert/[MenuItem]$MigrateSettings/[MenuItem]$AutoPlantSetting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AutoPlantSetting);

            CADWorxSetting = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Convert/[MenuItem]$MigrateSettings/[MenuItem]$CADWorxSetting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CADWorxSetting);

            CSVSetting = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Convert/[MenuItem]$MigrateSettings/[MenuItem]$CSVSetting",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CSVSetting);

            Save = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Save",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Save);

            SaveAs = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$SaveAs",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAs);

            SaveAll = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$SaveAll",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAll);

            ExportToCatalogBuilder = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$ExportToCatalogBuilder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportToCatalogBuilder);

            Export = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Export",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Export);

            CloseMenu = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$CloseMenu",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseMenu);

            CloseAll = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$CloseAll",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseAll);

            PrintPreview = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$PrintPreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrintPreview);

            Print = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Print",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Print);

            Exit = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]File|$FileMenu|#1/[MenuItem]$Exit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Exit);

            EditMI = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Edit|$EditMenu|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditMI);

            EditST = new StaticText()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Edit|$EditMenu|#2/[StaticText]Edit|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditST);

            Undo = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Edit|$EditMenu|#2/[MenuItem]$Undo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Undo);

            Redo = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Edit|$EditMenu|#2/[MenuItem]$Redo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Redo);

            Cut = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Edit|$EditMenu|#2/[MenuItem]$Cut",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cut);

            Copy = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Edit|$EditMenu|#2/[MenuItem]$Copy",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Copy);

            Paste = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Edit|$EditMenu|#2/[MenuItem]$Paste",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Paste);

            SpecsMI = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecsMI);

            SpecsST = new StaticText()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[StaticText]Specs|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecsST);

            EditValveOperators = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[MenuItem]$EditValveOperators",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditValveOperators);

            LayoutAndSettings = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[MenuItem]$LayoutAndSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayoutAndSettings);

            UseAsBranch = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[MenuItem]$UseAsBranch",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UseAsBranch);

            CheckForCatalogUpdates = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[MenuItem]$CheckForCatalogUpdates",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckForCatalogUpdates);

            AssignWallThickness = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[MenuItem]$AssignWallThickness",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AssignWallThickness);

            BatchAssignLDStyles = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[MenuItem]$BatchAssignLDStyles",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BatchAssignLDStyles);

            SynchronizeSpecWithCat = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[MenuItem]$SynchronizeSpecsWithCatalogs",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SynchronizeSpecWithCat);

            SpecUpdateSettings = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Specs|$Specs|#3/[MenuItem]$SpecUpdateSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettings);

            CatalogsMI = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Catalogs|$Catalogs|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogsMI);

            CatalogsST = new StaticText()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Catalogs|$Catalogs|#4/[StaticText]Catalogs|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogsST);

            ModifyCatalogProperties = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Catalogs|$Catalogs|#4/[MenuItem]$ModifyCatalogProperties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifyCatalogProperties);

            DuplicateComponent = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Catalogs|$Catalogs|#4/[MenuItem]$DuplicateComponent",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DuplicateComponent);

            EditBoltLengthMapping = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Catalogs|$Catalogs|#4/[MenuItem]$EditBoltLengthMapping",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditBoltLengthMapping);

            ImperialUnitsEdit = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Catalogs|$Catalogs|#4/[MenuItem]$ImperialUnitsEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImperialUnitsEdit);

            MetricUnitsEdit = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Catalogs|$Catalogs|#4/[MenuItem]$MetricUnitsEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MetricUnitsEdit);

            ToolsMI = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Tools|$Tools|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolsMI);

            LaunchCatalogBuilder = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Tools|$Tools|#5/[MenuItem]$LaunchCatalogBuilder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LaunchCatalogBuilder);

            MigrateSpecsAndCatalogs = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Tools|$Tools|#5/[MenuItem]$MigrateSpecsAndCatalogs",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MigrateSpecsAndCatalogs);

            ModifySharedContentFolder = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Tools|$Tools|#5/[MenuItem]$ModifySharedContentFolder",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifySharedContentFolder);

            HelpMI = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Help|$HelpMenuItem|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpMI);

            Help = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Help|$HelpMenuItem|#6/[MenuItem]$Help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            ShowWelcomeScreen = new MenuItem()
            {
                Tag = "[Menu]$MainMenu|#1/[MenuItem]Help|$HelpMenuItem|#6/[MenuItem]$ShowWelcomeScreen",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowWelcomeScreen);

            PushButton2PB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$NewFileButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$OpenButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            SavePB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$SaveButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            PushButton5PB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$SaveAllButton|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            PushButton6PB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$PrintButton|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton6PB);

            PushButton7PB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$ExportToExcel|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton7PB);

            PushButton8PB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$ImportFromExcel|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton8PB);

            CutPB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]Cut|$CutButton|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CutPB);

            CopyPB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]Copy|$CopyButton|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CopyPB);

            PastePB = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]Paste|$PasteButton|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PastePB);

            AddNotesToGroupButton = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[CustomWin]$UserControl_1|#1/[PushButton]$AddNotesToGroupButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddNotesToGroupButton);

            ExportToExcel = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$ExportToExcel|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportToExcel);

            ImportFromExcel = new PushButton()
            {
                Tag = "[ToolBar]$ToolBar|#1/[PushButton]$ImportFromExcel|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportFromExcel);

            SpecPB = new PushButton()
            {
                Tag = "[PushButton]$SpecTab|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecPB);

            BranchTablePB = new PushButton()
            {
                Tag = "[PushButton]$BranchTableTab|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BranchTablePB);

            CatalogEditor = new PushButton()
            {
                Tag = "[PushButton]$CatalogTab|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogEditor);

            SpecSheetListView = new ListView()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[CustomWin]$UserControl_SpecListView|#1/[ListView]$SpecSheetListView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheetListView);

            SpecSheetEditorRow1LVI = new ListViewItem()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[CustomWin]$UserControl_SpecListView|#1/[ListView]$SpecSheetListView|#1/[ListViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheetEditorRow1LVI);

            SpecSheetEditorRow2LVI = new ListViewItem()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[CustomWin]$UserControl_SpecListView|#1/[ListView]$SpecSheetListView|#1/[ListViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecSheetEditorRow2LVI);

            BoltSetRow3LVI = new ListViewItem()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[CustomWin]$UserControl_SpecListView|#1/[ListView]$SpecSheetListView|#1/[ListViewItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BoltSetRow3LVI);

            PropertyEditorPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[PushButton]$PropertyEditorButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyEditorPB);

            EditInCatalogPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[PushButton]$EditInCatalogBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditInCatalogPB);

            PushButton14PB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[PushButton]$SaveSpecBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton14PB);

            ManufacturerTF = new TextField()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_SpecSheetV2|#1/[Pane]$PartFamilyScrollViewer|#1/[CustomWin]$local:PartFamilyProps_1|#1/[ListView]$dataGrid|#1/[ListViewItem]#3/[CustomWin]#2/[TextField]$dataGrid_cellTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ManufacturerTF);

            BlockNamePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[CustomWin]$UserControl_PartSizeList|#1/[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_PartSizeProps|#1/[ListView]$dataGrid|#1/[ListViewItem]#7/[CustomWin]#2/[CustomWin]$UserControl_1|#1/[PushButton]$EmbeddedButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BlockNamePB);

            ValveOperatorPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogPropsV2|#1/[CustomWin]$UserControl_PartSizeList|#1/[Pane]$ScrollViewer_1|#1/[CustomWin]$UserControl_PartSizeProps|#1/[ListView]$dataGrid|#1/[ListViewItem]#8/[CustomWin]#2/[CustomWin]$UserControl_1|#1/[PushButton]$EmbeddedButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValveOperatorPB);

            CatalogBrowserLV = new ListView()
            {
                Tag = "[CustomWin]$UserControl_TabContainer|#2/[CustomWin]$UserControl_CatalogComponents|#2/[CustomWin]$UserControl_CatalogListView|#1/[ListView]$CatalogPartListView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogBrowserLV);
        }
    }
}
