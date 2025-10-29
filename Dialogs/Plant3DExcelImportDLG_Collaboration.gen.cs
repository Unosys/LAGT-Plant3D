// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Plant 3D - Excel Import|$Window_1")]
    public partial class Plant3DExcelImportDLG_Collaboration : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;
        public  PushButton CancelPB;
        public  PushButton UpdatePB;
        public  CheckBox CheckBoxCK;

        partial void OnInitialize();

        public Plant3DExcelImportDLG_Collaboration()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[TitleBar]Plant 3D - Excel Import|$TitleBar|#1/[PushButton]Close|$Close|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            CancelPB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Cancel|$Button_1|#2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);

            UpdatePB = new PushButton()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[PushButton]Update|$Button_2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdatePB);

            CheckBoxCK = new CheckBox()
            {
                Tag = "[CustomWin]$UserControl_1|#1/[CheckBox]$OptionCheckBox|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CheckBoxCK);
        }
    }
}
