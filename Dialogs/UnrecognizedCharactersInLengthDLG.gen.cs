// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[MainWin]Invalid Entry", Parent = typeof(Desktop), GUIType = GuiType.WIN32)]
    public partial class UnrecognizedCharactersInLengthDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton ClosePB;

        partial void OnInitialize();

        public UnrecognizedCharactersInLengthDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ClosePB = new PushButton()
            {
                Tag = "[Pane]$Window/[PushButton]$CommandButton_8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);
        }
    }
}
