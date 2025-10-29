// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]*Select Block*", Parent = typeof(SymbolSettingsDLG))]
    public partial class P3DSelectBlockDrawingDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  ComboBox FileNameTextField;
        public  PushButton Open;
        public  PushButton Cancel;

        partial void OnInitialize();

        public P3DSelectBlockDrawingDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            FileNameTextField = new ComboBox()
            {
                Tag = "[ComboBox]File name:|$13006|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(FileNameTextField);

            Open = new PushButton()
            {
                Tag = "[PushButton]Open|$1|#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Open);

            Cancel = new PushButton()
            {
                Tag = "[PushButton]Cancel|$2|#10",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Cancel);
        }
    }
}
