// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Pane]Table Cell|#1", Parent = typeof(Pane))]
    public partial class TableCellTasksDLG : Pane
    {
        public  CustomWin OpenImage;

        partial void OnInitialize();

        public TableCellTasksDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OpenImage = new CustomWin()
            {
                Tag = "[CustomWin]$DevExpress.XtraPrinting.Native.Lines.EditorPropertyLine+DropDownEdit",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OpenImage);
        }
    }
}
