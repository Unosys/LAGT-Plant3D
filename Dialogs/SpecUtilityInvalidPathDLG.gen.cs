// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Invalid Path|$Window_TaskDialog", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUtilityInvalidPathDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  Image ErrorImage;
        public  StaticText HeaderTextBlock;
        public  StaticText MessageTexBlockt;

        partial void OnInitialize();

        public SpecUtilityInvalidPathDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[PushButton]$CloseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ErrorImage = new Image()
            {
                Tag = "[Image]$ErrorImage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ErrorImage);

            HeaderTextBlock = new StaticText()
            {
                Tag = "[StaticText]$HeaderTextBlock",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HeaderTextBlock);

            MessageTexBlockt = new StaticText()
            {
                Tag = "[StaticText]$MessageTexBlockt",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MessageTexBlockt);
        }
    }
}
