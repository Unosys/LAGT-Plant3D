// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[DialogBox]Tag Format can't be deleted", Parent = typeof(Plant3D))]
    public partial class TagFormatCanTBeDeletedDLG : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  PushButton OK;
        public  StaticText EquipmentTagTypeNumber;

        partial void OnInitialize();

        public TagFormatCanTBeDeletedDLG()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            OK = new PushButton()
            {
                Tag = "[PushButton]#1|$2",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(OK);

            EquipmentTagTypeNumber = new StaticText()
            {
                Tag = "[StaticText]#1|$65535",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(EquipmentTagTypeNumber);
        }
    }
}
