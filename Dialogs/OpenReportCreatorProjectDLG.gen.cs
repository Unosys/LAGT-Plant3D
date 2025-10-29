// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Open|#1", Parent = typeof(ReportCreatorDLG), GUIType = GuiType.UIA)]
    public partial class OpenReportCreatorProjectDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox FileNameCB;
        public  PushButton OpenPB;
        public  PushButton Cancel;

        partial void OnInitialize();

        public OpenReportCreatorProjectDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileNameCB = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$1148|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameCB);

            OpenPB = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenPB);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
