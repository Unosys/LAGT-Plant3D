// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Rename Folder|$frmRenameDrawing", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class RenameFolderDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  TextField FolderNameTF;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public RenameFolderDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[Pane]$m_panel_buttons|#1/[PushButton]OK|$btnOK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$m_panel_buttons|#1/[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            FolderNameTF = new TextField()
            {
                Tag = "[GroupBox]$m_gb_drawing_name|#1/[Pane]$m_panel_filename|#1/[TextField]Folder name:|$m_tb_filename|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderNameTF);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Rename Folder|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
