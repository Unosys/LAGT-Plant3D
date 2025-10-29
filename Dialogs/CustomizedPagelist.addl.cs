// (C) Copyright 2023 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class CustomizedPagelist : PageList
    {
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "DUMMY";
        }

        public void selectTab(int i = 0)
        {
            this.Click(MouseButton.Left, 5, 5);
            System.Threading.Thread.Sleep(1000);
            for (int j = 0; j <= i; j++)
            {
                this.TypeKeys("<Home><Right " + j + ">", 500);
            }
        }
    }
}
