// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select Excel Files to Build Catalog From|#1", Parent = typeof(Plant3DCatalogBuilderDLG), GUIType = GuiType.UIA)]
    public partial class SelectExcelFilesToBuildCatDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox FileName1;
        public  PopupList FileName;
        public  PushButton DropDownButtonPB;
        public  PushButton Open;
        public  PushButton Cancel;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SelectExcelFilesToBuildCatDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileName1 = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName1);

            FileName = new PopupList()
            {
                Tag = "[PopupList]File name:|$1136|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileName);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[PopupList]File name:|$1136|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            Open = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Select Excel Files to Build Catalog From|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
