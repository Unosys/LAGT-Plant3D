// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]File move not allowed", Parent = typeof(Plant3D))]
    public partial class FileMoveNotAllowed2DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  CustomWin Icon1;
        public  StaticText ThisActionCannotBeComplete;

        partial void OnInitialize();

        public FileMoveNotAllowed2DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]$2|OK|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]$20|[Icon]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            ThisActionCannotBeComplete = new StaticText()
            {
                Tag = "[StaticText]$65535|This action cannot be completed because ' a' already exists in the destination folder .|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisActionCannotBeComplete);
        }
    }
}
