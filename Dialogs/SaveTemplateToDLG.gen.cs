// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save Template To*")]
    public partial class SaveTemplateToDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton SavePB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public SaveTemplateToDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

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
