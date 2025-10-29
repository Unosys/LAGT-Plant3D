// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save As", Parent = typeof(PreviewDLG), GUIType = GuiType.UIA)]
    public partial class SaveAsTextDocumentDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TreeView Tree;
        public  ComboBox TextField;
        public  PopupList SaveAsTypePL;
        public  PushButton Save;
        public  PushButton Cancel;
        public  PushButton ClosePB;

        partial void OnInitialize();

        public SaveAsTextDocumentDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Tree = new TreeView()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Control Host|$ProperTreeHost/[TreeView]Namespace Tree Control|$100",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Tree);

            TextField = new ComboBox()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Details Pane|$BackgroundClear/[ComboBox]File name:|$FileNameControlHost",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextField);

            SaveAsTypePL = new PopupList()
            {
                Tag = "[Pane]#2/[Pane]Explorer Pane|$main/[Pane]Details Pane|$BackgroundClear/[PopupList]Save as type:|$FileTypeControlHost",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SaveAsTypePL);

            Save = new PushButton()
            {
                Tag = "[PushButton]Save|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Save);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Save As|$TitleBar/[PushButton]Close|$Close",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
