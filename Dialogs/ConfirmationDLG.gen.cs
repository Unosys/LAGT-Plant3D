// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Confirmation*", Parent = typeof(PropertyEditorFieldsDLG))]
    public partial class ConfirmationDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YesPB;
        public  PushButton NoPB;
        public  Image ImageIMG;
        public  StaticText TheCollectionWillBeST;
        public  TitleBar ConfirmationCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ConfirmationDLG()
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

            ImageIMG = new Image()
            {
                Tag = "[Image]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            TheCollectionWillBeST = new StaticText()
            {
                Tag = "[StaticText]The collection will be cleared and then populated with entries, for each field in the bound data source*|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TheCollectionWillBeST);

            ConfirmationCTL = new TitleBar()
            {
                Tag = "[TitleBar]Confirmation|$TitleBar",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ConfirmationCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Confirmation|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
