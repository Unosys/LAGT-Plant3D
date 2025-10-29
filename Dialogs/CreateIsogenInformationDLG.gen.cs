// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$IsoInformationDlg", Parent = typeof(Plant3D))]
    public partial class CreateIsogenInformationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText Label1;
        public  PushButton M_bt_Cancel;
        public  PushButton M_bt_help;
        public  PushButton M_bt_OK;
        public  ComboBox M_cb_itemType;
        public  StaticText M_lb_preview;
        public  CustomWin M_pb_preview;

        partial void OnInitialize();

        public CreateIsogenInformationDLG()
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

            M_bt_Cancel = new PushButton()
            {
                Tag = "[PushButton]$m_bt_Cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_Cancel);

            M_bt_help = new PushButton()
            {
                Tag = "[PushButton]$m_bt_help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_help);

            M_bt_OK = new PushButton()
            {
                Tag = "[PushButton]$m_bt_OK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_OK);

            M_cb_itemType = new ComboBox()
            {
                Tag = "[ComboBox]$m_cb_itemType",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cb_itemType);

            M_lb_preview = new StaticText()
            {
                Tag = "[StaticText]$m_lb_preview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lb_preview);

            M_pb_preview = new CustomWin()
            {
                Tag = "[CustomWin]$m_pb_preview",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_pb_preview);
        }
    }
}
