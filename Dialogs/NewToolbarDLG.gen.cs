// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]New Toolbar", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class NewToolbarDLG : Pane
    {
        public  Pane PanePANE;
        public  StaticText ToolbarNameST;
        public  TextField ToolbarNameTF;
        public  TextField TextField1TF;
        public  TextField TextField2TF;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  TitleBar NewToolbarCTL;

        partial void OnInitialize();

        public NewToolbarDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            PanePANE = new Pane()
            {
                Tag = "[Pane]$pnlNBDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PanePANE);

            ToolbarNameST = new StaticText()
            {
                Tag = "[Pane]$pnlNBDlg|#1/[StaticText]Toolbar Name:|$lbNBDlgCaption|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarNameST);

            ToolbarNameTF = new TextField()
            {
                Tag = "[Pane]$pnlNBDlg|#1/[TextField]Toolbar Name:|$tbNBDlgName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolbarNameTF);

            TextField1TF = new TextField()
            {
                Tag = "[Pane]$pnlNBDlg|#1/[TextField]Toolbar Name:|$tbNBDlgName|#1/[TextField]$792616|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField1TF);

            TextField2TF = new TextField()
            {
                Tag = "[Pane]$pnlNBDlg|#1/[TextField]Toolbar Name:|$tbNBDlgName|#1/[TextField]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField2TF);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$pnlNBDlg|#1/[PushButton]Cancel|$btNBDlgCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[Pane]$pnlNBDlg|#1/[PushButton]OK|$btNBDlgOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            NewToolbarCTL = new TitleBar()
            {
                Tag = "[TitleBar]New Toolbar|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewToolbarCTL);
        }
    }
}
