// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Export Data|$PnPExportDataDlg", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class ExportDataDLG : Pane
    {
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  PushButton BrowsePB;
        public  TextField EnterFileNameAndTF;
        public  PopupList SelectExportSettingsPL;
        public  PushButton OpenPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ExportDataDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_buttonCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_buttonOK|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            BrowsePB = new PushButton()
            {
                Tag = "[PushButton]Browse*|$m_buttonBrowse|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BrowsePB);

            EnterFileNameAndTF = new TextField()
            {
                Tag = "[TextField]Enter file name and location for exported data:|$m_textBoxFile|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EnterFileNameAndTF);

            SelectExportSettingsPL = new PopupList()
            {
                Tag = "[PopupList]$m_comboBoxSettings|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectExportSettingsPL);

            OpenPB = new PushButton()
            {
                Tag = "[PopupList]Select export settings:|$m_comboBoxSettings|#1/[PushButton]Open|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Export Data|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
