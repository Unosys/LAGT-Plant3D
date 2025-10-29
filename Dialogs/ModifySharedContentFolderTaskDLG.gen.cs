// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Modify Shared Content Folder|$TaskDialog_Enhanced|#1", Parent = typeof(ModifySharedContentFolderDLG))]
    public partial class ModifySharedContentFolderTaskDLG : Window
    {
        public  PushButton CloseButton;
        public  StaticText CopyContentToNewLocation;
        public  StaticText DontChangeContentFolderLocation;
        public  StaticText HeaderTextBlock;
        public  Image Image;
        public  Image Image3;
        public  Image Image4;
        public  StaticText MessageTexBlock;
        public  StaticText SpecifyAnotherLocation;
        public  Image WarningImage;

        partial void OnInitialize();

        public ModifySharedContentFolderTaskDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CloseButton = new PushButton()
            {
                Tag = "[PushButton]$CloseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseButton);

            CopyContentToNewLocation = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CopyContentToNewLocation);

            DontChangeContentFolderLocation = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DontChangeContentFolderLocation);

            HeaderTextBlock = new StaticText()
            {
                Tag = "[StaticText]$HeaderTextBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderTextBlock);

            Image = new Image()
            {
                Tag = "[Image]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image);

            Image3 = new Image()
            {
                Tag = "[Image]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3);

            Image4 = new Image()
            {
                Tag = "[Image]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image4);

            MessageTexBlock = new StaticText()
            {
                Tag = "[StaticText]$MessageTexBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MessageTexBlock);

            SpecifyAnotherLocation = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SpecifyAnotherLocation);

            WarningImage = new Image()
            {
                Tag = "[Image]$WarningImage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WarningImage);
        }
    }
}
