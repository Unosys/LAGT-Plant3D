// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Select Vault Location|$SelectEntityFromVaultDialog", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class SelectVaultLocationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  Pane Pane1PANE;
        public  Pane Pane2PANE;
        public  StaticText LookInST;
        public  Pane LookInPANE;
        public  PopupList PopupListPL;
        public  PushButton DropDownButtonPB;
        public  ToolBar ToolStrip1TB;
        public  PushButton BackPB;
        public  PushButton MoveUpALevelPB;
        public  PushButton ChangeViewPB;
        public  Pane RevisionPANE;
        public  PushButton CancelPB;
        public  PushButton OpenPB;
        public  Pane Pane3PANE;
        public  Pane Proj2PANE;
        public  ComboBox ComboBoxCB;
        public  StaticText FileNameST;
        public  Pane Pane4PANE;
        public  Table TableTBL;
        public  CustomWin HeaderPanelWIN;
        public  Header CommentCTL;
        public  Header CheckedInCTL;
        public  Header ThumbnailCTL;
        public  Header NameCTL;
        public  Header EntityIconCTL;
        public  Header VaultStatusCTL;
        public  Header VaultStatusModifierCTL;
        public  CustomWin DataPanelWIN;
        public  CustomWin Row1WIN;
        public  CustomWin EntityIconRow0WIN;
        public  CustomWin VaultStatusRow0WIN;
        public  CustomWin NameRow0WIN;
        public  CustomWin VaultStatusModifierRow1WIN;
        public  CustomWin CheckedInRow0WIN;
        public  CustomWin CommentRow0WIN;
        public  CustomWin ThumbnailRow0WIN;
        public  CustomWin Row2WIN;
        public  CustomWin EntityIconRow1WIN;
        public  CustomWin VaultStatusRow1WIN;
        public  CustomWin NameRow1WIN;
        public  CustomWin VaultStatusModifierRow2WIN;
        public  CustomWin CheckedInRow1WIN;
        public  CustomWin CommentRow1WIN;
        public  CustomWin ThumbnailRow1WIN;
        public  TitleBar SelectVaultLocationCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectVaultLocationDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Pane1PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane1PANE);

            Pane2PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane2PANE);

            LookInST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1/[StaticText]Look in:|$lookIn_label|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInST);

            LookInPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1/[Pane]Look in:|$vaultNavigationPathComboboxControl1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInPANE);

            PopupListPL = new PopupList()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1/[Pane]Look in:|$vaultNavigationPathComboboxControl1|#1/[PopupList]$comboBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1/[Pane]Look in:|$vaultNavigationPathComboboxControl1|#1/[PopupList]$comboBox1|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            ToolStrip1TB = new ToolBar()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1/[ToolBar]toolStrip1|$toolStrip1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolStrip1TB);

            BackPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1/[ToolBar]toolStrip1|$toolStrip1|#1/[PushButton]Back|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BackPB);

            MoveUpALevelPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1/[ToolBar]toolStrip1|$toolStrip1|#1/[PushButton]Move Up a Level|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MoveUpALevelPB);

            ChangeViewPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel2|#1/[ToolBar]toolStrip1|$toolStrip1|#1/[PushButton]Change View|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ChangeViewPB);

            RevisionPANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]Revision:|$tableLayoutPanelButtonBar|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RevisionPANE);

            CancelPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]Revision:|$tableLayoutPanelButtonBar|#4/[PushButton]Cancel|$cancel_button|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            OpenPB = new PushButton()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]Revision:|$tableLayoutPanelButtonBar|#4/[PushButton]Open|$open_button|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            Pane3PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel4|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane3PANE);

            Proj2PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel4|#3/[Pane]Proj2|$fileName_multiPartTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Proj2PANE);

            ComboBoxCB = new ComboBox()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel4|#3/[Pane]Proj2|$fileName_multiPartTextBox|#1/[ComboBox]$comboBoxEdit1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ComboBoxCB);

            FileNameST = new StaticText()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$tableLayoutPanel4|#3/[StaticText]File name:|$fileName_label|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameST);

            Pane4PANE = new Pane()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Pane4PANE);

            TableTBL = new Table()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TableTBL);

            HeaderPanelWIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Header Panel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderPanelWIN);

            CommentCTL = new Header()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Header Panel|#1/[Header]Comment|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentCTL);

            CheckedInCTL = new Header()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Header Panel|#1/[Header]Checked In|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckedInCTL);

            ThumbnailCTL = new Header()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Header Panel|#1/[Header]Thumbnail|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThumbnailCTL);

            NameCTL = new Header()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Header Panel|#1/[Header]Name|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameCTL);

            EntityIconCTL = new Header()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Header Panel|#1/[Header]Entity Icon|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EntityIconCTL);

            VaultStatusCTL = new Header()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Header Panel|#1/[Header]Vault Status|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultStatusCTL);

            VaultStatusModifierCTL = new Header()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Header Panel|#1/[Header]Vault Status Modifier|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultStatusModifierCTL);

            DataPanelWIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataPanelWIN);

            Row1WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row1WIN);

            EntityIconRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 1|#1/[CustomWin]Entity Icon row 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EntityIconRow0WIN);

            VaultStatusRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 1|#1/[CustomWin]Vault Status row 0|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultStatusRow0WIN);

            NameRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 1|#1/[CustomWin]Name row 0|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameRow0WIN);

            VaultStatusModifierRow1WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 1|#1/[CustomWin]Vault Status Modifier row 0|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultStatusModifierRow1WIN);

            CheckedInRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 1|#1/[CustomWin]Checked In row 0|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckedInRow0WIN);

            CommentRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 1|#1/[CustomWin]Comment row 0|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentRow0WIN);

            ThumbnailRow0WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 1|#1/[CustomWin]Thumbnail row 0|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThumbnailRow0WIN);

            Row2WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Row2WIN);

            EntityIconRow1WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 2|#2/[CustomWin]Entity Icon row 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EntityIconRow1WIN);

            VaultStatusRow1WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 2|#2/[CustomWin]Vault Status row 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultStatusRow1WIN);

            NameRow1WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 2|#2/[CustomWin]Name row 1|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameRow1WIN);

            VaultStatusModifierRow2WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 2|#2/[CustomWin]Vault Status Modifier row 1|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultStatusModifierRow2WIN);

            CheckedInRow1WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 2|#2/[CustomWin]Checked In row 1|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckedInRow1WIN);

            CommentRow1WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 2|#2/[CustomWin]Comment row 1|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CommentRow1WIN);

            ThumbnailRow1WIN = new CustomWin()
            {
                Tag = "[Pane]$tableLayoutPanel1|#1/[Pane]$vaultBrowserControl1|#2/[Table]$gridControl|#1/[CustomWin]Data Panel|#2/[CustomWin]Row 2|#2/[CustomWin]Thumbnail row 1|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThumbnailRow1WIN);

            SelectVaultLocationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Select Vault Location|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectVaultLocationCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Select Vault Location|$TitleBar|#1/[CustomWin]System Menu Bar|$SelectEntityFromVaultDialog|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Select Vault Location|$TitleBar|#1/[CustomWin]System Menu Bar|$SelectEntityFromVaultDialog|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Vault Location|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
