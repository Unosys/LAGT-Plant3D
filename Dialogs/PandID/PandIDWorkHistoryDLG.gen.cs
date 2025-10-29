// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]WorkHistoryDLG", Parent = typeof(CustomWin))]
    public partial class PandIDWorkHistoryDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnHelp;
        public  PushButton BtnOK;
        public  ComboBox CboStatus;
        public  PopupList StatusPL;
        public  GroupBox GpDetails;
        public  GroupBox GpWorkHistory;
        public  StaticText LblBeginEdit;
        public  StaticText LblBeginEdit1;
        public  StaticText LblEndEdit;
        public  StaticText LblEndEdit1;
        public  StaticText LblFile;
        public  StaticText LblFile1;
        public  StaticText LblNotes;
        public  StaticText LblProject;
        public  StaticText LblProject1;
        public  StaticText LblStatus;
        public  StaticText LblUser;
        public  StaticText LblUser1;
        public  TextField TbNotes;
        public  ScrollBar VerticalScrollBar;

        partial void OnInitialize();

        public PandIDWorkHistoryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnCancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnCancel);

            BtnHelp = new PushButton()
            {
                Tag = "[PushButton]$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnHelp);

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            CboStatus = new ComboBox()
            {
                Tag = "[ComboBox]$cboStatus",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CboStatus);

            StatusPL = new PopupList()
            {
                Tag = "[GroupBox]Work history|$gpWorkHistory|#1/[PopupList]Status:|$cboStatus|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusPL);

            GpDetails = new GroupBox()
            {
                Tag = "[GroupBox]$gpDetails",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GpDetails);

            GpWorkHistory = new GroupBox()
            {
                Tag = "[GroupBox]$gpWorkHistory",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GpWorkHistory);

            LblBeginEdit = new StaticText()
            {
                Tag = "[StaticText]$lblBeginEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblBeginEdit);

            LblBeginEdit1 = new StaticText()
            {
                Tag = "[StaticText]$lblBeginEdit1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblBeginEdit1);

            LblEndEdit = new StaticText()
            {
                Tag = "[StaticText]$lblEndEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblEndEdit);

            LblEndEdit1 = new StaticText()
            {
                Tag = "[StaticText]$lblEndEdit1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblEndEdit1);

            LblFile = new StaticText()
            {
                Tag = "[StaticText]$lblFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblFile);

            LblFile1 = new StaticText()
            {
                Tag = "[StaticText]$lblFile1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblFile1);

            LblNotes = new StaticText()
            {
                Tag = "[StaticText]$lblNotes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblNotes);

            LblProject = new StaticText()
            {
                Tag = "[StaticText]$lblProject",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblProject);

            LblProject1 = new StaticText()
            {
                Tag = "[StaticText]$lblProject1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblProject1);

            LblStatus = new StaticText()
            {
                Tag = "[StaticText]$lblStatus",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblStatus);

            LblUser = new StaticText()
            {
                Tag = "[StaticText]$lblUser",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblUser);

            LblUser1 = new StaticText()
            {
                Tag = "[StaticText]$lblUser1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblUser1);

            TbNotes = new TextField()
            {
                Tag = "[TextField]$tbNotes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TbNotes);

            VerticalScrollBar = new ScrollBar()
            {
                Tag = "[ScrollBar]$tbNotes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(VerticalScrollBar);
        }
    }
}
