// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Create Iso Message|$IsoMessageDlg|#1", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class CreateIsogenMessageDLG : Pane
    {
        public  PushButton M_bt_help;
        public  PushButton M_bt_Cancel;
        public  PushButton M_bt_OK;
        public  TextField MessageTF;
        public  StaticText MessageST;
        public  CheckBox M_cb_dimToMsg;
        public  PopupList EncloseMessageInPL;
        public  PushButton DropDownButtonPB;
        public  StaticText EncloseMessageInST;
        public  Pane EncloseMessageInPANE;
        public  TitleBar CreateIsoMessageCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CreateIsogenMessageDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_bt_help = new PushButton()
            {
                Tag = "[PushButton]Help|$m_bt_help|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_help);

            M_bt_Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_bt_Cancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_Cancel);

            M_bt_OK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_bt_OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_bt_OK);

            MessageTF = new TextField()
            {
                Tag = "[TextField]Message:|$m_tb_MSG|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MessageTF);

            MessageST = new StaticText()
            {
                Tag = "[StaticText]Message:|$label2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MessageST);

            M_cb_dimToMsg = new CheckBox()
            {
                Tag = "[CheckBox]Draw dimension to message|$m_cb_dimToMsg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_cb_dimToMsg);

            EncloseMessageInPL = new PopupList()
            {
                Tag = "[PopupList]Enclose message in:|$m_cb_msg_Enc|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EncloseMessageInPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]Enclose message in:|$m_cb_msg_Enc|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            EncloseMessageInST = new StaticText()
            {
                Tag = "[StaticText]Enclose message in:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EncloseMessageInST);

            EncloseMessageInPANE = new Pane()
            {
                Tag = "[Pane]Enclose message in:|$852616|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EncloseMessageInPANE);

            CreateIsoMessageCTL = new TitleBar()
            {
                Tag = "[TitleBar]Create Iso Message|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateIsoMessageCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Create Iso Message|$TitleBar|#1/[CustomWin]System Menu Bar|$IsoMessageDlg|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Create Iso Message|$TitleBar|#1/[CustomWin]System Menu Bar|$IsoMessageDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Iso Message|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
