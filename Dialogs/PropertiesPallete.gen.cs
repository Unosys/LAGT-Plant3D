// This file is auto-generated - do not hand edit this file.

using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{

    [UIElement(Tag = "[CustomWin]Properties", Parent = typeof(Plant3D))]
    public partial class PropertiesPallete : Autodesk.GUIHarness.AutoCAD.AcDialogBox
    {
        public  CustomWin ValveOperator5;
        public  CustomWin ButtonWIN5;
        public  CustomWin ValveOperator6;
        public  CustomWin ButtonWIN6;
        public  CustomWin ObjectType;
        public  CustomWin Message;
        public  CustomWin LocatingDimension;
        public  ListBox ListBoxLB;
        public  CustomWin Linetype;
        public  CustomWin Enclose;
        public  CustomWin LineNumbTag;
        public  CustomWin Direction;

        partial void OnInitialize();

        public PropertiesPallete()
        {
            InitializeComponent();
            OnInitialize();
        }

        private void InitializeComponent()
        {

            ValveOperator5 = new CustomWin()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[ListBox]#1/[CustomWin]#5",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValveOperator5);

            ButtonWIN5 = new CustomWin()
            {
                Tag = "[CustomWin]$59423 |#1/[CustomWin]$16720|#1/[CustomWin]$6|#1/[CustomWin]$-2141553008|#1/[ListBox]$239|#1/[CustomWin]$-1805629232/[CustomWin]Button|$12348|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ButtonWIN5);

            ValveOperator6 = new CustomWin()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[ListBox]#1/[CustomWin]#6",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ValveOperator6);

            ButtonWIN6 = new CustomWin()
            {
                Tag = "[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[CustomWin]#1/[ListBox]#1/[CustomWin]#6/[CustomWin]$12348|#1",
                ParentType = this.GetType(),
                Parent = this
            };
            DeclaredChildren.Add(ButtonWIN6);

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
