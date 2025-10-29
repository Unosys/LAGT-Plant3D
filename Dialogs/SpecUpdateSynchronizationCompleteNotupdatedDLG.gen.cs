// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Update - Synchronization Complete|$SynchronizationCompleteWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUpdateSynchronizationCompleteNotupdatedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Close2PB;

        partial void OnInitialize();

        public SpecUpdateSynchronizationCompleteNotupdatedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Close2PB = new PushButton()
            {
                Tag = "[PushButton]Close|$CloseButton|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Close2PB);
        }
    }
}
