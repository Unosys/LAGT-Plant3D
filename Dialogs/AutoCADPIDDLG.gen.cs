// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]AutoCAD P&ID*", Parent = typeof(Plant3D))]
    public partial class AutoCADPIDDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton BtnOK;
        public  PushButton OK;
        public  CheckBox DoNotShowMeThisAgain;
        public  CustomWin ALogFileForAcceptAndReje;
        public  CustomWin M_iconPicture;

        partial void OnInitialize();

        public AutoCADPIDDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            BtnOK = new PushButton()
            {
                Tag = "[PushButton]$m_OKButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(BtnOK);

            OK = new PushButton()
            {
                Tag = "[PushButton]#1|$m_OKButton",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            DoNotShowMeThisAgain = new CheckBox()
            {
                Tag = "[CheckBox]#1|$m_notShowAgainChkBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DoNotShowMeThisAgain);

            ALogFileForAcceptAndReje = new CustomWin()
            {
                Tag = "[CustomWin][SwfLinkLabel]#1|[SwfLinkLabel]$m_helperLinkLabel",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ALogFileForAcceptAndReje);

            M_iconPicture = new CustomWin()
            {
                Tag = "[CustomWin][System.Windows.Forms.PictureBox]#1|[System.Windows.Forms.PictureBox]$m_iconPicture",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(M_iconPicture);
        }
    }
}
