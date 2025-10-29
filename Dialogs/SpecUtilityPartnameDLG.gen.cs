// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Part Preview|$PreviewImageDialog", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUtilityPartnameDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  Image CatalogPartSizeImage;

        partial void OnInitialize();

        public SpecUtilityPartnameDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[PushButton]$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CatalogPartSizeImage = new Image()
            {
                Tag = "[Image]$CatalogPartSizeImage",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogPartSizeImage);
        }
    }
}
