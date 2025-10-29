// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]New DWG|$frmNewDWG_Revised", Parent = typeof(CustomWin), GUIType = GuiType.UIA)]
    public partial class PandIDNewDWGDLG : Pane
    {
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  TextField AuthorTF;
        public  StaticText AuthorST;
        public  Pane Pane2PANE;
        public  TextField FileNameTF;
        public  PushButton PushButtonPB;
        public  TextField DWGTemplateTF;
        public  TextField FolderPathTF;
        public  TitleBar NewDWGCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public PandIDNewDWGDLG()
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

            AuthorTF = new TextField()
            {
                Tag = "[GroupBox]$m_gb_drawing_properties/[TextField]Author:|$m_textBoxAuthor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthorTF);

            AuthorST = new StaticText()
            {
                Tag = "[GroupBox]$m_gb_drawing_properties/[StaticText]Author:|$m_StaticAuthor|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthorST);

            Pane2PANE = new Pane()
            {
                Tag = "[GroupBox]$m_gb_drawing_name|#1/[Pane]$m_panel_filename|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            FileNameTF = new TextField()
            {
                Tag = "[GroupBox]$m_gb_drawing_name|#1/[Pane]$m_panel_filename|#1/[TextField]$m_tb_filename|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTF);

            PushButtonPB = new PushButton()
            {
                Tag = "[GroupBox]$m_gb_project_properties/[PushButton]$m_dwtBrowseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            DWGTemplateTF = new TextField()
            {
                Tag = "[GroupBox]$m_gb_project_properties/[TextField]$tbDWGTemplate|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGTemplateTF);

            FolderPathTF = new TextField()
            {
                Tag = "[GroupBox]$m_gb_project_properties/[TextField]$tbFolderPath|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FolderPathTF);

            NewDWGCTL = new TitleBar()
            {
                Tag = "[TitleBar]New DWG|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewDWGCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]New DWG|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
