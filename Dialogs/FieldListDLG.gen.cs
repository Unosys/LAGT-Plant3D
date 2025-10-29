// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$fieldListDockPanel1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class FieldListDLG : Pane
    {
        public  Pane PanePANE;
        public  TreeView TreeViewTV;
        public  TitleBar FieldListCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public FieldListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$fieldListDockPanel1_Container|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            TreeViewTV = new TreeView()
            {
                Tag = "[Pane]$fieldListDockPanel1_Container|#1/[TreeView]$39848112|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TreeViewTV);

            FieldListCTL = new TitleBar()
            {
                Tag = "[TitleBar]Field List|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldListCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Field List|#1/[PushButton]Close|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
