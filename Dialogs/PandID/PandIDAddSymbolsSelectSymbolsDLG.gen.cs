// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$SelectSymbolDlg")]
    public partial class PandIDAddSymbolsSelectSymbolsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText Label1;
        public  StaticText Label2;
        public  StaticText Label3;
        public  PushButton M_AddBtn;
        public  StaticText M_AvaibleBlockPreviewStatic;
        public  GroupBox M_AvaiblePrevewGroupBox;
        public  ListBox M_AvailableBlockLB;
        public  PushButton M_BrowseBtn;
        public  PushButton M_HelpBtn;
        public  PushButton M_NextBtn;
        public  PushButton M_RemoveBtn;
        public  ListBox M_SelectedBlockLB;
        public  StaticText M_SelectedBlockPreviewStatic;
        public  ComboBox M_SelectedDrawingCB;
        public  TextField M_SelectedDrawingCBTextField;
        public  GroupBox M_SelectedPrevewGroupBox;
        public  GroupBox Panel3;
        public  GroupBox Panel4;
        public  GroupBox TableLayoutPanel1;
        public  GroupBox TableLayoutPanel2;
        public  GroupBox TableLayoutPanel3;

        partial void OnInitialize();

        public PandIDAddSymbolsSelectSymbolsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            Label2 = new StaticText()
            {
                Tag = "[StaticText]$label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label2);

            Label3 = new StaticText()
            {
                Tag = "[StaticText]$label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label3);

            M_AddBtn = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]Selected Blocks: [2]|$tableLayoutPanel2|#3/[PushButton]$m_AddBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_AddBtn);

            M_AvaibleBlockPreviewStatic = new StaticText()
            {
                Tag = "[StaticText]$m_AvaibleBlockPreviewStatic",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_AvaibleBlockPreviewStatic);

            M_AvaiblePrevewGroupBox = new GroupBox()
            {
                Tag = "[GroupBox]$m_AvaiblePrevewGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_AvaiblePrevewGroupBox);

            M_AvailableBlockLB = new ListBox()
            {
                Tag = "[ListBox]$m_AvailableBlockLB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_AvailableBlockLB);

            M_BrowseBtn = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]Selected Blocks: [1]|$panel4|#2/[PushButton]$m_BrowseBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_BrowseBtn);

            M_HelpBtn = new PushButton()
            {
                Tag = "[PushButton]$m_HelpBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_HelpBtn);

            M_NextBtn = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]No preview available|$panel3|#4/[PushButton]$m_NextBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_NextBtn);

            M_RemoveBtn = new PushButton()
            {
                Tag = "[PushButton]$m_RemoveBtn",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_RemoveBtn);

            M_SelectedBlockLB = new ListBox()
            {
                Tag = "[ListBox]$m_SelectedBlockLB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_SelectedBlockLB);

            M_SelectedBlockPreviewStatic = new StaticText()
            {
                Tag = "[StaticText]$m_SelectedBlockPreviewStatic",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_SelectedBlockPreviewStatic);

            M_SelectedDrawingCB = new ComboBox()
            {
                Tag = "[ComboBox]$m_SelectedDrawingCB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_SelectedDrawingCB);

            M_SelectedDrawingCBTextField = new TextField()
            {
                Tag = "[TextField]$m_SelectedDrawingCB",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_SelectedDrawingCBTextField);

            M_SelectedPrevewGroupBox = new GroupBox()
            {
                Tag = "[GroupBox]$m_SelectedPrevewGroupBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_SelectedPrevewGroupBox);

            Panel3 = new GroupBox()
            {
                Tag = "[GroupBox]$panel3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel3);

            Panel4 = new GroupBox()
            {
                Tag = "[GroupBox]$panel4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel4);

            TableLayoutPanel1 = new GroupBox()
            {
                Tag = "[GroupBox]$tableLayoutPanel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPanel1);

            TableLayoutPanel2 = new GroupBox()
            {
                Tag = "[GroupBox]$tableLayoutPanel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPanel2);

            TableLayoutPanel3 = new GroupBox()
            {
                Tag = "[GroupBox]$tableLayoutPanel3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableLayoutPanel3);
        }
    }
}
