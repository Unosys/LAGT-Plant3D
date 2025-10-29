// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Convert CADWorx Specs|$SpecMigrationConversionWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ConvertCADWorxSpecsDLG : Autodesk.GUIHarness.Window
    {
        public  PushButton ConvertPB;
        public  PushButton CancelPB;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  PushButton PushButton3PB;
        public  TextField SelectTheStandardLibraryTF;
        public  TextField SelectTheCadWorxDatafiletblTF;
        public  TextField SelectTheFolderForTF;
        public  PushButton AddPB;
        public  PushButton RemovePB;

        partial void OnInitialize();

        public ConvertCADWorxSpecsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ConvertPB = new PushButton()
            {
                Tag = "[PushButton]Convert|$Convert|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$EllipsisButton|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]$EllipsisButtonCADWorx|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            PushButton3PB = new PushButton()
            {
                Tag = "[PushButton]$EllipsisButton2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton3PB);

            SelectTheStandardLibraryTF = new TextField()
            {
                Tag = "[TextField]Select the standard library that contains referenced files:|$LibRefTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheStandardLibraryTF);

            SelectTheCadWorxDatafiletblTF = new TextField()
            {
                Tag = "[TextField]Select the CadWorx datafile*|$DataFileTextBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheCadWorxDatafiletblTF);

            SelectTheFolderForTF = new TextField()
            {
                Tag = "[TextField]Select the folder for the converted specs:|$MigratedFolderTextBox|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheFolderForTF);

            AddPB = new PushButton()
            {
                Tag = "[PushButton]Add|$AddButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(AddPB);

            RemovePB = new PushButton()
            {
                Tag = "[PushButton]Remove|$RemoveButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(RemovePB);
        }
    }
}
