// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]ReportDesignerOpenDLG", Parent = typeof(Plant3D))]
    public partial class ReportDesignerOpenDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  TextField FileNameTextField;
        public  PushButton Open;

        partial void OnInitialize();

        public ReportDesignerOpenDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileNameTextField = new TextField()
            {
                Tag = "[TextField]$1148",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTextField);

            Open = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);
        }
    }
}
