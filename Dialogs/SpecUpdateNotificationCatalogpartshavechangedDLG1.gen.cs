// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Update Notification|$SpecUpdateNotificationWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUpdateNotificationCatalogpartshavechangedDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  Image Image1IMG;
        public  StaticText CatalogPartsHaveChangedST;
        public  StaticText OneOrMoreCatalogST;
        public  GroupBox GroupBoxGB;
        public  PushButton PushButtonPB;
        public  StaticText ShowDetailsST;
        public  Image Image2IMG;
        public  StaticText UpdateSpecPartsToST;
        public  StaticText ThePartsInYourST;
        public  Image Image3IMG;
        public  StaticText DoNotUpdateSpecST;
        public  StaticText NoChangesWillBeST;

        partial void OnInitialize();

        public SpecUpdateNotificationCatalogpartshavechangedDLG1()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Spec Update Notification|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            Image1IMG = new Image()
            {
                Tag = "[Image]$ExclamationImage|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image1IMG);

            CatalogPartsHaveChangedST = new StaticText()
            {
                Tag = "[StaticText]Catalog parts have changed|$CatalogPartsChangedHeader|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CatalogPartsHaveChangedST);

            OneOrMoreCatalogST = new StaticText()
            {
                Tag = "[StaticText]One or more catalog parts in your spec have changed in the catalog since this spec was created*|$CatalogPartsChangedContent|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreCatalogST);

            GroupBoxGB = new GroupBox()
            {
                Tag = "[GroupBox]$SpecListViewExpander|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GroupBoxGB);

            PushButtonPB = new PushButton()
            {
                Tag = "[GroupBox]$SpecListViewExpander|#1/[PushButton]$HeaderSite|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            ShowDetailsST = new StaticText()
            {
                Tag = "[StaticText]Show Details|$ShowDetailsText|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ShowDetailsST);

            Image2IMG = new Image()
            {
                Tag = "[Image]$BulletImage1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image2IMG);

            UpdateSpecPartsToST = new StaticText()
            {
                Tag = "[StaticText]Update spec parts to match catalog parts|$UpdateSpecPartsOption|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdateSpecPartsToST);

            ThePartsInYourST = new StaticText()
            {
                Tag = "[StaticText]The parts in your spec are updated to be consistent with the catalog parts*|$UpdateSpecPartsOptionContent|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThePartsInYourST);

            Image3IMG = new Image()
            {
                Tag = "[Image]$BulletImage2|#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Image3IMG);

            DoNotUpdateSpecST = new StaticText()
            {
                Tag = "[StaticText]Do not update spec parts|$DoNotUpdateSpecPartsOption|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotUpdateSpecST);

            NoChangesWillBeST = new StaticText()
            {
                Tag = "[StaticText]No changes will be made to the spec parts*|$DoNotUpdateSpecPartsOptionContent|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoChangesWillBeST);
        }
    }
}
