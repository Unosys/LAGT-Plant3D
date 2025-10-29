// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open", Parent = typeof(MainWin))]
    public partial class PandIDOpenReportCreatorProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OpenPB;
        public  PushButton Cancel;
        public  ComboBox FileNameCB;

        partial void OnInitialize();

        public PandIDOpenReportCreatorProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);
        }
    }
}
