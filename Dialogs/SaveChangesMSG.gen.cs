// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]AutoCAD", Parent = typeof(MainWin), GUIType = GuiType.WIN32)]
    public partial class SaveChangesMSG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public SaveChangesMSG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YesPB = new PushButton()
            {
                Tag = "[PushButton]Yes|$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[PushButton]No|$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
