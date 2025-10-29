// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]AutoCAD Plant 3D|#1", Parent = typeof(Pane), GUIType = GuiType.UIA)]
    public partial class FileSetToReadOnlyDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  Image ImageIMG;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public FileSetToReadOnlyDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]AutoCAD Plant 3D|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
