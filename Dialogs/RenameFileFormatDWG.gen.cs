// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Rename DWG", Parent = typeof(Plant3D))]
    public partial class RenameFileFormatDWG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin DrawingName1;
        public  PushButton OK;
        public  PushButton Cancel;
        public  StaticText DrawingName2;
        public  StaticText RenamingWillCauseAllExtern1;
        public  CustomWin RenamingWillCauseAllExtern2;
        public  CustomWin DrawingNamePropertyItem;
        public  TextField Test;
        public  StaticText TestText;
        public  CustomWin RenamingWillCauseAllExtern3;
        public  TextField FileName;
        public  CheckBox Override;
        public  StaticText FileNameText;

        partial void OnInitialize();

        public RenameFileFormatDWG()
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

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

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
                Tag = "[CustomWin][System.Windows.Forms.Panel]Renaming will cause all external references to this drawing to be broken.[1]|[System.Windows.Forms.Panel]#1|[System.Windows.Forms.Panel]$m_panel_property_names",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenamingWillCauseAllExtern2);

            DrawingNamePropertyItem = new CustomWin()
            {
                Tag = "[CustomWin][Autodesk.ProcessPower.ProjectManagerUI.DrawingNamePropertyItem]#1|[Autodesk.ProcessPower.ProjectManagerUI.DrawingNamePropertyItem]$DrawingNamePropertyItem",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DrawingNamePropertyItem);

            Test = new TextField()
            {
                Tag = "[TextField]Test :|#1|$m_tb_property_value",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Test);

            TestText = new StaticText()
            {
                Tag = "[StaticText]Test :|#1|$m_lb_name",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TestText);

            RenamingWillCauseAllExtern3 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]Renaming will cause all external references to this drawing to be broken.[2]|[System.Windows.Forms.Panel]#2|[System.Windows.Forms.Panel]$m_panel_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RenamingWillCauseAllExtern3);

            FileName = new TextField()
            {
                Tag = "[TextField]File name:|#1|$m_tb_filename",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            Override = new CheckBox()
            {
                Tag = "[CheckBox]Override|#1|$m_cb_override",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Override);

            FileNameText = new StaticText()
            {
                Tag = "[StaticText]File name:|#1|$lblFileName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);
        }
    }
}
