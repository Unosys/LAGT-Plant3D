// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$EditProjectSettingsDlg", Parent = typeof(Plant3D))]
    public partial class PIDObjectMappingDLG : Pane
    {
        public  TreeView M_treeClasses;
        public  PushButton AddPB;
        public  PushButton DeletePB;
        public  PushButton EditPB;
        public  ListBox NoImageLB;
        public  ListBoxItem P3dLineGroupLBI;
        public  ListBoxItem EquipmentLBI;
        public  TreeViewItem PipeLineGroupdeuTVI;
        public  TreeViewItem PipeLineGroupTVI;
        public  TreeViewItem SignalLineGroupTVI;

        partial void OnInitialize();

        public PIDObjectMappingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_treeClasses = new TreeView()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]$25100524|#1/[Pane]$m_splitVert|#1/[Pane]$10617086|#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]$groupBox1|#1/[TreeView]$m_treeClasses|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_treeClasses);

            AddPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]$groupBox1|#1/[Pane]$m_panelMapping|#1/[PushButton]Add*|$Btn_AddNewMapping|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            DeletePB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]$groupBox1|#1/[Pane]$m_panelMapping|#1/[PushButton]Delete|$Btn_Delete|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeletePB);

            EditPB = new PushButton()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]$groupBox1|#1/[Pane]$m_panelMapping|#1/[PushButton]Edit*|$Btn_Edit|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EditPB);

            NoImageLB = new ListBox()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]$groupBox1|#1/[Pane]$m_panelMapping|#1/[ListBox]$m_listBox3DClassMappings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoImageLB);

            P3dLineGroupLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]$groupBox1|#1/[Pane]$m_panelMapping|#1/[ListBox]$m_listBox3DClassMappings|#1/[ListBoxItem]P3d Line Group|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(P3dLineGroupLBI);

            EquipmentLBI = new ListBoxItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]$groupBox1|#1/[Pane]$m_panelMapping|#1/[ListBox]$m_listBox3DClassMappings|#1/[ListBoxItem]Equipment|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentLBI);

            PipeLineGroupdeuTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]P*|$groupBox1|#1/[TreeView]P*|$m_treeClasses|#1/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineGroupdeuTVI);

            PipeLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]P*|$groupBox1|#1/[TreeView]P*|$m_treeClasses|#1/[TreeViewItem]Pipe Line Group|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PipeLineGroupTVI);

            SignalLineGroupTVI = new TreeViewItem()
            {
                Tag = "[Pane]$m_splitHorz|#1/[Pane]#1/[Pane]$m_splitVert|#1/[Pane]#2/[Pane]$m_pnidObjectMapping|#1/[GroupBox]P*|$groupBox1|#1/[TreeView]P*|$m_treeClasses|#1/[TreeViewItem]Signal Line Group|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SignalLineGroupTVI);
        }
    }
}
