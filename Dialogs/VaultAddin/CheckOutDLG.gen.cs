// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Get *|$frmVaultGetCheckOut", Parent = typeof(PROJECTMANAGERDLG))]
    public partial class CheckOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText zeroKBST;
        public  StaticText zero1ST;
        public  Pane zero1PANE;
        public  StaticText zero2ST;
        public  Pane zero2PANE;
        public  PushButton CommentPB;
        public  PushButton SelectFilesToCheckPB;
        public  PushButton HelpPB;
        public  PushButton Cancel;
        public  PushButton OK;
        public  GroupBox zeroGB;
        public  CheckBox GetLatestRelatedCK;
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  ListView ListViewLV;
        public  Header HeaderCTL;
        public  CustomWin CustomWin1WIN;
        public  CustomWin CustomWin2WIN;
        public  CustomWin NameWIN;
        public  CustomWin VaultPathWIN;
        public  CustomWin FileSizeWIN;
        public  CustomWin CheckedOutByWIN;
        public  ScrollBar HorizontalScrollBarSB;
        public  ListViewItem ListViewItemLVI;
        public  StaticText StaticText1ST;
        public  StaticText NotCheckoutSameVersionST;
        public  StaticText Draw6dwgST;
        public  StaticText Proj2Plant3DModelsDraw6dwgST;
        public  StaticText one525KBST;
        public  StaticText StaticText2ST;
        public  TitleBar GetCheckOutCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CheckOutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            zeroKBST = new StaticText()
            {
                Tag = "[StaticText]0 KB|$m_lblDownloadSize|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zeroKBST);

            zero1ST = new StaticText()
            {
                Tag = "[StaticText]0[1]|$m_lblDownCount|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zero1ST);

            zero1PANE = new Pane()
            {
                Tag = "[Pane]0[1]|$pictureBox2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zero1PANE);

            zero2ST = new StaticText()
            {
                Tag = "[StaticText]0[2]|$m_lblChkOutCount|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zero2ST);

            zero2PANE = new Pane()
            {
                Tag = "[Pane]0[2]|$pictureBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zero2PANE);

            CommentPB = new PushButton()
            {
                Tag = "[PushButton]0|$m_btnComments|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentPB);

            SelectFilesToCheckPB = new PushButton()
            {
                Tag = "[PushButton]Select files to check out:|$m_btnComments",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectFilesToCheckPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$m_btnOK|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            zeroGB = new GroupBox()
            {
                Tag = "[GroupBox]0|$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(zeroGB);

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

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]$HeaderItem 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]$HeaderItem 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            NameWIN = new CustomWin()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]Name|$HeaderItem 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            VaultPathWIN = new CustomWin()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]Vault Path|$HeaderItem 3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultPathWIN);

            FileSizeWIN = new CustomWin()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]File Size|$HeaderItem 4|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileSizeWIN);

            CheckedOutByWIN = new CustomWin()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]Checked Out By|$HeaderItem 5|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckedOutByWIN);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            ListViewItemLVI = new ListViewItem()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewItemLVI);

            StaticText1ST = new StaticText()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText1ST);

            NotCheckoutSameVersionST = new StaticText()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]NotCheckoutSameVersion|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NotCheckoutSameVersionST);

            Draw6dwgST = new StaticText()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]Draw6*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Draw6dwgST);

            Proj2Plant3DModelsDraw6dwgST = new StaticText()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]**|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Proj2Plant3DModelsDraw6dwgST);

            one525KBST = new StaticText()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]115*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one525KBST);

            StaticText2ST = new StaticText()
            {
                Tag = "[GroupBox]0|$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticText2ST);

            GetCheckOutCTL = new TitleBar()
            {
                Tag = "[TitleBar]Get *|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GetCheckOutCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Get *|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultGetCheckOut|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

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
