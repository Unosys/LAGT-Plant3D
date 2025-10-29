// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]AlertAddDwgDLG", Parent = typeof(Plant3D))]
    public partial class PandIDAlertAddDwgDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton Yes;
        public  PushButton No;
        public  CustomWin Icon1;
        public  StaticText ThisObjectCanOnlyBeInsert;

        partial void OnInitialize();

        public PandIDAlertAddDwgDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Yes = new PushButton()
            {
                Tag = "[PushButton]Yes|$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Yes);

            No = new PushButton()
            {
                Tag = "[PushButton]No|$7",
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

            ThisObjectCanOnlyBeInsert = new StaticText()
            {
                Tag = "[StaticText]This object can only be inserted into a project drawing. ??Would you like to add this drawing to the current project?|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisObjectCanOnlyBeInsert);
        }
    }
}
