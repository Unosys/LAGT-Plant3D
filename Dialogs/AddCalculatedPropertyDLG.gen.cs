// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Calculated Property|$Window_1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class AddCalculatedPropertyDLG : Window
    {
        public  PushButton CancelPB;
        public  PushButton AddPropertyPB;
        public  TreeView TreeViewTV;
        public  TreeViewItem SystemWindowsControlsTreeViewItemHeaderItemsCount8TVI;
        public  PushButton PushButton1PB;
        public  StaticText FunctionsST;
        public  TreeViewItem SystemWindowsControlsTreeViewItemHeaderItemsCount53TVI;
        public  PushButton PushButton2PB;
        public  StaticText PropertiesST;
        public  TreeViewItem SystemWindowsControlsTreeViewItemHeaderItemsCount7TVI;
        public  PushButton PushButton3PB;
        public  StaticText OperatorSymbolsST;

        partial void OnInitialize();

        public AddCalculatedPropertyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Button_4|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            AddPropertyPB = new PushButton()
            {
                Tag = "[PushButton]$Button_2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPropertyPB);

            TreeViewTV = new TreeView()
            {
                Tag = "[TreeView]$TreeView_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            SystemWindowsControlsTreeViewItemHeaderItemsCount8TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsControlsTreeViewItemHeaderItemsCount8TVI);

            PushButton1PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_1|#1/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            FunctionsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_1|#1/[StaticText]Functions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FunctionsST);

            SystemWindowsControlsTreeViewItemHeaderItemsCount53TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_7|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsControlsTreeViewItemHeaderItemsCount53TVI);

            PushButton2PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_7|#2/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PropertiesST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_7|#2/[StaticText]Properties|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PropertiesST);

            SystemWindowsControlsTreeViewItemHeaderItemsCount7TVI = new TreeViewItem()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_8|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemWindowsControlsTreeViewItemHeaderItemsCount7TVI);

            PushButton3PB = new PushButton()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_8|#3/[PushButton]$Expander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            OperatorSymbolsST = new StaticText()
            {
                Tag = "[TreeView]$TreeView_1|#1/[TreeViewItem]$TreeViewItem_8|#3/[StaticText]Operator Symbols|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OperatorSymbolsST);
        }
    }
}
