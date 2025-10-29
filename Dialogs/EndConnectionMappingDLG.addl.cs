// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2016 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using ProductTestSuite.CommonFiles;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class EndConnectionMappingDLG : Pane
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2017";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Pane]$EndConnectionMappingDlg";
        }
        public void Invoke()
        {
            ProjectSetupPipeSpecObjectMappingDLG ProjectSetupPipeSpecObjectMappingDLG = new ProjectSetupPipeSpecObjectMappingDLG();
            ProjectSetupPipeSpecObjectMappingDLG.Invoke();
            ProjectSetupPipeSpecObjectMappingDLG.Window2WIN.Click(MouseButton.Left,5,5);
            System.Threading.Thread.Sleep(3000);
            ProjectSetupPipeSpecObjectMappingDLG.SelectTab(2);
            System.Threading.Thread.Sleep(3000);
            EndConnectionMappingDLG EndConnectionMappingDLG = new EndConnectionMappingDLG();
            SAM.GetCoords(LAGT.CommonFiles.Product.Variables.TestFilesDir + "SamScreenshots\\LoopUplist.bmp");
            Desktop.Current.Click(MouseButton.Left, SAM.iXCoord + 50, SAM.iYCoord + 5);
            Desktop.Current.PressMouse(MouseButton.Left, SAM.iXCoord + 50, SAM.iYCoord + 5);
            System.Threading.Thread.Sleep(1000);
            if (!EndConnectionMappingDLG.Exists)
            {
                ProjectSetupPipeSpecObjectMappingDLG.SelectTab(2);
                //Desktop.Current.TypeKeys("<Ctrl-Tab>");

                Desktop.Current.TypeKeys("<Tab 3>");
                for (int i = 0; i < 37; i++)
                {
                    Desktop.Current.TypeKeys("<Tab><Space>");
                    System.Threading.Thread.Sleep(1000);
                    if (EndConnectionMappingDLG.Exists)
                    {
                        EndConnectionMappingDLG.SetActive();
                        break;
                    }
                }
            }

        }

        public void Dismiss()
        {
            EndConnectionMappingDLG EndConnectionMappingDLG = new EndConnectionMappingDLG();
            EndConnectionMappingDLG.CancelPB.Click();
            ProjectSetupPipeSpecObjectMappingDLG ProjectSetupPipeSpecObjectMappingDLG = Current<ProjectSetupPipeSpecObjectMappingDLG>();
            ProjectSetupPipeSpecObjectMappingDLG.Dismiss();

        }
    }
}
