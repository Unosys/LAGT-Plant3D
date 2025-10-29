// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Synchronize Up", Parent = typeof(PROJECTMANAGERDLG))]
    public partial class SynchronizeUpDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  CustomWin Icon1;
        public  StaticText SomeOfTheSelectedFilesTo;

        partial void OnInitialize();

        public SynchronizeUpDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(No);

            Icon1 = new CustomWin()
            {
                Tag = "[Icon]$20",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Icon1);

            SomeOfTheSelectedFilesTo = new StaticText()
            {
                Tag = "$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(SomeOfTheSelectedFilesTo);
        }
    }
}
