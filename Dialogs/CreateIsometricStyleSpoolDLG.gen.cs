// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$Window_1", Parent = typeof(Plant3D))]
    public partial class CreateIsometricStyleSpoolDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText TextBlock_StyleName;
        public  StaticText TextBlock_ContextName;
        public  PushButton Btn_Previous;
        public  PushButton Btn_Next;
        public  CustomWin ContentControl_Configurator;
        public  Image Image;
        public  Image Tooltip_Overlay_Image;
        public  StaticText TextBlock_HiddenLayer;
        public  PushButton Btn_PreviousOption;
        public  StaticText TextBlock_OptionPosition;
        public  PushButton Btn_NextOption;
        public  StaticText TextBlock_contextDescription;
        public  PushButton Btn_Confirm;
        public  PushButton Btn_Help;
        public  PushButton Btn_Cancel;

        partial void OnInitialize();

        public CreateIsometricStyleSpoolDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            TextBlock_StyleName = new StaticText()
            {
                Tag = "[StaticText]$textBlock_StyleName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock_StyleName);

            TextBlock_ContextName = new StaticText()
            {
                Tag = "[StaticText]$textBlock_ContextName",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock_ContextName);

            Btn_Previous = new PushButton()
            {
                Tag = "[PushButton]$btn_Previous",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Previous);

            Btn_Next = new PushButton()
            {
                Tag = "[PushButton]$btn_Next",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Next);

            ContentControl_Configurator = new CustomWin()
            {
                Tag = "[CustomWin]$contentControl_Configurator",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ContentControl_Configurator);

            Image = new Image()
            {
                Tag = "[Image]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image);

            Tooltip_Overlay_Image = new Image()
            {
                Tag = "[Image]$Tooltip_Overlay_Image",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tooltip_Overlay_Image);

            TextBlock_HiddenLayer = new StaticText()
            {
                Tag = "[StaticText]$textBlock_HiddenLayer",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock_HiddenLayer);

            Btn_PreviousOption = new PushButton()
            {
                Tag = "[PushButton]$btn_PreviousOption",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_PreviousOption);

            TextBlock_OptionPosition = new StaticText()
            {
                Tag = "[StaticText]$textBlock_OptionPosition",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock_OptionPosition);

            Btn_NextOption = new PushButton()
            {
                Tag = "[PushButton]$btn_NextOption",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_NextOption);

            TextBlock_contextDescription = new StaticText()
            {
                Tag = "[StaticText]$textBlock_contextDescription",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock_contextDescription);

            Btn_Confirm = new PushButton()
            {
                Tag = "[PushButton]$btn_Confirm",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Confirm);

            Btn_Help = new PushButton()
            {
                Tag = "[PushButton]$btn_Help",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Help);

            Btn_Cancel = new PushButton()
            {
                Tag = "[PushButton]$btn_Cancel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Btn_Cancel);
        }
    }
}
