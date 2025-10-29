// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[Window]Spec Update - Synchronization Complete|$SynchronizationCompleteWindow", Parent = typeof(MainWin), GUIType = GuiType.UIA)]
    public partial class SpecUpdateSynchronizationCompleteUpdatedSpecsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton CloseButton;
        public  StaticText SSpecSynchronizationCompleteHe;
        public  StaticText UpdatedSpecOption;
        public  StaticText TextBlock;

        partial void OnInitialize();

        public SpecUpdateSynchronizationCompleteUpdatedSpecsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            CloseButton = new PushButton()
            {
                Tag = "[PushButton]$CloseButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(CloseButton);

            SSpecSynchronizationCompleteHe = new StaticText()
            {
                Tag = "[StaticText]$sSpecSynchronizationCompleteHeader",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SSpecSynchronizationCompleteHe);

            UpdatedSpecOption = new StaticText()
            {
                Tag = "[StaticText]$UpdatedSpecOption",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(UpdatedSpecOption);

            TextBlock = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(TextBlock);
        }
    }
}
