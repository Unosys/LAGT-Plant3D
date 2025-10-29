// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Export To")]
    public partial class ExportToDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox FileNameCB;
        public  PushButton SavePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public ExportToDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$13006|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            SavePB = new PushButton()
            {
                Tag = "[PushButton]Save|$1|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
