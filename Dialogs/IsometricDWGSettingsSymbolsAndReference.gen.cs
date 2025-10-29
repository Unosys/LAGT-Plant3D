// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Project Setup|$EditProjectSettingsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class IsometricDWGSettingsSymbolsAndReference : Autodesk.GUIHarness.AutoCAD.AcDialogBox
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
        public  TreeViewItem IsometricDWGSettingsTVI;
        public  TreeViewItem SymbolsAndReferenceTVI;
        public  TreeViewItem IsoStyleSetupTVI;
        public  TreeViewItem IsoStyleDefaultSettingsTVI;
        public  TreeViewItem AnnotationsTVI;
        public  TreeViewItem DimensionsTVI;
        public  TreeViewItem ThemesTVI;
        public  TreeViewItem SlopedAndOffsetPipingTVI;
        public  TreeViewItem TitleBlockAndDisplayTVI;
        public  TreeViewItem LivePreviewTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  GroupBox SymbolsAndReferenceGB;
        public  GroupBox ReferenceDimensionDefaultSettingsGB;
        public  PushButton PushButtonPB;
        public  StaticText MessagePreviewST;
        public  PopupList CenterlineTypePL;
        public  PushButton DropDownButton1PB;
        public  StaticText CenterlineTypeST;
        public  TextField MessageTF;
        public  StaticText MessageST;
        public  PopupList EncloseMessageInPL;
        public  PushButton DropDownButton2PB;
        public  StaticText EncloseMessageInST;
        public  StaticText ReferenceObjectTypeST;
        public  ListBox ReferenceObjectTypeLB;
        public  ListBoxItem BuildingLBI;
        public  ListBoxItem EquipmentLBI;
        public  ListBoxItem FloorLevelLBI;
        public  ListBoxItem GridlineLBI;
        public  ListBoxItem SteelBeamLBI;
        public  ListBoxItem SteelColumnLBI;
        public  ListBoxItem PipelineLBI;
        public  ListBoxItem WallLBI;
        public  ListBoxItem MiscellaneousLBI;
        public  Pane NoPreviewAvailablePANE;
        public  GroupBox IsometricSymbologyGB;
        public  Pane Pane7PANE;
        public  PushButton EditIsometricSymbolsPB;
        public  StaticText ModifyTheDefaultIsoST;
        public  Pane Pane8PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public IsometricDWGSettingsSymbolsAndReference()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]General Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]Project Details",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]Database Setup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]Drawing Properties",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]Reports",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]General Settings/[TreeViewItem]File Name Format",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]P*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Plant 3D DWG Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            SymbolsAndReferenceTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Symbols and Reference",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsAndReferenceTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Iso Style Setup",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            IsoStyleDefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Iso Style Default Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleDefaultSettingsTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Annotations",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Dimensions",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Themes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Sloped and Offset Piping",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Title Block and Display",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Isometric DWG Settings/[TreeViewItem]Live Preview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$2623394/[TreeView]$m_treeView/[TreeViewItem]Ortho DWG Settings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_GeneralIsoSettingsUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            SymbolsAndReferenceGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SymbolsAndReferenceGB);

            ReferenceDimensionDefaultSettingsGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReferenceDimensionDefaultSettingsGB);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[PushButton]**|$m_btnClassProperty",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            MessagePreviewST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[StaticText]Message Preview:|$m_labelMessagePreview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MessagePreviewST);

            CenterlineTypePL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[PopupList]Centerline Type:|$m_comboCenterlineType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterlineTypePL);

            DropDownButton1PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[PopupList]Centerline Type:|$m_comboCenterlineType/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton1PB);

            CenterlineTypeST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[StaticText]Centerline Type:|$m_labelCenterlineType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CenterlineTypeST);

            MessageTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[TextField]Message:|$m_textMessage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MessageTF);

            MessageST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[StaticText]Message:|$m_labelMessage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MessageST);

            EncloseMessageInPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[PopupList]Enclose message in:|$m_comboEnclosure",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EncloseMessageInPL);

            DropDownButton2PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[PopupList]Enclose message in:|$m_comboEnclosure/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButton2PB);

            EncloseMessageInST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[StaticText]Enclose message in:|$m_lableEncloseMessage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EncloseMessageInST);

            ReferenceObjectTypeST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[StaticText]Reference Object Type:|$m_lableRefObjectType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReferenceObjectTypeST);

            ReferenceObjectTypeLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReferenceObjectTypeLB);

            BuildingLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Building",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BuildingLBI);

            EquipmentLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Equipment",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentLBI);

            FloorLevelLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Floor Level",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FloorLevelLBI);

            GridlineLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Gridline",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GridlineLBI);

            SteelBeamLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Steel Beam",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SteelBeamLBI);

            SteelColumnLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Steel Column",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SteelColumnLBI);

            PipelineLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Pipeline",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipelineLBI);

            WallLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Wall",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WallLBI);

            MiscellaneousLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[ListBox]Reference Object Type:|$m_listRefObjectType/[ListBoxItem]Miscellaneous",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MiscellaneousLBI);

            NoPreviewAvailablePANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Reference Dimension Default Settings|$m_groupBoxRefDim/[Pane]No preview available|$7145214",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPreviewAvailablePANE);

            IsometricSymbologyGB = new GroupBox()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Isometric Symbology|$m_groupBoxIsometricSymbology",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricSymbologyGB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Isometric Symbology|$m_groupBoxIsometricSymbology/[Pane]$m_pictureBox_IsoSymbology",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            EditIsometricSymbolsPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Isometric Symbology|$m_groupBoxIsometricSymbology/[PushButton]Edit Isometric Symbols*|$m_btnEditIsoSymbol",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditIsometricSymbolsPB);

            ModifyTheDefaultIsoST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$3015598/[Pane]$m_splitVert/[Pane]$4589378/[Pane]$m_GeneralIsoSettingsUserCtrl/[GroupBox]Symbols and Reference|$m_groupBoxGeneralIsoSettings/[GroupBox]Isometric Symbology|$m_groupBoxIsometricSymbology/[StaticText]Modify the default Iso Symbols using the AutoCAD Block Editor*|$m_labelEditIsoSymbol",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ModifyTheDefaultIsoST);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$4524038",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$4524038/[PushButton]Help|$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$4524038/[PushButton]OK|$m_btnOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz/[Pane]$4524038/[PushButton]Apply|$m_btnSave",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ApplyPB);

            ProjectSetupCTL = new TitleBar()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectSetupCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar/[CustomWin]System Menu Bar|$EditProjectSettingsDlg",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar/[CustomWin]System Menu Bar|$EditProjectSettingsDlg/[MenuItem]System|$Item 1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Project Setup|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
