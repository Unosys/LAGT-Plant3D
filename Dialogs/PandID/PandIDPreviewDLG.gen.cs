// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]PreviewDLG", Parent = typeof(Plant3D))]
    public partial class PandIDPreviewDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  GroupBox BottomPanel;

        partial void OnInitialize();

        public PandIDPreviewDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BottomPanel = new GroupBox()
            {
                Tag = "[GroupBox]$bottomPanel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BottomPanel);
        }
    }
}
