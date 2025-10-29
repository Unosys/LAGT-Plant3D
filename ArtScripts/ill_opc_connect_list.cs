using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Autodesk.GUIHarness;
using Autodesk.GUIHarness.AutoCAD.Dialogs;
using Autodesk.GUIHarness.Plant3D.Dialogs;
using OptionSet;
using LAGT.CommonFiles;
using LAGT.CommonFiles.Constants;
using LAGT.CommonFiles.Entities;
using LAGT.CommonFiles.Extensions.CaptureBitmaps;
using LAGT.CommonFiles.Extensions.Rectangle;
using Autodesk.GUIHarness.AutoCAD;
namespace Autodesk.GUIHarness.Plant3D.ArtScripts
{
    public partial class ill_opc_connect_list : CreateConnectionDLG
    {
        private List<string> steps;
        private List<string> steps1;
        public ill_opc_connect_list() // add the constructor name as filename for each dialog
        {
            this.Information = new TestCaseInformation(
                "Art",//Type of automaiton (replace with a type list (Art / Dialog / Command line)
                false, // Define if this feature is part of new/changed feature (do we need to define this for each GUID?).
                true,
                "ill_opc_connect_list",//Name define by persons who edit scripts , excel?
                new List<string> {
                    "GUID-D2513BA0-930C-4E76-B0E4-29176846F551"
				//Add the GUID here
				},
                FYRelease.FY16
            );
            this.steps = new List<string> {
                "1. Switch the workspace to PID PIP",
                "2. Draw sline in the first dwg",
                "3. Right click the line and select Assign Tag",
                "4. Fill the information in Assign Tag dialog and check Place annotation after assigning tag checbox",
                "5. Click Assign, then click the workspace",
                "6. Select Non-engineering tab from toolpalettes",
                "7. Click OPC(Off page Connector) and add it ot the to the sline",
                "8. Draw sline in the second dwg and add a OPC this sline",
                "9.Right click the OPC",
                "10.Select Offpage Connector > connect... "
            };
            this.steps1 = new List<string> {
               
               "1. Switch workspace back to 3D Piping",
               "2. Undock Project Manager"
                
            };
        }

        public override void Invoke()
        {
            Plant3DFunctions.CreateDrawing("PID");
            Plant3DFunctions.CreateDrawing("PID");
            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps);
            CreateConnectionDLG CreateConnectionDLG = new CreateConnectionDLG();
            CreateConnectionDLG.SetActive();
        }

        public override void Capture(string SaveLocation)
        {
            CreateConnectionDLG CreateConnectionDLG = new CreateConnectionDLG();
            RECT gb = CreateConnectionDLG.PreviewGB.GetRect(true);
            gb.yPos = gb.yPos + 300;
            gb.ySize = gb.ySize - 300;
            //gb.xPos = gb.xPos + 100;
            //gb.xSize = gb.xSize - 45;
            CaptureBitmap(SaveLocation + this.Information.Items[0].ToString() + ArtEngineConstants.BitmapExtension, gb);
        }

        public override void Dismiss()
        {
            base.Dismiss();
            Plant3DFunctions.DeleteAllDrawings();
            LAGT.CommonFiles.Test_Suites.GlobalArt.ArtFunctions.ShowSteps(this.steps1);
        }
    }
}
