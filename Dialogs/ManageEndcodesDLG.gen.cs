// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Manage Endcodes|$EndConditionsDlg", Parent = typeof(Plant3D), GUIType = GuiType.UIA)]
    public partial class ManageEndcodesDLG : Pane
    {
        public  StaticText EndcodeNameAndDescriptionST;
        public  PushButton BtnCancel;
        public  PushButton BtnOK;
        public  PushButton BtnHelp;
        public  PushButton M_btnDelete;
        public  PushButton M_btnModify;
        public  PushButton M_btnAdd;
        public  Table DataGridViewTBL;
        public  Pane VerticalScrollBarPANE;
        public  Header EndcodeCTL;
        public  Header DescriptionCTL;
        public  MenuItem SystemMI;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ManageEndcodesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            EndcodeNameAndDescriptionST = new StaticText()
            {
                Tag = "[StaticText]Endcode name and description:|$label1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndcodeNameAndDescriptionST);

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$btnCancel|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]OK|$btnOK|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]Help*|$btnHelp|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            M_btnDelete = new PushButton()
            {
                Tag = "[PushButton]Delete|$m_btnDelete|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDelete);

            M_btnModify = new PushButton()
            {
                Tag = "[PushButton]Modify*|$m_btnModify|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnModify);

            M_btnAdd = new PushButton()
            {
                Tag = "[PushButton]Add*|$m_btnAdd|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnAdd);

            DataGridViewTBL = new Table()
            {
                Tag = "[Table]DataGridView|$m_dataGridView1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DataGridViewTBL);

            VerticalScrollBarPANE = new Pane()
            {
                Tag = "[Table]DataGridView|$m_dataGridView1|#1/[Pane]Vertical Scroll Bar|$394954|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBarPANE);

            EndcodeCTL = new Header()
            {
                Tag = "[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]Endcode|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndcodeCTL);

            DescriptionCTL = new Header()
            {
                Tag = "[Table]DataGridView|$m_dataGridView1|#1/[CustomWin]Top Row|#1/[Header]Description|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionCTL);

            SystemMI = new MenuItem()
            {
                Tag = "[TitleBar]Manage Endcodes|$TitleBar|#1/[CustomWin]System Menu Bar|$EndConditionsDlg|#1/[MenuItem]System|$Item 1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SystemMI);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Manage Endcodes|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
