// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]$AcPp3dErrorDlg", Parent = typeof(PropertiesPallete))]
    public partial class Plant3DPipingErrorsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin OneOrMoreItemsHaveCaused1;
        public  Table GridView;
        public  PushButton ClosePB;
        public  StaticText OneOrMoreItemsHaveCaused2;
        public  CustomWin IconPicBox;

        partial void OnInitialize();

        public Plant3DPipingErrorsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OneOrMoreItemsHaveCaused1 = new CustomWin()
            {
                Tag = "[System.Windows.Forms.Panel]$panel1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreItemsHaveCaused1);

            GridView = new Table()
            {
                Tag = "$GridView",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(GridView);

            ClosePB = new PushButton()
            {
                Tag = "$BtnClose",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ClosePB);

            OneOrMoreItemsHaveCaused2 = new StaticText()
            {
                Tag = "$LabelText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OneOrMoreItemsHaveCaused2);

            IconPicBox = new CustomWin()
            {
                Tag = "[System.Windows.Forms.PictureBox]$IconPicBox",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(IconPicBox);
        }
    }
}
