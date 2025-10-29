// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Attach External Reference from Vault|$frmVaultAttachReferences", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class AttachExternalReferencesFromVaultDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox GroupBox1GB;
        public  CheckBox PromptForInsertionPointCK;
        public  RadioButton RadioButton1RB;
        public  RadioButton RadioButton2RB;
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton AttachPB;
        public  GroupBox GroupBox2GB;
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
        public  StaticText StaticTextST;
        public  StaticText CheckoutByUserSameVersionST;
        public  StaticText Draw5dwgST;
        public  StaticText Proj1Plant3DModelsDraw5dwgST;
        public  StaticText one3781KBST;
        public  StaticText AdministratorST;
        public  TitleBar AttachExternalReferenceFromCTL;
        public  CustomWin SystemMenuBarWIN;
        public  MenuItem SystemMI;
        public  PushButton MinimizePB;
        public  PushButton MaximizePB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public AttachExternalReferencesFromVaultDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            GroupBox1GB = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox1GB);

            PromptForInsertionPointCK = new CheckBox()
            {
                Tag = "[GroupBox]$groupBox2|#2/[CheckBox]Prompt for insertion point, rotation, and scale |$m_cbCLIPrompt|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PromptForInsertionPointCK);

            RadioButton1RB = new RadioButton()
            {
                Tag = "[GroupBox]$groupBox2|#2/[RadioButton]$m_radioOverlay|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton1RB);

            RadioButton2RB = new RadioButton()
            {
                Tag = "[GroupBox]$groupBox2|#2/[RadioButton]$m_radioAttach|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RadioButton2RB);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|$m_btnHelp|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$m_btnCancel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            AttachPB = new PushButton()
            {
                Tag = "[PushButton]Attach|$m_btnAttach|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AttachPB);

            GroupBox2GB = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox2GB);

            ListViewLV = new ListView()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewLV);

            HeaderCTL = new Header()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderCTL);

            CustomWin1WIN = new CustomWin()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]$HeaderItem 0|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin1WIN);

            CustomWin2WIN = new CustomWin()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]$HeaderItem 1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWin2WIN);

            NameWIN = new CustomWin()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]Name|$HeaderItem 2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NameWIN);

            VaultPathWIN = new CustomWin()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]Vault Path|$HeaderItem 3|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VaultPathWIN);

            FileSizeWIN = new CustomWin()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]File Size|$HeaderItem 4|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileSizeWIN);

            CheckedOutByWIN = new CustomWin()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[Header]Header|$Header|#1/[CustomWin]Checked Out By|$HeaderItem 5|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckedOutByWIN);

            HorizontalScrollBarSB = new ScrollBar()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[ScrollBar]Horizontal Scroll Bar|$Horizontal ScrollBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HorizontalScrollBarSB);

            ListViewItemLVI = new ListViewItem()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListViewItemLVI);

            StaticTextST = new StaticText()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            CheckoutByUserSameVersionST = new StaticText()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]CheckoutByUserSameVersion|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckoutByUserSameVersionST);

            Draw5dwgST = new StaticText()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]Draw5*|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Draw5dwgST);

            Proj1Plant3DModelsDraw5dwgST = new StaticText()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]**|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Proj1Plant3DModelsDraw5dwgST);

            one3781KBST = new StaticText()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]137*|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(one3781KBST);

            AdministratorST = new StaticText()
            {
                Tag = "[GroupBox]$groupBox1|#1/[ListView]$m_ListView|#1/[ListViewItem]#1/[StaticText]Administrator|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AdministratorST);

            AttachExternalReferenceFromCTL = new TitleBar()
            {
                Tag = "[TitleBar]Attach External Reference from Vault|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AttachExternalReferenceFromCTL);

            SystemMenuBarWIN = new CustomWin()
            {
                Tag = "[TitleBar]Attach External Reference from Vault|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultAttachReferences|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMenuBarWIN);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Attach External Reference from Vault|$TitleBar|#1/[CustomWin]System Menu Bar|$frmVaultAttachReferences|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            MinimizePB = new PushButton()
            {
                Tag = "[TitleBar]Attach External Reference from Vault|$TitleBar|#1/[PushButton]Minimize|$Minimize|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MinimizePB);

            MaximizePB = new PushButton()
            {
                Tag = "[TitleBar]Attach External Reference from Vault|$TitleBar|#1/[PushButton]Maximize|$Maximize|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MaximizePB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Attach External Reference from Vault|$TitleBar|#1/[PushButton]Close|$Close|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
