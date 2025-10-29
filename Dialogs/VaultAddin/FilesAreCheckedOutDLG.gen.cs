// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Files Are Checked Out|#1", Parent = typeof(PROJECTMANAGERDLG), GUIType = GuiType.WIN32)]
    public partial class FilesAreCheckedOutDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  Image ImageIMG;
        public  StaticText YouCannotDetachThisST;

        partial void OnInitialize();

        public FilesAreCheckedOutDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]OK|$2|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            ImageIMG = new Image()
            {
                Tag = "[Image]$20|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ImageIMG);

            YouCannotDetachThisST = new StaticText()
            {
                Tag = "[StaticText]You cannot detach this project from Vault while files are checked out*|$65535|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(YouCannotDetachThisST);
        }
    }
}
