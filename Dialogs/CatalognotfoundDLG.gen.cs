// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Catalog Not Found|$CatalogNotFoundWindow")]
    public partial class CatalognotfoundDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton ReferencePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public CatalognotfoundDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]$TitleBar|#1/[PushButton]$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            ReferencePB = new PushButton()
            {
                Tag = "[PushButton]$BrowseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReferencePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$CancelButton|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
