// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$NewReportTemplateDlg")]
    public partial class PandIDNewReportCopyOfControlValveListDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnContinue;
        public  PushButton M_btnReplaceTable;
        public  StaticText M_lblNameText;
        public  StaticText M_lblStartWithText;
        public  ComboBox M_lstFormatNames;
        public  TextField M_tbFormatName;

        partial void OnInitialize();

        public PandIDNewReportCopyOfControlValveListDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnContinue = new PushButton()
            {
                Tag = "[PushButton]$m_btnContinue",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnContinue);

            M_btnReplaceTable = new PushButton()
            {
                Tag = "[PushButton]$m_btnReplaceTable",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnReplaceTable);

            M_lblNameText = new StaticText()
            {
                Tag = "[StaticText]$m_lblNameText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblNameText);

            M_lblStartWithText = new StaticText()
            {
                Tag = "[StaticText]$m_lblStartWithText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblStartWithText);

            M_lstFormatNames = new ComboBox()
            {
                Tag = "[ComboBox]$m_lstFormatNames",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lstFormatNames);

            M_tbFormatName = new TextField()
            {
                Tag = "[TextField]New Report Name:|$m_tbFormatName|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tbFormatName);
        }
    }
}
