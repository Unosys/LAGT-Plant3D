// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Select a Template")]
    public partial class SelectATemplateDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OpenPB;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public SelectATemplateDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

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
