// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]$frmVaultCheckin")]
    public partial class CheckInDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText OpenDrawingsWillBeST;
        public  StaticText oneFiles7013ST;
        public  CheckBox CleanupCachedFilesCK;
        public  ListView ListViewLV;
        public  Header HeaderCTL;
        public  CustomWin CustomWinWIN;
        public  CustomWin NameWIN;
        public  CustomWin VaultPathWIN;
        public  CustomWin FileSizeWIN;
        public  ListViewItem ListViewItemLVI;
        public  StaticText StaticTextST;
        public  StaticText Draw6dwgST;
        public  StaticText Proj2Plant3DModelsDraw6dwgST;
        public  StaticText seven013KBST;
        public  PushButton HelpPB;
        public  CheckBox KeepFilesOpenForCK;
        public  PushButton Cancel;
        public  PushButton OK;
        public  StaticText CommentsToIncludeWithST;
        public  TextField CommentsToIncludeWithTF;
        public  Pane CreateVisualChecked;
        public  TitleBar CheckInDraw6dwgCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public CheckInDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenDrawingsWillBeST = new StaticText()
            {
                Tag = "[StaticText]Open drawings will be closed after check in|$m_lbCloseOpenDrawings|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenDrawingsWillBeST);

            oneFiles7013ST = new StaticText()
            {
                Tag = "[StaticText]1 files *|$m_lbIfo|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(oneFiles7013ST);

            CleanupCachedFilesCK = new CheckBox()
            {
                Tag = "[CheckBox]Cleanup cached files|$m_cbDeleteFiles|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CleanupCachedFilesCK);

            ListViewLV = new ListView()
            {
                Tag = "[ListView]$m_checkinLlistView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            HeaderCTL = new Header()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            CustomWinWIN = new CustomWin()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[Header]Header|$Header|#1/[CustomWin]$HeaderItem 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinWIN);

            NameWIN = new CustomWin()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[Header]Header|$Header|#1/[CustomWin]Name|$HeaderItem 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            VaultPathWIN = new CustomWin()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[Header]Header|$Header|#1/[CustomWin]Vault Path|$HeaderItem 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultPathWIN);

            FileSizeWIN = new CustomWin()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[Header]Header|$Header|#1/[CustomWin]File Size|$HeaderItem 3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileSizeWIN);

            ListViewItemLVI = new ListViewItem()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[ListViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewItemLVI);

            StaticTextST = new StaticText()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[ListViewItem]#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Draw6dwgST = new StaticText()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[ListViewItem]#1/[StaticText]Draw6*|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Draw6dwgST);

            Proj2Plant3DModelsDraw6dwgST = new StaticText()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[ListViewItem]#1/[StaticText]**|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Proj2Plant3DModelsDraw6dwgST);

            seven013KBST = new StaticText()
            {
                Tag = "[ListView]$m_checkinLlistView|#1/[ListViewItem]#1/[StaticText]70*|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(seven013KBST);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]Help|$btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);

            KeepFilesOpenForCK = new CheckBox()
            {
                Tag = "[CheckBox]Keep files open for editing after check in|$chkBoxKeepCheckOut|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(KeepFilesOpenForCK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOk|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            CommentsToIncludeWithST = new StaticText()
            {
                Tag = "[StaticText]Comments to include with this version:|$label1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentsToIncludeWithST);

            CommentsToIncludeWithTF = new TextField()
            {
                Tag = "[TextField]Comments to include with this version:|$txtBoxNotes|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentsToIncludeWithTF);

            CreateVisualChecked = new Pane()
            {
                Tag = "[Pane]Comments to include with this version:|$CreateVisualChecked|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateVisualChecked);

            CheckInDraw6dwgCTL = new TitleBar()
            {
                Tag = "[TitleBar]Check In - Draw6*|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckInDraw6dwgCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Check In - Draw6*|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultCheckin|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Check In - Draw6*|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultCheckin|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Check In - Draw6*|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
