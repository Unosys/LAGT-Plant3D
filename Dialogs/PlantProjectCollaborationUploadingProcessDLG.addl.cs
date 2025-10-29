// $Header: //streams/main/TD/UIAutomation/ADDLGenerator/ADDLGenerator.cs#4 $ 
// $Change: 383241 $ $DateTime: 2013/09/15 20:15:27 $ $Author: liusi $
//
// (C) Copyright 2015 by Autodesk, Inc.
//
// The information contained herein is confidential, proprietary to Autodesk,
// Inc., and considered a trade secret as defined in section 499C of the
// penal code of the State of California.  Use of this information by anyone
// other than authorized employees of Autodesk, Inc. is granted only under a
// written non-disclosure agreement, expressly prescribing the scope and
// manner of such use.
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
namespace Autodesk.GUIHarness.Plant3D.Dialogs
{
    public partial class PlantProjectCollaborationUploadingProcessDLG : Window
    {
        public string FeatureType = "Dialog";
        public string releaseVer = "2016";
        ///// <summary>
        ///// OnInitialize() is used to contain additional initialization code
        ///// Uncomment the code block below to use it
        ///// </summary>
        partial void OnInitialize()
        {
            Tag = "[Window]$Window_1";
        }

        public void Invoke()
        {
            //Plant3DFunctions.AutodeskPlant3dSignin("diane.li@welocalize.com", "Password!1");
            Plant3DFunctions.CreateProjForCollaboration();           
            Drawing.Current.TypeE("_PLANTPROJECTCOLLABORATION");
            System.Threading.Thread.Sleep(6000);
            PlantProjectCollaborationGetStartedDLG PlantProjectCollaborationGetStartedDLG = new PlantProjectCollaborationGetStartedDLG();
            PlantProjectCollaborationGetStartedDLG.GetStartedPB.Click();
            System.Threading.Thread.Sleep(18000);
            PlantProjectCollaborationChooseTeamDLG PlantProjectCollaborationChooseTeamDLG = new PlantProjectCollaborationChooseTeamDLG();
            //PlantProjectCollaborationChooseTeamDLG.ChooseABIM360LB.Select(0);
            PlantProjectCollaborationChooseTeamDLG.LocTVI.Click();
            System.Threading.Thread.Sleep(5000);
            PlantProjectCollaborationChooseTeamDLG.UploadProjectPB.Click();
            System.Threading.Thread.Sleep(2000);
            this.SetActive();
        }


        public void Dismiss()
        {
            ConversionInProcessDLG ConversionInProcessDLG = new ConversionInProcessDLG();
            this.ClosePB.Click();
            ConversionInProcessDLG.StopSharingMyProjectPB.Click();

            if (ConversionInProcessDLG.Exists)
            {
                ConversionInProcessDLG.StopSharingMyProjectPB.Click();
            }
            PlantProjectCollaborationUploadingProcessDLG PlantProjectCollaborationUploadingProcessDLG = new PlantProjectCollaborationUploadingProcessDLG();

            PlantProjectCollaborationUploadingProcessDLG.ClosePB.Click();
            string sProjectname = Plant3DMainWin.sDefaultProjPath + "Project.xml";
            Drawing.Current.TypeE("Filedia 0");
            Drawing.Current.TypeE("_openproject");
            Drawing.Current.TypeE(sProjectname);
            //Plant3DFunctions.SetToDefault();
            Plant3D appwnd = new Plant3D();
            //appwnd.Exit1();
        }
    }
}
