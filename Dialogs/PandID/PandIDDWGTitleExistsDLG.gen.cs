// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]DWG Title Exists", Parent = typeof(Plant3D))]
    public partial class PandIDDWGTitleExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText DWGTitleAlreadyExistsPlea;

        partial void OnInitialize();

        public PandIDDWGTitleExistsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2|@(154,52)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            DWGTitleAlreadyExistsPlea = new StaticText()
            {
                Tag = "[StaticText]DWG title already exists. Please enter a different DWG title.|$65535|@(160,18)",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DWGTitleAlreadyExistsPlea);
        }
    }
}
