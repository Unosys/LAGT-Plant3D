// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class ProjectSetupPalnt3DAnnotationDLG : Pane
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem GeneralSettingsTVI;
        public  TreeViewItem ProjectDetailsTVI;
        public  TreeViewItem DatabaseSetupTVI;
        public  TreeViewItem DrawingPropertiesTVI;
        public  TreeViewItem ReportsTVI;
        public  TreeViewItem FileNameFormatTVI;
        public  TreeViewItem PIDDWGSettingsTVI;
        public  TreeViewItem Plant3DDWGSettingsTVI;
        public  TreeViewItem ExportAndImportSettingsTVI;
        public  TreeViewItem PathsTVI;
        public  TreeViewItem DataManagerConfigurationTVI;
        public  TreeViewItem LayerAndColorSettingsTVI;
        public  TreeViewItem PipingConnectionSettingsTVI;
        public  TreeViewItem PIDObjectMappingTVI;
        public  TreeViewItem Plant3DClassDefinitionsTVI;
        public  TreeViewItem P3dLineGroupTVI;
        public  TreeViewItem PipingAndEquipmentTVI;
        public  TreeViewItem EquipmentTVI;
        public  TreeViewItem FastenersTVI;
        public  TreeViewItem PipeRunComponentTVI;
        public  TreeViewItem SteelStructureTVI;
        public  TreeViewItem SpecUpdateSettingsTVI;
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox ClassSettingsPipingAndGB;
        public  GroupBox OrthoAnnotationSetupGB;
        public  PushButton RemoveAnnotationPB;
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  PushButton AddAnnotationPB;
        public  PushButton M_btnModifyAnn;
        public  PushButton M_btnEditAnn;
        public  Pane NoPreviewAvailablePANE;
        public  GroupBox SymbolGB;
        public  StaticText NoPreviewAvailableST;
        public  GroupBox PropertiesGB;
        public  PushButton RemovePB;
        public  Table DataGridViewTBL;
        public  Pane VerticalScrollBarPANE;
        public  CustomWin TopRowWIN;
        public  Header PropertyNameCTL;
        public  Header PropertyDescriptionCTL;
        public  Header DisplayNameCTL;
        public  Header DefaultValueCTL;
        public  Header PropertyTypeCTL;
        public  Header AcquisitionCTL;
        public  Header ReadOnlyCTL;
        public  Header VisibleInAreaViewCTL;
        public  Header VisibleInObjectViewCTL;
        public  CustomWin Row0WIN;
        public  CustomWin PropertyNameRow0WIN;
        public  CustomWin PropertyDescriptionRow0WIN;
        public  CustomWin DisplayNameRow0WIN;
        public  CustomWin DefaultValueRow0WIN;
        public  CustomWin PropertyTypeRow0WIN;
        public  CustomWin AcquisitionRow0WIN;
        public  CustomWin ReadOnlyRow0WIN;
        public  CustomWin VisibleInAreaViewWIN;
        public  CustomWin VisibleInObjectViewWIN;
        public  PushButton EditPB;
        public  PushButton AddPB;
        public  GroupBox TagFormatGB;
        public  PushButton DeletePB;
        public  PushButton ModifyPB;
        public  PushButton NewPB;
        public  ListBox ListBoxLB;
        public  Pane Pane7PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectSetupPalnt3DAnnotationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            ExportAndImportSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Export and Import Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportAndImportSettingsTVI);

            PathsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Paths|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PathsTVI);

            DataManagerConfigurationTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Data Manager Configuration|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerConfigurationTVI);

            LayerAndColorSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Layer and Color Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LayerAndColorSettingsTVI);

            PipingConnectionSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Piping Connection Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingConnectionSettingsTVI);

            PIDObjectMappingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]P*|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDObjectMappingTVI);

            Plant3DClassDefinitionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassDefinitionsTVI);

            P3dLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]P3d Line Group|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dLineGroupTVI);

            PipingAndEquipmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]Piping and Equipment|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingAndEquipmentTVI);

            EquipmentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]Piping and Equipment|#2/[TreeViewItem]Equipment|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTVI);

            FastenersTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]Piping and Equipment|#2/[TreeViewItem]Fasteners|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FastenersTVI);

            PipeRunComponentTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]Piping and Equipment|#2/[TreeViewItem]Pipe Run Component|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeRunComponentTVI);

            SteelStructureTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Plant 3D Class Definitions|#7/[TreeViewItem]Steel Structure|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SteelStructureTVI);

            SpecUpdateSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3/[TreeViewItem]Spec Update Settings|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecUpdateSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$23595104|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            ClassSettingsPipingAndGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClassSettingsPipingAndGB);

            OrthoAnnotationSetupGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Ortho Annotation Setup|$m_groupBoxAnn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoAnnotationSetupGB);

            RemoveAnnotationPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Ortho Annotation Setup|$m_groupBoxAnn|#4/[PushButton]Remove Annotation*|$m_btnRemoveAnn|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemoveAnnotationPB);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Ortho Annotation Setup|$m_groupBoxAnn|#4/[PopupList]$m_comboBoxAnn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Ortho Annotation Setup|$m_groupBoxAnn|#4/[PopupList]$m_comboBoxAnn|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            AddAnnotationPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Ortho Annotation Setup|$m_groupBoxAnn|#4/[PushButton]Add Annotation*|$m_btnAddAnn|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddAnnotationPB);

            M_btnModifyAnn = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Ortho Annotation Setup|$m_groupBoxAnn|#4/[PushButton]Edit Annotation*|$m_btnModifyAnn|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModifyAnn);

            M_btnEditAnn = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Ortho Annotation Setup|$m_groupBoxAnn|#4/[PushButton]Edit Block*|$m_btnEditAnn|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnEditAnn);

            NoPreviewAvailablePANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Ortho Annotation Setup|$m_groupBoxAnn|#4/[Pane]No preview available|$148704202|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPreviewAvailablePANE);

            SymbolGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolGB);

            NoPreviewAvailableST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Symbol|$m_GroupBoxGraphical|#1/[StaticText]No preview available|$m_PreviewStatic|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPreviewAvailableST);

            PropertiesGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesGB);

            RemovePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Remove|$m_btnRemoveProperties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);

            DataGridViewTBL = new Table()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[Pane]Vertical Scroll Bar|$29755918|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            TopRowWIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TopRowWIN);

            PropertyNameCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Name|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameCTL);

            PropertyDescriptionCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Description|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyDescriptionCTL);

            DisplayNameCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Display Name|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameCTL);

            DefaultValueCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Default Value|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueCTL);

            PropertyTypeCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Property Type|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTypeCTL);

            AcquisitionCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Acquisition|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionCTL);

            ReadOnlyCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Read Only|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadOnlyCTL);

            VisibleInAreaViewCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Visible in Area View|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisibleInAreaViewCTL);

            VisibleInObjectViewCTL = new Header()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Top Row|#1/[Header]Visible in Object View|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisibleInObjectViewCTL);

            Row0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row0WIN);

            PropertyNameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Name Row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyNameRow0WIN);

            PropertyDescriptionRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Description Row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyDescriptionRow0WIN);

            DisplayNameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Display Name Row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DisplayNameRow0WIN);

            DefaultValueRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Default Value Row 0|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultValueRow0WIN);

            PropertyTypeRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Property Type Row 0|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertyTypeRow0WIN);

            AcquisitionRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Acquisition Row 0|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AcquisitionRow0WIN);

            ReadOnlyRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Read Only Row 0|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReadOnlyRow0WIN);

            VisibleInAreaViewWIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Visible in Area View Row 0|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisibleInAreaViewWIN);

            VisibleInObjectViewWIN = new CustomWin()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[Table]DataGridView|$m_dataGridView|#1/[CustomWin]Row 0|#2/[CustomWin]Visible in Object View Row 0|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VisibleInObjectViewWIN);

            EditPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Edit*|$m_btnEditProperties|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditPB);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Properties|$m_groupBoxProperties|#2/[PushButton]Add*|$m_btnAddProperty|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            TagFormatGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TagFormatGB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]Delete|$m_btnDeleteTag|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            ModifyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]Modify*|$m_btnModifyTag|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifyPB);

            NewPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[PushButton]New*|$m_btnNewTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewPB);

            ListBoxLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$22809532|#1/[Pane]$m_splitVert|#1/[Pane]$383125948|#2/[Pane]$m_class3dPropertySettingsUserCtrl|#1/[GroupBox]Class settings: Piping and Equipment|$m_groupBox|#1/[GroupBox]Tag format|$m_groupBoxTag|#3/[ListBox]$m_listBoxTag|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9638430|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9638430|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9638430|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9638430|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$9638430|#2/[PushButton]Apply|$m_btnSave|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            ProjectSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[CustomWin]System Menu Bar|$EditProjectSettingsDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
