// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]*/Save PCF To")]
    public partial class SavePCFToDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OpenPB;
        public  PushButton Cancel;

        partial void OnInitialize();

        public SavePCFToDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
