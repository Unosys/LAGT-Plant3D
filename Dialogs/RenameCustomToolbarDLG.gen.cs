// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Rename Toolbar|#1", Parent = typeof(CustomizationDLG), GUIType = GuiType.UIA)]
    public partial class RenameCustomToolbarDLG : Pane
    {
        public  Pane PanePANE;
        public  StaticText ToolbarNameST;
        public  TextField ToolbarNameTF;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  PushButton BtNBDlgCancel;
        public  PushButton BtNBDlgOk;
        public  TitleBar RenameToolbarCTL;

        partial void OnInitialize();

        public RenameCustomToolbarDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$pnlNBDlg",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            ToolbarNameST = new StaticText()
            {
                Tag = "[Pane]$pnlNBDlg/[StaticText]Toolbar Name:|$lbNBDlgCaption",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarNameST);

            ToolbarNameTF = new TextField()
            {
                Tag = "[Pane]$pnlNBDlg/[TextField]Toolbar Name:|$tbNBDlgName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarNameTF);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$pnlNBDlg/[TextField]Toolbar Name:|$tbNBDlgName/[TextField]$2689126",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$pnlNBDlg/[TextField]Toolbar Name:|$tbNBDlgName/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            BtNBDlgCancel = new PushButton()
            {
                Tag = "[Pane]$pnlNBDlg/[PushButton]Cancel|$btNBDlgCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtNBDlgCancel);

            BtNBDlgOk = new PushButton()
            {
                Tag = "[Pane]$pnlNBDlg/[PushButton]OK|$btNBDlgOk",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtNBDlgOk);

            RenameToolbarCTL = new TitleBar()
            {
                Tag = "[TitleBar]Rename Toolbar|$TitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenameToolbarCTL);
        }
    }
}
