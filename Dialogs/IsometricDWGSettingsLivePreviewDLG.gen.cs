// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class IsometricDWGSettingsLivePreviewDLG : Pane
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
        public  TreeViewItem IsoStyleSetupTVI;
        public  TreeViewItem DefaultSettingsTVI;
        public  TreeViewItem AnnotationsTVI;
        public  TreeViewItem DimensionsTVI;
        public  TreeViewItem ThemesTVI;
        public  TreeViewItem SlopedAndOffsetPipingTVI;
        public  TreeViewItem TitleBlockAndDisplayTVI;
        public  TreeViewItem LivePreviewTVI;
        public  TreeViewItem OrthoDWGSettingsTVI;
        public  Pane Pane5PANE;
        public  Pane Pane6PANE;
        public  Pane IsoPreviewPANE;
        public  CheckBox SpoolFormatCK;
        public  PushButton PushButtonPB;
        public  Pane Pane7PANE;
        public  Pane CancelPANE;
        public  StaticText GeneratingIsoPreviewST;
        public  Link CancelLINK;
        public  Pane Pane8PANE;
        public  StaticText Sheet1Of1ST;
        public  PushButton Sheet1Of11PB;
        public  PushButton Sheet1Of12PB;
        public  StaticText SpecifyAPCFFileST;
        public  TextField SpecifyAPCFFileTF;
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  PushButton BtnBrowse;
        public  Pane Pane9PANE;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton ApplyPB;
        public  TitleBar ProjectSetupCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public IsometricDWGSettingsLivePreviewDLG()
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
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            GeneralSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneralSettingsTVI);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Project Details|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            DatabaseSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Database Setup|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DatabaseSetupTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Drawing Properties|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);

            ReportsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]Reports|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsTVI);

            FileNameFormatTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]General Settings|#1/[TreeViewItem]File Name Format|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameFormatTVI);

            PIDDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]P*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDWGSettingsTVI);

            Plant3DDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Plant 3D DWG Settings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDWGSettingsTVI);

            IsometricDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsometricDWGSettingsTVI);

            IsoStyleSetupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Iso Style Setup|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoStyleSetupTVI);

            DefaultSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Default Settings|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultSettingsTVI);

            AnnotationsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Annotations|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AnnotationsTVI);

            DimensionsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Dimensions|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DimensionsTVI);

            ThemesTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Themes|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThemesTVI);

            SlopedAndOffsetPipingTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Sloped and Offset Piping|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SlopedAndOffsetPipingTVI);

            TitleBlockAndDisplayTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Title Block and Display|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TitleBlockAndDisplayTVI);

            LivePreviewTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Isometric DWG Settings|#4/[TreeViewItem]Live Preview|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LivePreviewTVI);

            OrthoDWGSettingsTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$75369368|#1/[TreeView]$m_treeView|#1/[TreeViewItem]Ortho DWG Settings|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OrthoDWGSettingsTVI);

            Pane5PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            Pane6PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane6PANE);

            IsoPreviewPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IsoPreviewPANE);

            SpoolFormatCK = new CheckBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[CheckBox]Spool format|$checkBox_SpoolFormat|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpoolFormatCK);

            PushButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[PushButton]+|$button_NewIsoStyle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            Pane7PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[Pane]$panelIso|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane7PANE);

            CancelPANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[Pane]$panelIso|#1/[Pane]Cancel|$6819184|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPANE);

            GeneratingIsoPreviewST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[Pane]$panelIso|#1/[StaticText]Generating Iso Preview*|$labelAnim|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GeneratingIsoPreviewST);

            CancelLINK = new Link()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[Pane]$panelIso|#1/[Link]Cancel|$linkLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelLINK);

            Pane8PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[Pane]$panelIndex|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane8PANE);

            Sheet1Of1ST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[Pane]$panelIndex|#2/[StaticText]Sheet 1 of 1|$lblIndex|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Sheet1Of1ST);

            Sheet1Of11PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[Pane]$panelIndex|#2/[PushButton]Sheet 1 of 1[1]|$btnNext|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Sheet1Of11PB);

            Sheet1Of12PB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[Pane]$panelIndex|#2/[PushButton]Sheet 1 of 1[2]|$btnPrevious|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Sheet1Of12PB);

            SpecifyAPCFFileST = new StaticText()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[StaticText]Specify a PCF file for preview:|$labelPCF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyAPCFFileST);

            SpecifyAPCFFileTF = new TextField()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[TextField]Specify a PCF file for preview:|$txtboxPCF|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyAPCFFileTF);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[PopupList]$cmbboxIsoStyle|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$5771230|#1/[Pane]$m_splitVert|#1/[Pane]$5575092|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[PopupList]$cmbboxIsoStyle|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            BtnBrowse = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$24839872|#1/[Pane]$m_splitVert|#1/[Pane]$18548496|#2/[Pane]$m_isometricSetupPreviewUserCtrl|#1/[Pane]Iso Preview|$panel_Preview|#1/[PushButton]Browse*|$btnBrowse",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnBrowse);

            Pane9PANE = new Pane()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6033662|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane9PANE);

            HelpPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6033662|#2/[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6033662|#2/[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6033662|#2/[PushButton]OK|$m_btnOk|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            ApplyPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$6033662|#2/[PushButton]Apply|$m_btnSave|#1",
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
