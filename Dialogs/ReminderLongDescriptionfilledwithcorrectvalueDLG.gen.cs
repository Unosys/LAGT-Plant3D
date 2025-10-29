// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Reminder|#1", Parent = typeof(MainWin))]
    public partial class ReminderLongDescriptionfilledwithcorrectvalueDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OKPB;
        public  StaticText LongDescriptionFamilyShouldST;
        public  TitleBar ReminderCTL;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ReminderLongDescriptionfilledwithcorrectvalueDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);

            LongDescriptionFamilyShouldST = new StaticText()
            {
                Tag = "[StaticText]Long Description (Family) should be filled with correct value|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LongDescriptionFamilyShouldST);

            ReminderCTL = new TitleBar()
            {
                Tag = "[TitleBar]Reminder|$TitleBar|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ReminderCTL);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Reminder|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
