// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Project Publish Options", Parent = typeof(DialogBox))]
    public partial class PandIDProjectPublishOptionsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin Icon1;
        public  StaticText CurrentUserNsarchText;
        public  CustomWin CurrentUserNsarch;
        public  ListBox ListBox1;
        public  PushButton PushButton1;
        public  PushButton OK;
        public  PushButton Cancel;
        public  PushButton Help;
        public  CustomWin CustomWinName;
        public  PushButton PushButton1PB;
        public  PopupList PopupListPL;

        partial void OnInitialize();

        public PandIDProjectPublishOptionsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Icon1 = new CustomWin()
            {
                Tag = "[CustomWin][Icon]#1|[Icon]$4790",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            CurrentUserNsarchText = new StaticText()
            {
                Tag = "[StaticText]Current user: nsarch|#1|$4791",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentUserNsarchText);

            CurrentUserNsarch = new CustomWin()
            {
                Tag = "[CustomWin][ATL:5C4ED990]Current user: nsarch|[ATL:5C4ED990]#1|[ATL:5C4ED990]$4653",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CurrentUserNsarch);

            ListBox1 = new ListBox()
            {
                Tag = "[ListBox]#1|$239",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBox1);

            PushButton1 = new PushButton()
            {
                Tag = "[PushButton]#1|$244",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|#1|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|#2|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Help = new PushButton()
            {
                Tag = "[PushButton]Help|#3|$9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            CustomWinName = new CustomWin()
            {
                Tag = "[CustomWin]$4653|#1/[ListBox]$239|#1/[CustomWin]$692097040|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CustomWinName);

            PushButton1PB = new PushButton()
            {
                Tag = "[CustomWin]$4653|#1/[ListBox]$239|#1/[CustomWin]$692097040|#1/[PushButton]$1039|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PushButton1PB);

            PopupListPL = new PopupList()
            {
                Tag = "[CustomWin]$4653|#1/[ListBox]$239|#1/[CustomWin]$692097040|#1/[PopupList]$1002|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PopupListPL);
        }
    }
}
