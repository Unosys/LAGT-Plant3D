// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Invalid Name", Parent = typeof(CreateSpecFromExistingSpecDLG1))]
    public partial class SpecUtilityInvalidNameDLG2 : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  StaticText Label;
        public  PushButton OK;
        public  StaticText PleaseEnteraValidName;

        partial void OnInitialize();

        public SpecUtilityInvalidNameDLG2()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            Label = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Label);

            OK = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            PleaseEnteraValidName = new StaticText()
            {
                Tag = "[StaticText]$",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(PleaseEnteraValidName);
        }
    }
}
