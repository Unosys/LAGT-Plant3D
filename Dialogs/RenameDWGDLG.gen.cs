// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Rename DWG", Parent = typeof(Plant3D))]
    public partial class RenameDWGDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DrawingName1;
        public  PushButton OK;
        public  PushButton CancelPB;
        public  StaticText DrawingName2;
        public  StaticText RenamingWillCauseAllExtern1;
        public  CustomWin RenamingWillCauseAllExtern2;
        public  StaticText FileNameText;
        public  TextField FileNameTF;

        partial void OnInitialize();

        public RenameDWGDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DrawingName1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]Drawing name|[System.Windows.Forms.Panel]#1|[System.Windows.Forms.Panel]$m_panel_buttons",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingName1);

            OK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            DrawingName2 = new StaticText()
            {
                Tag = "[StaticText]Drawing name|#1|$m_gb_drawing_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingName2);

            RenamingWillCauseAllExtern1 = new StaticText()
            {
                Tag = "[StaticText]Renaming will cause all external references to this drawing to be broken.|#1|$m_warnTextLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenamingWillCauseAllExtern1);

            RenamingWillCauseAllExtern2 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]Renaming will cause all external references to this drawing to be broken.|[System.Windows.Forms.Panel]#1|[System.Windows.Forms.Panel]$m_panel_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenamingWillCauseAllExtern2);

            FileNameText = new StaticText()
            {
                Tag = "[StaticText]File name:|#1|$lblFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);

            FileNameTF = new TextField()
            {
                Tag = "[TextField]$m_tb_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTF);
        }
    }
}
