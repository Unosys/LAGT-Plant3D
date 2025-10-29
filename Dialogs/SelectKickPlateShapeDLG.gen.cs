// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]*Kick Plate Shape*", Parent = typeof(Plant3D))]
    public partial class SelectKickPlateShapeDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton Select;
        public  PushButton Help;

        partial void OnInitialize();

        public SelectKickPlateShapeDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$1038",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Select = new PushButton()
            {
                Tag = "[PushButton]$1037",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Select);

            Help = new PushButton()
            {
                Tag = "[PushButton]$1030",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);
        }
    }
}
