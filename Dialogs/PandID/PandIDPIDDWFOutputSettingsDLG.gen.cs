// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$DWFOutputSettingsDlg")]
    public partial class PandIDPIDDWFOutputSettingsDLG : Pane
    {
        public  PushButton CancelBtn;
        public  Pane ObjectPropertiesPANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem ProjectDetailsTVI;
        public  TreeViewItem ProjectDataTVI;
        public  TreeViewItem ClientInformationTVI;
        public  TreeViewItem DrawingPropertiesTVI;

        partial void OnInitialize();

        public PandIDPIDDWFOutputSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelBtn = new PushButton()
            {
                Tag = "[PushButton]$cancelBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelBtn);

            ObjectPropertiesPANE = new Pane()
            {
                Tag = "[PageList]$propTabControl|#1/[Pane]$objPropPage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ObjectPropertiesPANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[PageList]$propTabControl|#1/[Pane]$sheetPropPage|#1/[Pane]$sheetPropSettingsCtrl|#1/[Pane]$panel1|#1/[TreeView]$m_classTreeView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            ProjectDetailsTVI = new TreeViewItem()
            {
                Tag = "[PageList]$propTabControl|#1/[Pane]$sheetPropPage|#1/[Pane]$sheetPropSettingsCtrl|#1/[Pane]$panel1|#1/[TreeView]$m_classTreeView|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDetailsTVI);

            ProjectDataTVI = new TreeViewItem()
            {
                Tag = "[PageList]$propTabControl|#1/[Pane]$sheetPropPage|#1/[Pane]$sheetPropSettingsCtrl|#1/[Pane]$panel1|#1/[TreeView]$m_classTreeView|#1/[TreeViewItem]#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectDataTVI);

            ClientInformationTVI = new TreeViewItem()
            {
                Tag = "[PageList]$propTabControl|#1/[Pane]$sheetPropPage|#1/[Pane]$sheetPropSettingsCtrl|#1/[Pane]$panel1|#1/[TreeView]$m_classTreeView|#1/[TreeViewItem]#1/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClientInformationTVI);

            DrawingPropertiesTVI = new TreeViewItem()
            {
                Tag = "[PageList]$propTabControl|#1/[Pane]$sheetPropPage|#1/[Pane]$sheetPropSettingsCtrl|#1/[Pane]$panel1|#1/[TreeView]$m_classTreeView|#1/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingPropertiesTVI);
        }
    }
}
