// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Work History", Parent = typeof(Plant3D))]
    public partial class WorkHistoryDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;
        public  PopupList Status;
        public  StaticText Details;
        public  StaticText ProjectText;
        public  StaticText DefaultProjectText;
        public  StaticText FileText;
        public  StaticText CDocumentsAndSettingsNsar;
        public  StaticText UserText;
        public  StaticText NsarchText;
        public  StaticText BeginEditText;
        public  StaticText N220200942502PMText;
        public  StaticText EndEditText;
        public  StaticText NAText;
        public  StaticText WorkHistory;
        public  StaticText StatusText;
        public  StaticText NotesText;
        public  TextField Notes;

        partial void OnInitialize();

        public WorkHistoryDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Help = new PushButton()
            {
                Tag = "[PushButton]#3|$btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]$btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Status = new PopupList()
            {
                Tag = "[PopupList]$cboStatus",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Status);

            Details = new StaticText()
            {
                Tag = "[StaticText]#2|$gpDetails",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Details);

            ProjectText = new StaticText()
            {
                Tag = "[StaticText]#1|$lblProject1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ProjectText);

            DefaultProjectText = new StaticText()
            {
                Tag = "[StaticText]#2|$lblProject",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DefaultProjectText);

            FileText = new StaticText()
            {
                Tag = "[StaticText]#3|$lblFile1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileText);

            CDocumentsAndSettingsNsar = new StaticText()
            {
                Tag = "[StaticText]#4|$lblFile",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CDocumentsAndSettingsNsar);

            UserText = new StaticText()
            {
                Tag = "[StaticText]#5|$lblUser1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UserText);

            NsarchText = new StaticText()
            {
                Tag = "[StaticText]#6|$lblUser",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NsarchText);

            BeginEditText = new StaticText()
            {
                Tag = "[StaticText]#7|$lblBeginEdit1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BeginEditText);

            N220200942502PMText = new StaticText()
            {
                Tag = "[StaticText]#8|$lblBeginEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(N220200942502PMText);

            EndEditText = new StaticText()
            {
                Tag = "[StaticText]#9|$lblEndEdit1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EndEditText);

            NAText = new StaticText()
            {
                Tag = "[StaticText]#10|$lblEndEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NAText);

            WorkHistory = new StaticText()
            {
                Tag = "[StaticText]#1|$gpWorkHistory",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WorkHistory);

            StatusText = new StaticText()
            {
                Tag = "[StaticText]#1|$lblStatus",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StatusText);

            NotesText = new StaticText()
            {
                Tag = "[StaticText]#2|$lblNotes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NotesText);

            Notes = new TextField()
            {
                Tag = "[TextField]#1|$tbNotes",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Notes);
        }
    }
}
