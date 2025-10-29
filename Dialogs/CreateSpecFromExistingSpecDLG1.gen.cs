// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Create Spec From Existing Spec|$NewFileWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class CreateSpecFromExistingSpecDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton CreatePB;
        public  PushButton CancelPB;
        public  TextField SourceSpecNameTF;
        public  PushButton PushButton1PB;
        public  PushButton PushButton2PB;
        public  TextField NewSpecNameTF;
        public  TextField SpecDescriptionTF;
        public  ComboBox FileNameCB;
        public  PushButton OpenPB;

        partial void OnInitialize();

        public CreateSpecFromExistingSpecDLG1()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Spec From Existing Spec|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CreatePB = new PushButton()
            {
                Tag = "[PushButton]Create|$CreateButton|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CreatePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            SourceSpecNameTF = new TextField()
            {
                Tag = "[TextField]$ExistingFileTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SourceSpecNameTF);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]$ExistingFileBrowseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]$NewFileBrowseButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            NewSpecNameTF = new TextField()
            {
                Tag = "[TextField]$NewFileTextBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewSpecNameTF);

            SpecDescriptionTF = new TextField()
            {
                Tag = "[TextField]$DescTextBox|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecDescriptionTF);

            FileNameCB = new ComboBox()
            {
                Tag = "[DialogBox]Open|#1/[ComboBox]File name:|$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            OpenPB = new PushButton()
            {
                Tag = "[DialogBox]Open|#1/[PushButton]Open|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);
        }
    }
}
