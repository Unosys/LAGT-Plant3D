// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Convert CSV Files|$SpecMigrationConversionWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class ConvertCSVFilesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ConvertPB;
        public  PushButton CancelPB;
        public  PushButton PushButtonPB;
        public  TextField SelectTheFolderForTF;
        public  RadioButton SelectTheSpecFolderRB;
        public  RadioButton ConvertSelectedFilesToRB;
        public  PushButton AddPB;
        public  PushButton RemovePB;
        public  ListView SelectTheSpecFolderLV;

        partial void OnInitialize();

        public ConvertCSVFilesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ConvertPB = new PushButton()
            {
                Tag = "[PushButton]Convert|$Convert|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$Cancel|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PushButtonPB = new PushButton()
            {
                Tag = "[PushButton]$EllipsisButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            SelectTheFolderForTF = new TextField()
            {
                Tag = "[TextField]Select the folder for the converted specs and catalogs:|$MigratedFolderTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheFolderForTF);

            SelectTheSpecFolderRB = new RadioButton()
            {
                Tag = "[RadioButton]Select the spec folder contatining csv files to be converted:|$SpecRadioButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheSpecFolderRB);

            ConvertSelectedFilesToRB = new RadioButton()
            {
                Tag = "[RadioButton]Convert selected files to:|$CatalogRadioButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConvertSelectedFilesToRB);

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

            SelectTheSpecFolderLV = new ListView()
            {
                Tag = "[ListView]Select the spec folder contatining csv files to be converted:|$FileNamesListView|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SelectTheSpecFolderLV);
        }
    }
}
