// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmVaultGetCheckOut", GUIType = GuiType.UIA)]
    public partial class GetCheckOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton zeroPB;
        public  PushButton HelpPB;
        public  PushButton CancelPB;
        public  PushButton OKPB;
        public  CheckBox GetLatestRelatedCK;
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  ListView ListViewLV;
        public  Header HeaderCTL;
        public  ListViewItem ListViewItem1LVI;
        public  ListViewItem ListViewItem2LVI;
        public  ListViewItem ListViewItem3LVI;
        public  ListViewItem ListViewItem4LVI;
        public  CustomWin VaultPathWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public GetCheckOutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            zeroPB = new PushButton()
            {
                Tag = "[PushButton]0|$m_btnComments|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zeroPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            GetLatestRelatedCK = new CheckBox()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[CheckBox]Get Latest Related|$m_chkBoxGetLatest|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GetLatestRelatedCK);

            PopupListPL = new PopupList()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[PopupList]$m_cmbBoxRevisions|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[PopupList]$m_cmbBoxRevisions|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            ListViewLV = new ListView()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            HeaderCTL = new Header()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            ListViewItem1LVI = new ListViewItem()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewItem1LVI);

            ListViewItem2LVI = new ListViewItem()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewItem2LVI);

            ListViewItem3LVI = new ListViewItem()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewItem3LVI);

            ListViewItem4LVI = new ListViewItem()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewItem4LVI);

            VaultPathWIN = new CustomWin()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]Vault Path|$HeaderItem 3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultPathWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Get *|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultGetCheckOut|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Get *|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Get *|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Get *|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
