// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Add Pipe Support|$ShapeBrowserWindow")]
    public partial class AddPipeSupportDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  RadioButton MBtnFilter3;
        public  PushButton OK;
        public  PushButton CancelPB;

        partial void OnInitialize();

        public AddPipeSupportDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            MBtnFilter3 = new RadioButton()
            {
                Tag = "[GroupBox]Graphics|$m_groupBox/[RadioButton]Graphics[5]|$m_btnFilter3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(MBtnFilter3);

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$OkButton|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            CancelPB = new PushButton()
            {
                Tag = "[PushButton]Cancel|$CancelButton|#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CancelPB);
        }
    }
}
