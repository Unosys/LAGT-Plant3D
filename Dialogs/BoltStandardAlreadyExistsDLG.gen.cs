// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Bolt Standard Already Exists", Parent = typeof(Plant3D))]
    public partial class BoltStandardAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CloseButton;
        public  Image WarningImage;
        public  StaticText HeaderTextBlock;
        public  StaticText MessageTexBlock;
        public  Image Image;
        public  StaticText TextBlock;
        public  StaticText TextBlock4;
        public  Image Image3;
        public  StaticText TextBlock2;
        public  StaticText TextBlock3;

        partial void OnInitialize();

        public BoltStandardAlreadyExistsDLG()
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

            WarningImage = new Image()
            {
                Tag = "[Image]$WarningImage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(WarningImage);

            HeaderTextBlock = new StaticText()
            {
                Tag = "[StaticText]$HeaderTextBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderTextBlock);

            MessageTexBlock = new StaticText()
            {
                Tag = "[StaticText]$MessageTexBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MessageTexBlock);

            Image = new Image()
            {
                Tag = "[Image]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image);

            TextBlock = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock);

            TextBlock4 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock4);

            Image3 = new Image()
            {
                Tag = "[Image]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3);

            TextBlock2 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock2);

            TextBlock3 = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock3);
        }
    }
}
