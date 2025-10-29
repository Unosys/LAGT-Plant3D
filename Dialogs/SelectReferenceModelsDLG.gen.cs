// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Select Reference Models|$frmSelectRefModels", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class SelectReferenceModelsDLG : Pane
    {
        public  TextField M_textBox;
        public  PushButton M_btnHelp;
        public  PushButton M_btnCancel;
        public  PushButton M_btnOK;
        public  TreeView ProjectModelsTV;
        public  TreeViewItem four15201564910AMTVI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectReferenceModelsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_textBox = new TextField()
            {
                Tag = "[GroupBox]Details|$groupBox2/[TextField]$m_textBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_textBox);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnOK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOK);

            ProjectModelsTV = new TreeView()
            {
                Tag = "[TreeView]Project models:|$m_treeView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectModelsTV);

            four15201564910AMTVI = new TreeViewItem()
            {
                Tag = "[TreeView]Project models:|$m_treeView/[TreeViewItem]4_15_2015 6_49_10 AM",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(four15201564910AMTVI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Reference Models|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
