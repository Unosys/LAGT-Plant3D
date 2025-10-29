// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Invalid Name", Parent = typeof(CreateSpecFromExistingSpecDLG1))]
    public partial class SpecFromExistingInvalidName : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YES;
        public  PushButton NO;
        public  PushButton OKPB;

        partial void OnInitialize();

        public SpecFromExistingInvalidName()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YES = new PushButton()
            {
                Tag = "[PushButton]$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YES);

            NO = new PushButton()
            {
                Tag = "[PushButton]$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NO);

            OKPB = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OKPB);
        }
    }
}
