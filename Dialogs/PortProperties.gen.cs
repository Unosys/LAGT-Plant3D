// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]Properties", Parent = typeof(Plant3D))]
    public partial class PortProperties : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin ValveOperator;
        public  PopupList PopupList1PL;
        public  PushButton DropDownButtonPB;
        public  CustomWin ButtonWIN;
        public  CustomWin ObjectType;
        public  CustomWin Message;
        public  CustomWin LocatingDimension;
        public  ListBox ListBoxLB;
        public  CustomWin Linetype;
        public  CustomWin Enclose;
        public  CustomWin LineNumbTag;
        public  CustomWin Direction;

        partial void OnInitialize();

        public PortProperties()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ValveOperator = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|$16720|#1/[CustomWin]$12|#1/[CustomWin]$1413705984|#1/[ListBox]$239|#1/[CustomWin]$335548992|#4",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValveOperator);

            PopupList1PL = new PopupList()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|$16720|#1/[CustomWin]$12|#1/[CustomWin]$1413705984|#1/[ListBox]$239|#1/[CustomWin]$335548992|#4/[PopupList]$12360|#1",
                ParentType = this.GetType(),
                Parent = this,
                GUIType = GuiType.UIA,
            };
            DeclaredChildren.Add(PopupList1PL);

            DropDownButtonPB = new PushButton()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|$16720|#1/[CustomWin]$12|#1/[CustomWin]$1413705984|#1/[ListBox]$239|#1/[CustomWin]$335548992|#4/[PopupList]$12360|#1/[PushButton]Drop Down Button|$DropDown|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(DropDownButtonPB);

            ButtonWIN = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|$16720|#1/[CustomWin]$12|#1/[CustomWin]$1413705984|#1/[ListBox]$239|#1/[CustomWin]$335548992|#4/[CustomWin]Button|$12348|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ButtonWIN);

            ObjectType = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|#1/[CustomWin]#1/[CustomWin]#1/[ListBox]$239|#1/[CustomWin]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ObjectType);

            Message = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|#1/[CustomWin]#1/[CustomWin]#1/[ListBox]$239|#1/[CustomWin]#9",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Message);

            LocatingDimension = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|$16719|#1/[CustomWin]$5|#1/[CustomWin]$564529968|#1/[ListBox]$239|#1/[CustomWin]$668109536|#15",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LocatingDimension);

            ListBoxLB = new ListBox()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|$16719|#1/[CustomWin]$5|#1/[CustomWin]$564529968|#1/[ListBox]$239|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ListBoxLB);

            Linetype = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|$16719|#1/[CustomWin]$5|#1/[CustomWin]$564529968|#1/[ListBox]$239|#1/[CustomWin]$668107648|#7",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Linetype);

            Enclose = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|$16719|#1/[CustomWin]$5|#1/[CustomWin]$564529968|#1/[ListBox]$239|#1/[CustomWin]$558793696|#8",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Enclose);

            LineNumbTag = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|#1/[CustomWin]#1/[CustomWin]#1/[ListBox]$239|#1/[CustomWin]#3",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(LineNumbTag);

            Direction = new CustomWin()
            {
                Tag = "[CustomWin]Properties|$59423|#1/[CustomWin]Properties|#1/[CustomWin]#1/[CustomWin]#1/[ListBox]$239|#1/[CustomWin]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(Direction);
        }
    }
}
