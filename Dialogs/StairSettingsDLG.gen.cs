// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Stair Settings", Parent = typeof(Plant3D))]
    public partial class StairSettingsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Cancel;
        public  PushButton OK;
        public  PushButton Help;
        public  PushButton StepData;
        public  PushButton StairShape;

        partial void OnInitialize();

        public StairSettingsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Cancel = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);

            OK = new PushButton()
            {
                Tag = "[PushButton]$1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            Help = new PushButton()
            {
                Tag = "[PushButton]$3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Help);

            StepData = new PushButton()
            {
                Tag = "[PushButton]$1162",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StepData);

            StairShape = new PushButton()
            {
                Tag = "[PushButton]$1033",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(StairShape);
        }
    }
}
