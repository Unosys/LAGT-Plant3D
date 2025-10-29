// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save As", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class IsoStyleEditorSaveAsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox FileNameCB;
        public  StaticText SaveAsTypeST;
        public  PopupList SaveAsTypePL;
        public  PushButton DropDownButtonPB;
        public  ToolBar ToolBarTB;
        public  PushButton HideFoldersPB;
        public  PushButton SavePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public IsoStyleEditorSaveAsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileNameCB = new ComboBox()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Folder Layout Pane|$FolderLayoutContainer|#1/[Pane]Details Pane|$BackgroundClear|#3/[ComboBox]File name:|$FileNameControlHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            SaveAsTypeST = new StaticText()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Folder Layout Pane|$FolderLayoutContainer|#1/[Pane]Details Pane|$BackgroundClear|#3/[StaticText]Save as type:|$SaveDialogLabel|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsTypeST);

            SaveAsTypePL = new PopupList()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Folder Layout Pane|$FolderLayoutContainer|#1/[Pane]Details Pane|$BackgroundClear|#3/[PopupList]Save as type:|$FileTypeControlHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsTypePL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Folder Layout Pane|$FolderLayoutContainer|#1/[Pane]Details Pane|$BackgroundClear|#3/[PopupList]Save as type:|$FileTypeControlHost|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            ToolBarTB = new ToolBar()
            {
                Tag = "[ToolBar]#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ToolBarTB);

            HideFoldersPB = new PushButton()
            {
                Tag = "[ToolBar]#1/[PushButton]Hide Folders|$Item 103|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(HideFoldersPB);

            SavePB = new PushButton()
            {
                Tag = "[PushButton]Save|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
