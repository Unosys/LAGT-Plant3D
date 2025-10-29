using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodesk.GUIHarness.Plant3D.TestSuites.GlobalDlgBox
{
    public class DlgBox_FilteringLists
    {
        // //////////////////////////////////////////
        // // Common STRINGS that are NOT TRANSLATED
        // //////////////////////////////////////////

        //////////////////////////////////////////
        // Common STRINGS that are NOT TRANSLATED
        //////////////////////////////////////////
        public List<string> lsTranGLOB = new List<string>()
        {
            "0.00 mm,0.05 mm,0.09 mm,0.13 mm,0.15 mm,0.18 mm,0.20 mm,0.25 mm,0.30 mm,0.35 mm,0.40 mm,0.50 mm,0.53 mm,0.60 mm,0.70 mm,0.80 mm,0.90 mm,1.00 mm,1.06 mm,1.20 mm,1.40 mm,1.58 mm,2.00 mm,2.11 mm", // filter 20 errors
	        "320 x 240,640 x 480,800 x 600,1024 x 768", // filter about 5 errors
	        "AutoCAD 2007 DXF (*.dxf),AutoCAD 2004/LT2004 DXF (*.dxf),AutoCAD 2000/LT2000 DXF (*.dxf),AutoCAD R12/LT2 DXF (*.dxf)", // filter about 5 errors
	        "ARROWDOWN", // filter about 10 errors
	        "ARROWUP", // filter about 10 errors
	        "AutoCAD", // filter about 5 errors
	        "AutoCAD 2010", // filter about 35 errors
	        "AutoCAD Hammer",
	        "AutoCAD Hammer Beta 1",
	        "AutoCAD Hammer Beta 2",
	        "AutoCAD Hammer Beta 3",
	        "AutoCAD Hammer Beta 4",
	        "AutoCAD 2011", // filter about 35 errors
	        "AutoCAD Raptor",
	        "AutoCAD Raptor Beta 1",
	        "AutoCAD Raptor Beta 2",
	        "AutoCAD Raptor Beta 3",
	        "AutoCAD Raptor Beta 4",
	        "Buzzsaw,FTP", // filter 70 errors
	        "ByLayer,ByBlock,0.00 mm,0.05 mm,0.09 mm,0.13 mm,0.15 mm,0.18 mm,0.20 mm,0.25 mm,0.30 mm,0.35 mm,0.40 mm,0.50 mm,0.53 mm,0.60 mm,0.70 mm,0.80 mm,0.90 mm,1.00 mm,1.06 mm,1.20 mm,1.40 mm,1.58 mm,2.00 mm,2.11 mm", // filter 20 errors.JPN
	        "DXF (*.dxf)", // filter about7 errors
	        "FTP,Buzzsaw", // filter about 6 errors in XPPro
	        "FolderView", // filter about 20 errors
	        "FolderView,AutoCAD Sheet Sets,AutoCAD Sheet Sets", // filter about 13 errors
	        "FolderView,CER,CER,Data Links,Data Links,Drv,Drv,Fonts,Fonts,Help,Help,Koolhass_API_Testing,Koolhass_API_Testing,NIW,NIW,Plot Styles,Plot Styles,Plotters,Plotters,safecast,safecast,Sample,Sample,Setup,Setup,Support,Support,Template,Template,Textures,Textures,UPI,UPI,UserDataCache,UserDataCache,visualize,visualize,WebDepot,WebDepot,WebServices,WebServices,apiharnessdlls.zip,apiharnessdlls.zip", // filter 32 errors
	        "Program Files,AutoCAD 2011", // filter about 35 errors
	        "Program Files,AutoCAD Hammer",
	        "Program Files,AutoCAD Hammer Beta 1",
	        "Program Files,AutoCAD Hammer Beta 2",
	        "Program Files,AutoCAD Hammer Beta 3",
	        "Program Files,AutoCAD Hammer Beta 4",
	        "Program Files,AutoCAD 2009",
	        "Program Files,AutoCAD Raptor",
	        "Program Files,AutoCAD Raptor Beta 1",
	        "Program Files,AutoCAD Raptor Beta 2",
	        "Program Files,AutoCAD Raptor Beta 3",
	        "Program Files,AutoCAD Raptor Beta 4",
	        "Projects,Spago,Tests,Harness,Tools,HarnessResources", // filter about 17 errors
	        "Projects,Raptor,Tests,Harness,Tools,HarnessResources",
	        "Projects,Hammer,Tests,Harness,Tools,HarnessResources",
	        "Tag_Number,Manufacturer,Equipment_Description,Item_Type,Room", // filter about 15 errors
	        "X", // filter about 9 errors
	        "&X", // filter about 15 errors
	        "Y", // filter about 9 errors
	        "&Y", // filter about 15 errors
	        "Z", // filter about 9 errors
	        "&Z" // filter about 15 errors
        };

        ///////////////////////////////////////
        // CHS strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranCHS = new List<string>()
        {
            "150 dpi,200 dpi,300 dpi,400 dpi,600 dpi,720 dpi,1200 dpi,2400 dpi,4800 dpi", // filter 8 errors
	        "ByLayer,ByBlock", // filter 57 errors
	        "ByLayer,ByBlock,Continuous", // filter 11 errors
	        "Documents and Settings,Administrator,My Documents", // filter 15 errors in XPPro
	        "Documents and Settings,My Documents", // filter 15 errors in XPHome
	        "DPI", // filter 6 errors
	        "My Documents,FTP,Buzzsaw", // filter 6 errors in W2K
	        //"Standard"																				// filter 32 errors
	
	         //Added After FY2011
	        "AutoCAD Mechanical 2011 Drawing (*.dwg),AutoCAD Mechanical 2011 Drawing (*.dwg),AutoCAD 2010 Drawing (*.dwg),AutoCAD Mechanical 2010 Drawing (*.dwg),AutoCAD Mechanical 2009 Drawing (*.dwg),AutoCAD Mechanical 2008 Drawing (*.dwg),AutoCAD Mechanical 2007 Drawing (*.dwg),AutoCAD Mechanical 2006 Drawing (*.dwg),AutoCAD Mechanical 2005 Drawing (*.dwg),AutoCAD Mechan",
	        "Sample Library"
        };

        ///////////////////////////////////////
        // CHT strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranCHT = new List<string>()
        {
            "150 dpi,200 dpi,300 dpi,400 dpi,600 dpi,720 dpi,1200 dpi,2400 dpi,4800 dpi", // filter 8 errors
	        "ByLayer,ByBlock", // filter 40 errors
	        "ByLayer,ByBlock,Continuous", // filter 11 errors
	        "Documents and Settings,Administrator,My Documents", // filter 14 errors in XPPro
	        "Documents and Settings,My Documents", // filter 15 errors in XPHome
	        "dpi", // filter 12 errors
	        "My Documents,FTP,Buzzsaw" // filter 6 errors in W2K
	        //"Standard"																				// filter 21 errors
        };

        ///////////////////////////////////////
        // CSY strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranCSY = new List<string>()
        {
            "150 dpi,200 dpi,300 dpi,400 dpi,600 dpi,720 dpi,1200 dpi,2400 dpi,4800 dpi", // filter 8 errors
	        //"Continuous",							// filter 15 errors
	        "Documents and Settings", // filter 16 errors
	        "dpi", // filter 11 errors
	        "Projects,Spago,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "Projects,Raptor,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "OK", // filter 375 errors
	        "&OK", // filter 29 errors
	        //"Standard"							// filter 24 errors
	
	         //Added After FY2011
	        "Contract Number,Revision,Issue Date,Issued by,sdgf,Approval Date,Approved by,Check Date,Checked by,Design activity,savitaj,Sheet Number",
	        "GAP",
	        "Item (ITEM)"
        };

        ///////////////////////////////////////
        // DEU strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranDEU = new List<string>()
        {
            //"Continuous",							// filter 15 errors
	        "Cyan,Magenta", // filter 65 errors
	        "Desktop", // filter 14 errors
	        "Desktop,Administrator", // filter 15 errors	in XPPro
	        "Desktop,AutoCAD 2011", // filter 37 errors
	        "Desktop,AutoCAD Hammer", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 1", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 2", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 3", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 4", // filter 37 errors
	        "Desktop,AutoCAD 2009", // filter 37 errors
	        "Desktop,AutoCAD Raptor", // filter 37 errors
	        "Desktop,AutoCAD Raptor Beta 1", // filter 37 errors
	        "Desktop,AutoCAD Raptor Beta 2", // filter 37 errors
	        "Desktop,AutoCAD Raptor Beta 3", // filter 37 errors
	        "Desktop,AutoCAD Raptor Beta 4", // filter 37 errors
	        "Desktop,Buzzsaw,FTP", // filter 65 errors
	        "Desktop,Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "FTP,Desktop,Buzzsaw", // filter 6 errors
	        "FolderView,Name,AutoCAD Sheet Sets,AutoCAD Sheet Sets", // filter 11 errors
	        "FolderView,Name", // filter 12 errors
	        "&Format", // filter 6 errors
	        "F&ormat", // filter 6 errors
	        "&Name", // filter 12 errors
	        "Name", // filter 7 errors
	        "OK", // filter 394 errors
	        "&OK", // filter 29 errors
	        "Standard", // filter 24 errors
	
	         //Added After FY2011
	        "30457922.29 psi",
	        "34083.87 psi",
	        "52213.58 psi",
	        "Details",
	        "GAP",
	        "Header",
	        "Poisson",
	        "Sync",
	        "[lbf in]",
	        "[lbf/in]",
	        "[psi]"
        };

        ///////////////////////////////////////
        // ESP strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranESP = new List<string>()
        {
            "Color", // filter 5 errors
	        "Color", // filter 5 errors
	        "&Color", // filter 12 errors
	        "Conceptual", // filter 9 errors
	        //"Continuous",							// filter 14 errors
	        "Decimal", // filter 6 errors
	        "Documents and Settings", // filter 15 errors
	        "General", // filter 20 errors
	        "Hori&zontal", // filter 9 errors
	        "Magenta", // filter 65 errors
	        "No", // filter 4 errors
	        "&No", // filter 9 errors
	        "&Normal", // filter 4 errors
	        "Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        //"Standard",								// filter 24 errors	Estandar
	        "&Vertical", // filter 9 errors
	
	         //Added After FY2011
	        "Contract Number,Revision,Issue Date,Issued by,sdgf,Approval Date,Approved by,Check Date,Checked by,Design activity,savitaj,Sheet Number",
	        "Item (ITEM)"
        };

        ///////////////////////////////////////
        // FRA strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranFRA = new List<string>()
        {
            "Angle", // filter 5 errors
	        "Cyan,Magenta", // filter 68 errors
	        //"Continuous",							// filter 15 errors
	        "Description", // filter 9 errors
	        "Description", // filter 4 errors
	        "&Description", // filter 11 errors
	        "Direction", // filter 4 errors
	        "Documents and Settings", // filter 15 errors
	        "FolderView,Type", // filter 11 errors
	        "FolderView,Type,AutoCAD Sheet Sets,AutoCAD Sheet Sets", // filter 15 errors
	        "&Normal", // filter 4 errors
	        "Oblique", // filter 10 errors
	        "Options", // filter 16 errors
	        "Orientation", // filter 8 errors
	        "OK", // filter 386 errors
	        "&OK", // filter 30 errors
	        "Ports", // filter 8 errors
	        "Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "Standard", // filter 24 errors
	        "Table", // filter 6 errors
	        "Type", // filter 4 errors
	        "Type", // filter 5 errors
	
	         //Added After FY2011
	        "Angle,Force,Voltage,Volume",
	        "Contract Number,Revision,Issue Date,Issued by,sdgf,Approval Date,Approved by,Check Date,Checked by,Design activity,savitaj,Sheet Number",
	        "Description 1,Description 2",
	        "Item (ITEM)",
	        "SLOT_SIZE [in],NUM_OF_SLOTS",
	        "SOLID,ANGLE,AR-BRELM,AR-BRSTD,AR-CONC,AR-HBONE,AR-RROOF,AR-RSHKE,AR-SAND,BOX,BRASS,BRICK,BRSTONE,CLAY,CORK,CROSS,DASH,DOLMIT,DOTS,EARTH,ESCHER,FLEX,GOST_GLASS,GOST_WOOD,GOST_GROUND,GRASS,GRATE,GRAVEL,HEX,HONEY,HOUND,INSUL,LINE,MUDST,NET,PLAST,PLASTI,SACNCR,SQUARE,STARS,STEEL,SWAMP,TRANS,TRIANG"
        };

        ///////////////////////////////////////
        // HUN strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranHUN = new List<string>()
        {
            "150 dpi,200 dpi,300 dpi,400 dpi,600 dpi,720 dpi,1200 dpi,2400 dpi,4800 dpi", // filter 8 errors
	        //"Continuous",							// filter 15 errors
	        "Documents and Settings", // filter 12 errors
	        "DPI", // filter 12 errors
	        "Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "OK", // filter 380 errors
	        "&OK" // filter 29 errors
	        //"Standard"							// filter 29 errors
        };

        ///////////////////////////////////////
        // ITA strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranITA = new List<string>()
        {
            "150 dpi,200 dpi,300 dpi,400 dpi,600 dpi,720 dpi,1200 dpi,2400 dpi,4800 dpi", // filter 8 errors
	        "Magenta", // filter 65 errors
	        //"Continuous",							// filter 15 errors
	        "Desktop", // filter 28 errors
	        "Desktop,Administrator", // filter 15 errors	in XPPro
	        "Desktop,AutoCAD 2011", // filter 37 errors
	        "Desktop,AutoCAD Hammer", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 1", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 2", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 3", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 4", // filter 37 errors
	        "Desktop,AutoCAD 2011,Sample,VisualLISP", //filter 6 errors
	        "Desktop,AutoCAD Hammer,Sample,VisualLISP",
	        "Desktop,AutoCAD Hammer Beta 1,Sample,VisualLISP",
	        "Desktop,AutoCAD Hammer Beta 2,Sample,VisualLISP",
	        "Desktop,AutoCAD Hammer Beta 3,Sample,VisualLISP",
	        "Desktop,AutoCAD Hammer Beta 4,Sample,VisualLISP",
	        "Desktop,Documents and Settings", // filter 15 errors	in XPPro
	        "Desktop,Documents and Settings,Autodesk,AutoCAD 2011,Support", //filter 7 errors
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer,Support",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer Beta 1,Support",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer Beta 2,Support",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer Beta 3,Support",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer Beta 4,Support",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD 2011,Template", //filter 6 errors
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer,Template",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer Beta 1,Template",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer Beta 2,Template",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer Beta 3,Template",
	        "Desktop,Documents and Settings,Autodesk,AutoCAD Hammer Beta 4,Template",
	        "Desktop,Projects,Spago,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "Desktop,Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "dpi", // filter 12 errors
	        "FTP,Desktop,Buzzsaw", // filter 6 errors
	        "FolderView,AutoCAD Sheet Sets,AutoCAD Sheet Sets", // filter 15 errors
	        "No", // filter 4 errors
	        "&No", // filter 9 errors
	        "OK", // filter 390 errors
	        "&OK", // filter 30 errors
	        "Standard", // filter 24 errors

	         //Added After FY2011
	        "<ACADM>,<ADLMRES>,<CER>,<DEGTOOLS>,<DRV>,<EXPRESS>,<FONTS>,<HELP>,<IMAGEFORMATS>,<PLUGINS>,<SAMPLE>,<SCHEMAS>,<SETUP>,<SHADERS>,<SUPPORT>,<THEMES>,<TUTORIAL>,<UPI>,<USERDATACACHE>,<WEBSERVICES>",
	        "Contract Number,Revision,Issue Date,Issued by,sdgf,Approval Date,Approved by,Check Date,Checked by,Design activity,savitaj,Sheet Number",
	        "Contract Number,Revision,Issue Date,Issued by,sdsf,sdgf,Approval Date,Approved by,Check Date,Checked by,Design activity,savitaj,Sheet Number",
	        "Cylinder Head Cap Screw,DIN 912 - M10 x 50",
	        "Description (DESCR)",
	        "Item (ITEM)",
	        "Layout",
	        "Power Snap"
        };

        ///////////////////////////////////////
        // JPN strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranJPN = new List<string>()
        {
            "150 dpi,200 dpi,300 dpi,400 dpi,600 dpi,720 dpi,1200 dpi,2400 dpi,4800 dpi", // filter 8 errors
	        "ByLayer,ByBlock,Continuous", // filter 11 errors
	        "ByLayer,ByBlock,Red,Yellow,Green,Cyan,Blue,Magenta,White", // filter 74 errors
	        "Documents and Settings,Administrator,My Documents", // filter 15 errors in XPPro
	        "Documents and Settings,My Documents", // filter 15 errors in XPHome
	        "dpi", // filter 10 errors
	        "My Documents,FTP,Buzzsaw", // filter 6 errors in W2K
	        "OK", // filter 357 errors
	        "&OK", // filter xx errors
	        //"Program Files",																			// filter 35 errors
	        "Red,Yellow,Green,Cyan,Blue,Magenta,White", // filter 11 errors
	        //"Standard"																				// filter 32 errors
	
	         //Added After FY2011
	        "ACANSGDT,ACANSTS,Annotative,STANDARD",
	        "SLOT_SIZE [in],NUM_OF_SLOTS",
	        "SOLID,ANGLE,AR-BRELM,AR-BRSTD,AR-CONC,AR-HBONE,AR-RROOF,AR-RSHKE,AR-SAND,BOX,BRASS,BRICK,BRSTONE,CLAY,CORK,CROSS,DASH,DOLMIT,DOTS,EARTH,ESCHER,FLEX,GOST_GLASS,GOST_WOOD,GOST_GROUND,GRASS,GRATE,GRAVEL,HEX,HONEY,HOUND,INSUL,LINE,MUDST,NET,PLAST,PLASTI,SACNCR,SQUARE,STARS,STEEL,SWAMP,TRANS,TRIANG"
        };

        ///////////////////////////////////////
        // KOR strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranKOR = new List<string>()
        {
            "ByLayer,ByBlock", // filter 55 errors
	        "ByLayer,ByBlock,Continuous", // filter 11 errors
	        "dpi", // filter 12 errors
	        "Program Files,AutoCAD 2011,Sample,VisualLISP", // filter 6 errors
	        "Program Files,AutoCAD Hammer,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 1,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 2,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 3,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 4,Sample,VisualLISP",
	        "Projects,Hammer,Tests,Harness,Tools,HarnessResources" // filter 17 errors
	        //"Standard"																// filter 32 errors
        };

        ///////////////////////////////////////
        // PLK strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranPLK = new List<string>()
        {
            "150 dpi,200 dpi,300 dpi,400 dpi,600 dpi,720 dpi,1200 dpi,2400 dpi,4800 dpi", // filter 8 errors
	        //"Continuous",																// filter 15 errors
	        "Program Files,AutoCAD 2011,Sample,VisualLISP", // filter 6 errors
	        "Program Files,AutoCAD Hammer,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 1,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 2,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 3,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 4,Sample,VisualLISP",
	        "dpi", // filter 12 errors
	        "Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "OK", // filter 380 errors
	        "&OK", // filter 29 errors
	        //"Standard"																// filter 29 errors
	
	         //Added After FY2011
	        "Contract Number,Revision,Issue Date,Issued by,sdsf,sdgf,Approval Date,Approved by,Check Date,Checked by,Design activity,savitaj,Sheet Number",
	        "Description (DESCR)",
	        "NC (Genius)",
	        "TYP",
	        "Item (ITEM)"
        };

        ///////////////////////////////////////
        // PTB strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranPTB = new List<string>()
        {
            "150 dpi,200 dpi,300 dpi,400 dpi,600 dpi,720 dpi,1200 dpi,2400 dpi,4800 dpi", // filter 8 errors
	        //"Continuous",							// filter 15 errors
	        "Decimal", // filter 6 errors
	        //"Desktop",							// filter 14 errors
	        "Desktop,AutoCAD 2011", // filter 37 errors
	        "Desktop,AutoCAD Hammer", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 1", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 2", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 3", // filter 37 errors
	        "Desktop,AutoCAD Hammer Beta 4", // filter 37 errors
	        "Desktop,Buzzsaw,FTP", // filter 65 errors
	        "Desktop,Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "dpi", // filter 12 errors
	        "FTP,Desktop,Buzzsaw", // filter 6 errors
	        "Hori&zontal", // filter 9 errors
	        "FolderView", // filter 28 errors
	        "Integral", // filter 10 errors
	        "Magenta", // filter 65 errors
	        "OK", // filter 394 errors
	        "&OK", // filter 29 errors
	        //"Standard"							// filter 24 errors
	        "&Vertical", // filter 9 errors
	
	         //Added After FY2011
	        "DefaultTitle,Origin,Description",
	        "Poisson"
        };

        ///////////////////////////////////////
        // RUS strings that are NOT TRANSLATED
        ///////////////////////////////////////
        public List<string> lsTranRUS = new List<string>()
        {
            //"Continuous",							// filter 15 errors
	        "Documents and Settings", // filter 14 errors	in XPPro
	        "Program Files,AutoCAD 2011,Sample,VisualLISP", // filter 6 errors
	        "Program Files,AutoCAD Hammer,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 1,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 2,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 3,Sample,VisualLISP",
	        "Program Files,AutoCAD Hammer Beta 4,Sample,VisualLISP",
	        "Projects,Hammer,Tests,Harness,Tools,HarnessResources", // filter 17 errors
	        "FolderView", // filter 28 errors
	        "OK", // filter 394 errors
	        "&OK", // filter 29 errors
	        //"Standard"							// filter 24 errors
	
	         //Added After FY2011
	        "ANG",
	        "GAP",
	        "Gap",
	        "Column titles"
        };
    }
}

