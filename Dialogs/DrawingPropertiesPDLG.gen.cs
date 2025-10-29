// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Drawing Properties", Parent = typeof(Plant3D))]
    public partial class DrawingPropertiesPDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText Description;
        public  CustomWin Panel2;
        public  StaticText LblDescription;
        public  CustomWin Panel1;
        public  StaticText General;
        public  TextField DWGNumber1;
        public  StaticText DWGNumberText;
        public  TextField DWGNumber2;
        public  StaticText DWGTitleText;
        public  TextField DWGTitle;
        public  StaticText AreaText;
        public  TextField Area;
        public  StaticText AuthorText;
        public  TextField Author;
        public  StaticText DescriptionText;
        public  PushButton Help;
        public  PushButton Cancel;
        public  PushButton OK;

        partial void OnInitialize();

        public DrawingPropertiesPDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Description = new StaticText()
            {
                Tag = "[StaticText]#1|$gpDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Description);

            Panel2 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]#1|[System.Windows.Forms.Panel]$panel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel2);

            LblDescription = new StaticText()
            {
                Tag = "[StaticText]#1|$lblDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblDescription);

            Panel1 = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.Panel]#1|[System.Windows.Forms.Panel]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            General = new StaticText()
            {
                Tag = "[StaticText]#1|$groupBox0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(General);

            DWGNumber1 = new TextField()
            {
                Tag = "[TextField]#1|$TextBox0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGNumber1);

            DWGNumberText = new StaticText()
            {
                Tag = "[StaticText]#1|$Label0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGNumberText);

            DWGNumber2 = new TextField()
            {
                Tag = "[TextField]#2|$TextBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGNumber2);

            DWGTitleText = new StaticText()
            {
                Tag = "[StaticText]#2|$Label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGTitleText);

            DWGTitle = new TextField()
            {
                Tag = "[TextField]#3|$TextBox2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGTitle);

            AreaText = new StaticText()
            {
                Tag = "[StaticText]#3|$Label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AreaText);

            Area = new TextField()
            {
                Tag = "[TextField]#4|$TextBox3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Area);

            AuthorText = new StaticText()
            {
                Tag = "[StaticText]#4|$Label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthorText);

            Author = new TextField()
            {
                Tag = "[TextField]#5|$TextBox4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Author);

            DescriptionText = new StaticText()
            {
                Tag = "[StaticText]#5|$Label4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DescriptionText);

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
        }
    }
}
