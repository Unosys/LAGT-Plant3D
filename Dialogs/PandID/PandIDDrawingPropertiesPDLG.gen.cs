// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]DrawingPropertiesPDLG", Parent = typeof(CustomWin))]
    public partial class PandIDDrawingPropertiesPDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnCancel;
        public  PushButton BtnHelp;
        public  PushButton BtnOK;
        public  GroupBox GpDescription;
        public  GroupBox GroupBox0;
        public  StaticText Label0;
        public  StaticText Label1;
        public  StaticText Label2;
        public  StaticText Label3;
        public  StaticText Label4;
        public  StaticText LblDescription;
        public  GroupBox Panel1;
        public  GroupBox Panel2;
        public  TextField TextBox0;
        public  TextField TextBox1;
        public  TextField TextBox2;
        public  TextField TextBox3;
        public  TextField TextBox4;

        partial void OnInitialize();

        public PandIDDrawingPropertiesPDLG()
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

            GpDescription = new GroupBox()
            {
                Tag = "[GroupBox]$gpDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GpDescription);

            GroupBox0 = new GroupBox()
            {
                Tag = "[GroupBox]$groupBox0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBox0);

            Label0 = new StaticText()
            {
                Tag = "[StaticText]$Label0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label0);

            Label1 = new StaticText()
            {
                Tag = "[StaticText]$Label1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label1);

            Label2 = new StaticText()
            {
                Tag = "[StaticText]$Label2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label2);

            Label3 = new StaticText()
            {
                Tag = "[StaticText]$Label3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label3);

            Label4 = new StaticText()
            {
                Tag = "[StaticText]$Label4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label4);

            LblDescription = new StaticText()
            {
                Tag = "[StaticText]$lblDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LblDescription);

            Panel1 = new GroupBox()
            {
                Tag = "[GroupBox]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel1);

            Panel2 = new GroupBox()
            {
                Tag = "[GroupBox]$panel2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Panel2);

            TextBox0 = new TextField()
            {
                Tag = "[TextField]$TextBox0",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBox0);

            TextBox1 = new TextField()
            {
                Tag = "[TextField]$TextBox1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBox1);

            TextBox2 = new TextField()
            {
                Tag = "[TextField]$TextBox2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBox2);

            TextBox3 = new TextField()
            {
                Tag = "[TextField]$TextBox3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBox3);

            TextBox4 = new TextField()
            {
                Tag = "[TextField]$TextBox4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBox4);
        }
    }
}
