// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]PlaceProjectInVaultMigration2DLG", Parent = typeof(Plant3D))]
    public partial class PlaceProjectInVaultMigration2DLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;

        partial void OnInitialize();

        public PlaceProjectInVaultMigration2DLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "[PushButton]$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(No);
        }
    }
}
