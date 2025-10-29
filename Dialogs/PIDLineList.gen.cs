// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$ControlAxSourcingSite", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class PIDLineList : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane3PANE;
        public  TreeView TreeViewTV;
        public  TreeViewItem Node1TVI;
        public  PushButton PushButton1PB;
        public  StaticText one038ST;
        public  TreeViewItem Node2TVI;
        public  PushButton PushButton2PB;
        public  StaticText one039ST;
        public  PopupList PopupListPL;
        public  PushButton OpenPB;

        partial void OnInitialize();

        public PIDLineList()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$splitContainer1|#3/[Pane]#1/[Pane]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$splitContainer1|#3/[Pane]#2/[Pane]$m_ElementHost|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[TreeView]$LineListTree|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            Node1TVI = new TreeViewItem()
            {
                Tag = "[Pane]$splitContainer1|#3/[Pane]#2/[Pane]$m_ElementHost|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[TreeView]$LineListTree|#1/[TreeViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Node1TVI);

            PushButton1PB = new PushButton()
            {
                Tag = "[Pane]$splitContainer1|#3/[Pane]#2/[Pane]$m_ElementHost|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[TreeView]$LineListTree|#1/[TreeViewItem]#1/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            one038ST = new StaticText()
            {
                Tag = "[Pane]$splitContainer1|#3/[Pane]#2/[Pane]$m_ElementHost|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[TreeView]$LineListTree|#1/[TreeViewItem]#1/[StaticText]1038|$GroupText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one038ST);

            Node2TVI = new TreeViewItem()
            {
                Tag = "[Pane]$splitContainer1|#3/[Pane]#2/[Pane]$m_ElementHost|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[TreeView]$LineListTree|#1/[TreeViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Node2TVI);

            PushButton2PB = new PushButton()
            {
                Tag = "[Pane]$splitContainer1|#3/[Pane]#2/[Pane]$m_ElementHost|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[TreeView]$LineListTree|#1/[TreeViewItem]#2/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            one039ST = new StaticText()
            {
                Tag = "[Pane]$splitContainer1|#3/[Pane]#2/[Pane]$m_ElementHost|#1/[Pane]#1/[CustomWin]#1/[CustomWin]$UserControl_1|#1/[TreeView]$LineListTree|#1/[TreeViewItem]#2/[StaticText]1039|$GroupText|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one039ST);

            PopupListPL = new PopupList()
            {
                Tag = "[PopupList]$m_cmbDwgTitles|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            OpenPB = new PushButton()
            {
                Tag = "[PopupList]$m_cmbDwgTitles|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);
        }
    }
}
