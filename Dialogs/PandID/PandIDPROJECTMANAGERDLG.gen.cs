// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]PROJECTMANAGER", Parent = typeof(Plant3D), GUIType = GuiType.WIN32)]
    public partial class PandIDPROJECTMANAGERDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin PROJECTMANAGERWIN_1;
        public  CustomWin SourceFilesWIN;
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  Pane Pane3PANE;
        public  Pane Pane4PANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem DefaultProjectTVI;
        public  TreeViewItem PIDDrawingsTVI;
        public  TreeViewItem Plant3DDrawingsTVI;
        public  TreeViewItem RelatedFilesTVI;
        public  Pane LearnAboutProjects1PANE;
        public  Pane LearnAboutProjects2PANE;
        public  Pane Pane5PANE;
        public  StaticText ProjectXMLCUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADST;
        public  ScrollBar HorizontalScrollBarSB;
        public  PopupList CurrentProjectPL;
        public  PushButton DropDownButtonPB;
        public  StaticText CurrentProjectST;
        public  ToolBar ToolStrip1TB;
        public  PushButton PushButtonPB;
        public  MenuItem ToolStripDropDownButton1MI;
        public  MenuItem DataManagerMI;
        public  CustomWin CustomWin1WIN;
        public  MenuItem ExportDataMI;
        public  MenuItem ImportDataMI;
        public  CustomWin CustomWin2WIN;
        public  PushButton PushButton2PB;
        public  MenuItem ReportsMI;

        partial void OnInitialize();

        public PandIDPROJECTMANAGERDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PROJECTMANAGERWIN_1 = new CustomWin()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PROJECTMANAGERWIN_1);

            SourceFilesWIN = new CustomWin()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SourceFilesWIN);

            Pane1PANE = new Pane()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            Pane3PANE = new Pane()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]$1573736",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Pane4PANE = new Pane()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]$1573736/[Pane]$m_collapsiblePanelTreeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]$1573736/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            DefaultProjectTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]$1573736/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView/[TreeViewItem]Default Project",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultProjectTVI);

            PIDDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]$1573736/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView/[TreeViewItem]Default Project/[TreeViewItem]P*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PIDDrawingsTVI);

            Plant3DDrawingsTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]$1573736/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView/[TreeViewItem]Default Project/[TreeViewItem]Plant 3D Drawings",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DDrawingsTVI);

            RelatedFilesTVI = new TreeViewItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]$1573736/[Pane]$m_collapsiblePanelTreeView/[TreeView]$m_treeView/[TreeViewItem]Default Project/[TreeViewItem]Related Files",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RelatedFilesTVI);

            LearnAboutProjects1PANE = new Pane()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]Learn about Projects|$1443056",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnAboutProjects1PANE);

            LearnAboutProjects2PANE = new Pane()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]Learn about Projects|$1443056/[Pane]Learn about Projects|$m_collapsiblePanelAdditionalInfo",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LearnAboutProjects2PANE);

            Pane5PANE = new Pane()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]Learn about Projects|$1443056/[Pane]Learn about Projects|$m_collapsiblePanelAdditionalInfo/[Pane]$m_AdditionalInfoUserCtrl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane5PANE);

            ProjectXMLCUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADST = new StaticText()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]Learn about Projects|$1443056/[Pane]Learn about Projects|$m_collapsiblePanelAdditionalInfo/[Pane]$m_AdditionalInfoUserCtrl/[StaticText]Project XML: C:*|$m_lblDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectXMLCUsersAdministratorW7EN1ENUx64VM7AppDataRoamingAutodeskAutodeskAutoCADST);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[Pane]$splitContainer1/[Pane]Learn about Projects|$1443056/[Pane]Learn about Projects|$m_collapsiblePanelAdditionalInfo/[Pane]$m_AdditionalInfoUserCtrl/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            CurrentProjectPL = new PopupList()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[PopupList]Current Project:|$m_comboPrjFiles",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[PopupList]Current Project:|$m_comboPrjFiles/[PushButton]Drop Down Button|$DropDown",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            CurrentProjectST = new StaticText()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[StaticText]Current Project:|$mCurrentProjLbl",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentProjectST);

            ToolStrip1TB = new ToolBar()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolStrip1TB);

            PushButtonPB = new PushButton()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection/[PushButton]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            ToolStripDropDownButton1MI = new MenuItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection/[MenuItem]toolStripDropDownButton1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolStripDropDownButton1MI);

            DataManagerMI = new MenuItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection/[MenuItem]toolStripDropDownButton1/[MenuItem]Data Manager*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataManagerMI);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection/[MenuItem]toolStripDropDownButton1/[CustomWin]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            ExportDataMI = new MenuItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection/[MenuItem]toolStripDropDownButton1/[MenuItem]Export Data*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ExportDataMI);

            ImportDataMI = new MenuItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection/[MenuItem]toolStripDropDownButton1/[MenuItem]Import Data*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImportDataMI);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection/[MenuItem]toolStripDropDownButton1/[CustomWin]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            PushButton2PB = new PushButton()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[PushButton]$10001",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            ReportsMI = new MenuItem()
            {
                Tag = "[CustomWin]PROJECTMANAGER|$16717/[CustomWin]Source Files|$1/[Pane]$ControlAxSourcingSite/[ToolBar]toolStrip1|$m_ButtonCollection/[MenuItem]toolStripDropDownButton1/[MenuItem]Reports*",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReportsMI);
        }
    }
}
