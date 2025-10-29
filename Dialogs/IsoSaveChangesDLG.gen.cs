// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Save Changes*", Parent = typeof(Plant3D))]
    public partial class IsoSaveChangesDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton SavePB;
        public  PushButton DiscardPB;

        partial void OnInitialize();

        public IsoSaveChangesDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            SavePB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Save|$CommandLink_1002|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SavePB);

            DiscardPB = new PushButton()
            {
                Tag = "[Pane]$Window|#1/[PushButton]Discard|$CommandLink_1001|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DiscardPB);
        }
    }
}
