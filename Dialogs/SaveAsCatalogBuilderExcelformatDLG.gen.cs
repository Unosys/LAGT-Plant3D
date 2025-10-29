// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Export to*", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SaveAsCatalogBuilderExcelformatDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CancelPB;
        public  ComboBox FileNameCB;

        partial void OnInitialize();

        public SaveAsCatalogBuilderExcelformatDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            FileNameCB = new ComboBox()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main|#1/[Pane]Folder Layout Pane|$FolderLayoutContainer|#1/[Pane]Details Pane|$BackgroundClear|#3/[ComboBox]File name:|$FileNameControlHost|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);
        }
    }
}
