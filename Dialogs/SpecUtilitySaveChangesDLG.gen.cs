// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Save Changes|$TaskDialog_Enhanced|#1", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUtilitySaveChangesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  Image Image1IMG;
        public  StaticText YouHaveMadeChangesST;
        public  StaticText StaticTextST;
        public  Image Image2IMG;
        public  StaticText SaveChangesToTheST;
        public  Image Image3IMG;
        public  StaticText DiscardChangesToTheST;

        partial void OnInitialize();

        public SpecUtilitySaveChangesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Save Changes|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Image1IMG = new Image()
            {
                Tag = "[Image]$WarningImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            YouHaveMadeChangesST = new StaticText()
            {
                Tag = "[StaticText]You have made changes to the current Piping Component*|$HeaderTextBlock|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouHaveMadeChangesST);

            StaticTextST = new StaticText()
            {
                Tag = "[StaticText]$MessageTexBlock|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StaticTextST);

            Image2IMG = new Image()
            {
                Tag = "[Image]#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            SaveChangesToTheST = new StaticText()
            {
                Tag = "[StaticText]Save changes to the current component|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveChangesToTheST);

            Image3IMG = new Image()
            {
                Tag = "[Image]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            DiscardChangesToTheST = new StaticText()
            {
                Tag = "[StaticText]Discard changes to the current component|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiscardChangesToTheST);
        }
    }
}
