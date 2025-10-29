// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Update Notification|$SpecUpdateNotificationWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUpdateNotificationNoUpdatesFoundDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  PushButton PushButtonPB;
        public  StaticText ShowDetailsST;
        public  Image Image2IMG;
        public  StaticText UpdateSpecPartsToST;
        public  StaticText ThePartsInYourST;
        public  Image Image3IMG;
        public  StaticText DoNotUpdateSpecST;
        public  StaticText NoChangesWillBeST;

        partial void OnInitialize();

        public SpecUpdateNotificationNoUpdatesFoundDLG()
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

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]$CancelButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            PushButtonPB = new PushButton()
            {
                Tag = "[GroupBox]$SpecListViewExpander|#1/[PushButton]$HeaderSite|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButtonPB);

            ShowDetailsST = new StaticText()
            {
                Tag = "[StaticText]$ShowDetailsText|#3",
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
                Tag = "[StaticText]$UpdateSpecPartsOption|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdateSpecPartsToST);

            ThePartsInYourST = new StaticText()
            {
                Tag = "[StaticText]$UpdateSpecPartsOptionContent|#5",
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
                Tag = "[StaticText]$DoNotUpdateSpecPartsOption|#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotUpdateSpecST);

            NoChangesWillBeST = new StaticText()
            {
                Tag = "[StaticText]$DoNotUpdateSpecPartsOptionContent|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoChangesWillBeST);
        }
    }
}
