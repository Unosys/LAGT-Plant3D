// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Create Content Pack|#1", Parent = typeof(BuildCatalogSingleDLG), GUIType = GuiType.UIA)]
    public partial class CreateContentPackDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText FileNameST;
        public  ComboBox FileNameCB;
        public  StaticText SaveAsTypeST;
        public  PopupList SaveAsTypePL;
        public  PushButton DropDownButtonPB;
        public  ToolBar ToolBar1TB;
        public  PushButton HideFoldersPB;
        public  PushButton Save;
        public  PushButton Cancel;
        public  PushButton Close;

        partial void OnInitialize();

        public CreateContentPackDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileNameST = new StaticText()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Details Pane|$BackgroundClear|#5/[StaticText]File name:|$SaveDialogLabel|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameST);

            FileNameCB = new ComboBox()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Details Pane|$BackgroundClear|#5/[ComboBox]File name:|$FileNameControlHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            SaveAsTypeST = new StaticText()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Details Pane|$BackgroundClear|#5/[StaticText]Save as type:|$SaveDialogLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsTypeST);

            SaveAsTypePL = new PopupList()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Details Pane|$BackgroundClear|#5/[PopupList]Save as type:|$FileTypeControlHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsTypePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Details Pane|$BackgroundClear|#5/[PopupList]Save as type:|$FileTypeControlHost|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            ToolBar1TB = new ToolBar()
            {
                Tag = "[ToolBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBar1TB);

            HideFoldersPB = new PushButton()
            {
                Tag = "[ToolBar]#1/[PushButton]Hide Folders|$Item 103|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HideFoldersPB);

            Save = new PushButton()
            {
                Tag = "[PushButton]Save|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Save);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            Close = new PushButton()
            {
                Tag = "[TitleBar]Create Content Pack|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close);
        }
    }
}
