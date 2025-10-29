// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Create Spec From Existing Spec|$NewFileWindow")]
    public partial class CreateSpecFromExistingSpecDLG2 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton CreatePB;
        public  PushButton CancelPB;
        public  TextField SourceSpecNameTF;
        public  PushButton PushButton1PB;
        public  TextField NewSpecNameTF;
        public  PushButton PushButton2PB;
        public  TextField SpecDescriptionTF;

        partial void OnInitialize();

        public CreateSpecFromExistingSpecDLG2()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Create Spec From Exisitng Spec|$TitleBar|#1/[PushButton]Close|$Close|#1",
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
                Tag = "[TextField]Source Spec name: |$ExistingFileTextBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SourceSpecNameTF);

            PushButton1PB = new PushButton()
            {
                Tag = "[PushButton]**[1]|$ExistingFileBrowseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            NewSpecNameTF = new TextField()
            {
                Tag = "[TextField]New Spec name: |$NewFileTextBox|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NewSpecNameTF);

            PushButton2PB = new PushButton()
            {
                Tag = "[PushButton]**[2]|$NewFileBrowseButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton2PB);

            SpecDescriptionTF = new TextField()
            {
                Tag = "[TextField]Spec description:|$DescTextBox|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecDescriptionTF);
        }
    }
}
