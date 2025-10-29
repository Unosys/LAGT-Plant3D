// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save As", Parent = typeof(Window))]
    public partial class SpecUtilitySaveAsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox FileNameCB;
        public  PushButton SavePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public SpecUtilitySaveAsDLG()
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
