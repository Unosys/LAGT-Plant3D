// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Drawings", Parent = typeof(Plant3D))]
    public partial class SelectDrawingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ListBox LookIn1;
        public  StaticText LookInText;
        public  PopupList LookIn2;
        public  ListView ListView1;
        public  Header Header1;
        public  PushButton Name;
        public  PushButton Size;
        public  PushButton Type;
        public  PushButton DateModified;
        public  StaticText FileNameText;
        public  ComboBox FileName;
        public  StaticText FilesOfTypeText;
        public  PopupList FilesOfType;
        public  PushButton PreviousFolderAlt1;
        public  PushButton UpOneLevelAlt2;
        public  PushButton SearchTheWebAlt3;
        public  PushButton DeleteDel;
        public  PushButton CreateNewFolderAlt5;
        public  PushButton Views;
        public  PushButton Tools;
        public  PushButton Select;
        public  PushButton Cancel;
        public  StaticText IncludeText;
        public  PopupList Include;
        public  CheckBox PrefixSheetTitleWithFileN;

        partial void OnInitialize();

        public SelectDrawingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            LookIn1 = new ListBox()
            {
                Tag = "[ListBox]Look in:|$13000|@(53,219)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn1);

            LookInText = new StaticText()
            {
                Tag = "[StaticText]Look in:|$13007|@(63,19)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookInText);

            LookIn2 = new PopupList()
            {
                Tag = "[PopupList]Look in:|$13001|@(223,20)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LookIn2);

            ListView1 = new ListView()
            {
                Tag = "[ListView]$1|@(355,178)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListView1);

            Header1 = new Header()
            {
                Tag = "[Header]$0|@(242,8)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Header1);

            Name = new PushButton()
            {
                Tag = "[PushButton]Name|@(90,8)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Name);

            Size = new PushButton()
            {
                Tag = "[PushButton]Size|@(228,8)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Size);

            Type = new PushButton()
            {
                Tag = "[PushButton]Type|@(336,8)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Type);

            DateModified = new PushButton()
            {
                Tag = "[PushButton]Date Modified|@(456,8)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DateModified);

            FileNameText = new StaticText()
            {
                Tag = "[StaticText]File name:|$13008|@(137,364)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameText);

            FileName = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$13006|@(350,361)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            FilesOfTypeText = new StaticText()
            {
                Tag = "[StaticText]Files of type:|$13009|@(144,394)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfTypeText);

            FilesOfType = new PopupList()
            {
                Tag = "[PopupList]Files of type:|$13002|@(350,392)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FilesOfType);

            PreviousFolderAlt1 = new PushButton()
            {
                Tag = "[PushButton]Previous folder(Alt+1)|$13011|@(360,17)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PreviousFolderAlt1);

            UpOneLevelAlt2 = new PushButton()
            {
                Tag = "[PushButton]Up one level (Alt+2)|$13003|@(385,17)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpOneLevelAlt2);

            SearchTheWebAlt3 = new PushButton()
            {
                Tag = "[PushButton]Search the Web (Alt+3)|$13004|@(411,17)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SearchTheWebAlt3);

            DeleteDel = new PushButton()
            {
                Tag = "[PushButton]Delete (Del)|$13014|@(436,17)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DeleteDel);

            CreateNewFolderAlt5 = new PushButton()
            {
                Tag = "[PushButton]Create New Folder (Alt+5)|$13013|@(460,17)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreateNewFolderAlt5);

            Views = new PushButton()
            {
                Tag = "[PushButton]Views|$13012|@(513,17)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Views);

            Tools = new PushButton()
            {
                Tag = "[PushButton]Tools|$13005|@(573,17)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tools);

            Select = new PushButton()
            {
                Tag = "[PushButton]Select|$1|@(558,359)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Select);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|@(558,390)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            IncludeText = new StaticText()
            {
                Tag = "[StaticText]Include:|$1009|@(162,336)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IncludeText);

            Include = new PopupList()
            {
                Tag = "[PopupList]Include:|$1008|@(240,335)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Include);

            PrefixSheetTitleWithFileN = new CheckBox()
            {
                Tag = "[CheckBox]Prefix sheet title with file name|$1010|@(422,335)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PrefixSheetTitleWithFileN);
        }
    }
}
