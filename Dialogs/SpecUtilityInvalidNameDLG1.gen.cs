// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Invalid Name", Parent = typeof(CreateSpecDLG))]
    public partial class SpecUtilityInvalidNameDLG1 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton YesPB;
        public  PushButton NoPB;

        partial void OnInitialize();

        public SpecUtilityInvalidNameDLG1()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            YesPB = new PushButton()
            {
                Tag = "[PushButton]$6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YesPB);

            NoPB = new PushButton()
            {
                Tag = "[PushButton]$7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(NoPB);
        }
    }
}
