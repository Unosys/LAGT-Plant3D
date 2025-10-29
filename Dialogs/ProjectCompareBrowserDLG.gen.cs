// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open", Parent = typeof(Window), GUIType = GuiType.UIA)]
    public partial class ProjectCompareBrowserDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox FileNameCB;
        public  PopupList FileNamePL;
        public  PushButton DropDownButtonPB;
        public  PushButton OpenPB;
        public  PushButton CancelPB;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public ProjectCompareBrowserDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            FileNamePL = new PopupList()
            {
                Tag = "[PopupList]File name:|$1136|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNamePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]File name:|$1136|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Open|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
