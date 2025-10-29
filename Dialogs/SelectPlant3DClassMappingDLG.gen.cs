// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$Select3DClassMappingDlg")]
    public partial class SelectPlant3DClassMappingDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TreeView Plant3DClassTV;
        public  TreeViewItem PipingAndEquipmentTVI;
        public  TreeViewItem EquipmentTVI;
        public  TreeViewItem P3dLineGroupTVI;
        public  CheckBox MapToAllSubtypesCK;

        partial void OnInitialize();

        public SelectPlant3DClassMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Btn_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$Btn_Ok|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            Plant3DClassTV = new TreeView()
            {
                Tag = "[TreeView]$m_treeClasses|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Plant3DClassTV);

            PipingAndEquipmentTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$m_treeClasses|#1/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipingAndEquipmentTVI);

            EquipmentTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$m_treeClasses|#1/[TreeViewItem]#2/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTVI);

            P3dLineGroupTVI = new TreeViewItem()
            {
                Tag = "[TreeView]$m_treeClasses|#1/[TreeViewItem]P3d Line Group|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dLineGroupTVI);

            MapToAllSubtypesCK = new CheckBox()
            {
                Tag = "[Pane]$panel1|#1/[CheckBox]$m_chkBoxMapAll|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MapToAllSubtypesCK);
        }
    }
}
