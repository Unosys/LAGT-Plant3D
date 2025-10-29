// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Tag Already assigned", Parent = typeof(Plant3D))]
    public partial class LineGroupTagAlreadyExistsDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  RadioButton ThisLineGroupTagAlreadyEx1;
        public  StaticText ThisLineGroupTagAlreadyEx2;

        partial void OnInitialize();

        public LineGroupTagAlreadyExistsDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            ThisLineGroupTagAlreadyEx1 = new RadioButton()
            {
                Tag = "[RadioButton]#1|$m_radioButton2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisLineGroupTagAlreadyEx1);

            ThisLineGroupTagAlreadyEx2 = new StaticText()
            {
                Tag = "[StaticText]#1|$m_descText",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ThisLineGroupTagAlreadyEx2);
        }
    }
}
