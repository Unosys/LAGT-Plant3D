// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Calculated Properties Manager|$XDbCalcPropertiesManagerDialog", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class CalculatedPropertiesManager : Pane
    {
        public  PushButton Close1PB;
        public  Window PnIdWIN;
        public  Pane PnIdPANE;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Window ClassDefinitionsWIN;
        public  Pane ClassDefinitionsPANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem EngineeringItemsTVI;
        public  TreeViewItem EquipmentTVI;
        public  TreeViewItem InLineAssetsTVI;
        public  TreeViewItem InstrumentationTVI;
        public  TreeViewItem LinesTVI;
        public  TreeViewItem NozzlesTVI;
        public  TreeViewItem NonEngineeringItemsTVI;
        public  TreeViewItem PipeLineGroupTVI;
        public  TreeViewItem SignalLineGroupTVI;
        public  TreeViewItem PnPWorkHistoryTVI;
        public  TreeViewItem PnPPainterStylesTVI;
        public  TreeViewItem PnPGlobalPainterStyleTVI;
        public  TreeViewItem PnPPainterColorSettingsTVI;
        public  TreeViewItem PnPProjectCategoriesTVI;
        public  TreeViewItem PnPProjectTVI;
        public  TreeViewItem PnPDrawingCategoriesTVI;
        public  TreeViewItem PnPPicklistsTVI;
        public  TreeViewItem PnPPicklistValuesTVI;
        public  TreeViewItem PnPProjectVariablesTVI;
        public  TreeViewItem PnPTagFormatTVI;
        public  TreeViewItem PnPAutoGenPropertiesTVI;
        public  TreeViewItem PnPDrawingCustomPropertiesTVI;
        public  TreeViewItem PnPGeometryTVI;
        public  Pane Pane4PANE;
        public  Pane Pane5PANE;
        public  ComboBox PropertyNameCB;
        public  PopupList PropertyNamePL;
        public  PushButton DropDownButtonPB;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  PushButton DeletePB;
        public  PushButton ApplyPB;
        public  StaticText PropertyNameST;
        public  StaticText DescriptionTextForExpressionST;
        public  TreeView DescriptionTextForExpressionTV;
        public  PushButton PushButton3PB;
        public  PushButton PushButton4PB;
        public  PushButton PushButton5PB;
        public  PushButton PushButton6PB;
        public  PushButton PushButton7PB;
        public  TextField PropertyNameTF;
        public  Window PipingWIN;
        public  Window IsoWIN;
        public  Window OrthoWIN;
        public  Window MiscWIN;
        public  TitleBar CalculatedPropertiesManagerCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton Close2PB;

        partial void OnInitialize();

        public CalculatedPropertiesManager()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close1PB = new PushButton()
            {
                Tag = "[PushButton]Close|$m_btnClose|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close1PB);

            PnIdWIN = new Window()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnIdWIN);

            PnIdPANE = new Pane()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnIdPANE);

            Pane1PANE = new Pane()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            ClassDefinitionsWIN = new Window()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassDefinitionsWIN);

            ClassDefinitionsPANE = new Pane()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassDefinitionsPANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            EngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]EngineeringItems|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EngineeringItemsTVI);

            EquipmentTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]EngineeringItems|#1/[TreeViewItem]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTVI);

            InLineAssetsTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]EngineeringItems|#1/[TreeViewItem]InLineAssets|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InLineAssetsTVI);

            InstrumentationTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]EngineeringItems|#1/[TreeViewItem]Instrumentation|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(InstrumentationTVI);

            LinesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]EngineeringItems|#1/[TreeViewItem]Lines|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LinesTVI);

            NozzlesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]EngineeringItems|#1/[TreeViewItem]Nozzles|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NozzlesTVI);

            NonEngineeringItemsTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]NonEngineeringItems|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NonEngineeringItemsTVI);

            PipeLineGroupTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PipeLineGroup|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineGroupTVI);

            SignalLineGroupTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]SignalLineGroup|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignalLineGroupTVI);

            PnPWorkHistoryTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPWorkHistory|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPWorkHistoryTVI);

            PnPPainterStylesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPPainterStyles|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPPainterStylesTVI);

            PnPGlobalPainterStyleTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPGlobalPainterStyle|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPGlobalPainterStyleTVI);

            PnPPainterColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPPainterColorSettings|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPPainterColorSettingsTVI);

            PnPProjectCategoriesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPProjectCategories|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPProjectCategoriesTVI);

            PnPProjectTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPProject|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPProjectTVI);

            PnPDrawingCategoriesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPDrawingCategories|#11",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPDrawingCategoriesTVI);

            PnPPicklistsTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPPicklists|#12",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPPicklistsTVI);

            PnPPicklistValuesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPPicklistValues|#13",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPPicklistValuesTVI);

            PnPProjectVariablesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPProjectVariables|#14",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPProjectVariablesTVI);

            PnPTagFormatTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPTagFormat|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPTagFormatTVI);

            PnPAutoGenPropertiesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPAutoGenProperties|#16",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPAutoGenPropertiesTVI);

            PnPDrawingCustomPropertiesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPDrawingCustomProperties|#17",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPDrawingCustomPropertiesTVI);

            PnPGeometryTVI = new TreeViewItem()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$593854|#1/[PageList]$m_tabCtrlClassDef|#1/[Window]Class Definitions|#1/[Pane]Class Definitions|$m_tabPageClassDef|#1/[TreeView]$m_treeViewClasses|#1/[TreeViewItem]PnPGeometry|#18",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PnPGeometryTVI);

            Pane4PANE = new Pane()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            PropertyNameCB = new ComboBox()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[ComboBox]Property name:|$m_cmbPropName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameCB);

            PropertyNamePL = new PopupList()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PopupList]Property name:|$m_cmbType|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNamePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PopupList]Property name:|$m_cmbType|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            PushButton1PB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton])|$m_btnCloseParen|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton](|$m_btnOpenParen|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            DeletePB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton]Delete|$m_btnDelete|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            ApplyPB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton]Apply|$m_btnAppy|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            PropertyNameST = new StaticText()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[StaticText]Property name:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameST);

            DescriptionTextForExpressionST = new StaticText()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[StaticText]<Description text for expression item>|$m_textHelp|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionTextForExpressionST);

            DescriptionTextForExpressionTV = new TreeView()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[TreeView]<Description text for expression item>|$m_tvOperands|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionTextForExpressionTV);

            PushButton3PB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton]|||$m_btnConcat|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            PushButton4PB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton]**|$m_btnDivide|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton4PB);

            PushButton5PB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton]*|$m_btnMultiply|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton5PB);

            PushButton6PB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton]-|$m_btnMinus|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton6PB);

            PushButton7PB = new PushButton()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[PushButton]+|$m_btnPlus|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton7PB);

            PropertyNameTF = new TextField()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]PnId|#1/[Pane]PnId|$659264|#1/[Pane]$m_calcPropManagerCtrl|#1/[Pane]$m_splitContainer|#1/[Pane]$524366|#2/[Pane]$ExpressionBuilderControl|#1/[TextField]Property name:|$m_expressionText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameTF);

            PipingWIN = new Window()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]Piping|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingWIN);

            IsoWIN = new Window()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]Iso|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoWIN);

            OrthoWIN = new Window()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]Ortho|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoWIN);

            MiscWIN = new Window()
            {
                Tag = "[PageList]$m_tabCtrlPrjParts|#1/[Window]Misc|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MiscWIN);

            CalculatedPropertiesManagerCTL = new TitleBar()
            {
                Tag = "[TitleBar]Calculated Properties Manager|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CalculatedPropertiesManagerCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Calculated Properties Manager|$TitleBar|#1/[CustomWin]System Menu Bar|$XDbCalcPropertiesManagerDialog|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Calculated Properties Manager|$TitleBar|#1/[CustomWin]System Menu Bar|$XDbCalcPropertiesManagerDialog|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Calculated Properties Manager|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Calculated Properties Manager|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            Close2PB = new PushButton()
            {
                Tag = "[TitleBar]Calculated Properties Manager|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
