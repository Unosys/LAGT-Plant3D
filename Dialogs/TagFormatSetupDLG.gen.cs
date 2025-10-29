// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$TagFormatSetupDLG", Parent = typeof(Plant3D))]
    public partial class TagFormatSetupDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton M_btnCancel;
        public  PushButton M_btnClass;
        public  PushButton M_btnDraw;
        public  PushButton M_btnExpression;
        public  PushButton M_btnHelp;
        public  PushButton M_btnMoreless;
        public  PushButton M_btnOK;
        public  PushButton M_btnProject;
        public  StaticText M_labelClass;
        public  TextField M_labelFormatName;
        public  StaticText M_lblClassText;
        public  StaticText M_lblDelimiterText;
        public  StaticText M_lblFieldText;
        public  StaticText M_lblFormatNameText;
        public  StaticText M_lblSubpartsText;
        public  UpDown M_numOfSubparts;
        public  TextField M_tboxDelimiter;
        public  TextField M_tboxField;
        public  GroupBox Panel1;

        partial void OnInitialize();

        public TagFormatSetupDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            M_btnCancel = new PushButton()
            {
                Tag = "[PushButton]$m_btnCancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnCancel);

            M_btnClass = new PushButton()
            {
                Tag = "[PushButton]$m_btnClass",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnClass);

            M_btnDraw = new PushButton()
            {
                Tag = "[PushButton]$m_btnDraw",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnDraw);

            M_btnExpression = new PushButton()
            {
                Tag = "[PushButton]$m_btnExpression",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnExpression);

            M_btnHelp = new PushButton()
            {
                Tag = "[PushButton]$m_btnHelp",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnHelp);

            M_btnMoreless = new PushButton()
            {
                Tag = "[PushButton]$m_btnMoreless",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnMoreless);

            M_btnOK = new PushButton()
            {
                Tag = "[PushButton]$m_btnOK",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnOK);

            M_btnProject = new PushButton()
            {
                Tag = "[PushButton]$m_btnProject",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_btnProject);

            M_labelClass = new StaticText()
            {
                Tag = "[StaticText]$m_labelClass",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelClass);

            M_labelFormatName = new TextField()
            {
                Tag = "[TextField]$m_labelFormatName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_labelFormatName);

            M_lblClassText = new StaticText()
            {
                Tag = "[StaticText]$m_lblClassText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblClassText);

            M_lblDelimiterText = new StaticText()
            {
                Tag = "[StaticText]$m_lblDelimiterText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblDelimiterText);

            M_lblFieldText = new StaticText()
            {
                Tag = "[StaticText]$m_lblFieldText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblFieldText);

            M_lblFormatNameText = new StaticText()
            {
                Tag = "[StaticText]$m_lblFormatNameText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblFormatNameText);

            M_lblSubpartsText = new StaticText()
            {
                Tag = "[StaticText]$m_lblSubpartsText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_lblSubpartsText);

            M_numOfSubparts = new UpDown()
            {
                Tag = "[UpDown]$m_numOfSubparts",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_numOfSubparts);

            M_tboxDelimiter = new TextField()
            {
                Tag = "[TextField]$m_tboxDelimiter",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tboxDelimiter);

            M_tboxField = new TextField()
            {
                Tag = "[TextField]$m_tboxField",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_tboxField);

            Panel1 = new GroupBox()
            {
                Tag = "[GroupBox]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);
        }
    }
}
