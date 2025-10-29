// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Field", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class PandIDFieldDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  DialogBox DialogBox1DLG;
        public  DialogBox DialogBox2DLG;
        public  StaticText AuthorST;
        public  TextField AuthorTF;
        public  StaticText FormatST;
        public  ListBox FormatLB;
        public  StaticText FieldCategoryST;
        public  PopupList FieldCategoryPL;
        public  StaticText FieldNamesST;
        public  ListBox FieldNamesLB;
        public  StaticText FieldExpressionST;
        public  TextField FieldExpressionTF;
        public  PushButton OKPB;
        public  PushButton CancelPB;
        public  PushButton HelpPB;

        partial void OnInitialize();

        public PandIDFieldDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            DialogBox1DLG = new DialogBox()
            {
                Tag = "[DialogBox]$501|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DialogBox1DLG);

            DialogBox2DLG = new DialogBox()
            {
                Tag = "[DialogBox]$501|#1/[DialogBox]$1028|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DialogBox2DLG);

            AuthorST = new StaticText()
            {
                Tag = "[DialogBox]$501|#1/[DialogBox]$1028|#1/[StaticText]$1018|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthorST);

            AuthorTF = new TextField()
            {
                Tag = "[DialogBox]$501|#1/[DialogBox]$1028|#1/[TextField]$1021|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AuthorTF);

            FormatST = new StaticText()
            {
                Tag = "[DialogBox]$501|#1/[DialogBox]$1028|#1/[StaticText]$1005|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormatST);

            FormatLB = new ListBox()
            {
                Tag = "[DialogBox]$501|#1/[DialogBox]$1028|#1/[ListBox]$1019|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FormatLB);

            FieldCategoryST = new StaticText()
            {
                Tag = "[StaticText]$1010|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldCategoryST);

            FieldCategoryPL = new PopupList()
            {
                Tag = "[PopupList]$1002|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldCategoryPL);

            FieldNamesST = new StaticText()
            {
                Tag = "[StaticText]$1011|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldNamesST);

            FieldNamesLB = new ListBox()
            {
                Tag = "[ListBox]$1004|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldNamesLB);

            FieldExpressionST = new StaticText()
            {
                Tag = "[StaticText]$1014|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldExpressionST);

            FieldExpressionTF = new TextField()
            {
                Tag = "[TextField]$1006|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FieldExpressionTF);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            HelpPB = new PushButton()
            {
                Tag = "[PushButton]$9|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HelpPB);
        }
    }
}
