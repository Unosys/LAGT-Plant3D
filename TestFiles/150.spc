;; CADWorx Specification File
;;
;; 1. The first two sections, INFORMATION and NOTES, are required.
;;    Within the information section, WeightFactor, MeasureBore and
;;    LibrarySubDirectory must have an entry.  If using the CAESAR II
;;    interface, MaterialPipe, MaterialForging, etc. must have
;;    an entry.
;;
;; 2. The section names are based on CADWorx component numbers. See the
;;    file ...\<install dir>\System\Prgm.tbl for component numbers
;;    (i.e. Pipe = [001-01], 90 LR ELL BW = [002-01], etc.).
;;
;; 3. Each component does not require a section.  If 90
;;    LR elbows were absent from the specification, the program
;;    would inform the user that it is not available in the specification.
;;
;; 4. To add a new section to this file with a text editor,
;;    make sure to use the correct component number within the
;;    brackets.  The component numbers are followed by sub-entries
;;    within each section. [001-01], [001-02], And [001-03] means that
;;    there are three different types of piping available within the
;;    specification.  Each section can have 99 different sub-entries
;;    (i.e. [001-01] Through [[001-99]).


[INFORMATION]
WeightFactor=1.00
MeasureBore=Imperial-Inch
LibrarySubDirectory=LIB_I
NominalRating=150
Temperature=175 F
Pressure=205 PSI
FlangeFace=RAISED FACE
MaterialPipe=A-106-B
MaterialForging=A-105
MaterialFitting=A-234-WPB
MaterialGasket=1/8" FLEX
MaterialStud=A-194-2H
MaterialBolt=A-193-B7
ExcludeSizes=
Revision=2006
Color=7
DataBaseCodes=

[NOTES]
1=(text for note 1)

[001-01]
DataFileSubDirectory=XS
DataFileName=PIP_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=PIPE
LongDescription=PIPE, S/XS SMLS, ASTM A-106 GR B
DatabaseIndex=0001
BOMSortSequence=1
ProgramCode=1
OptionalComponent=0
Status=0
Note=

[001-02]
DataFileSubDirectory=STD
DataFileName=PIP_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=PIPE
LongDescription=PIPE, S/STD SMLS, ASTM A-106 GR B
DatabaseIndex=0001
BOMSortSequence=2
ProgramCode=1
OptionalComponent=0
Status=0
Note=

[002-01]
DataFileSubDirectory=XS
DataFileName=90L_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=LR 90%%D ELL
LongDescription=ELL, 90%%D LR S/XS, ASTM A-234 GR WPB
DatabaseIndex=0002
BOMSortSequence=3
ProgramCode=2
OptionalComponent=0
Status=0
Note=

[002-02]
DataFileSubDirectory=STD
DataFileName=90L_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=LR 90%%D ELL
LongDescription=ELL, 90%%D LR S/STD, ASTM A-234 GR WPB
DatabaseIndex=0002
BOMSortSequence=4
ProgramCode=2
OptionalComponent=0
Status=0
Note=

[003-01]
DataFileSubDirectory=XS
DataFileName=90L_W_S
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=SR 90%%D ELL
LongDescription=ELL, 90%%D SR S/XS, ASTM A-234 GR WPB
DatabaseIndex=0003
BOMSortSequence=5
ProgramCode=3
OptionalComponent=0
Status=0
Note=

[003-02]
DataFileSubDirectory=STD
DataFileName=90L_W_S
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=SR 90%%D ELL
LongDescription=ELL, 90%%D SR S/STD, ASTM A-234 GR WPB
DatabaseIndex=0003
BOMSortSequence=6
ProgramCode=3
OptionalComponent=0
Status=0
Note=

[004-01]
DataFileSubDirectory=XS
DataFileName=90L_W_R
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=RED 90%%D ELL
LongDescription=ELL, 90%%D RED S/XS, ASTM A-234 GR WPB
DatabaseIndex=0004
BOMSortSequence=7
ProgramCode=4
OptionalComponent=0
Status=0
Note=

[004-02]
DataFileSubDirectory=STD
DataFileName=90L_W_R
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=RED 90%%D ELL
LongDescription=ELL, 90%%D RED S/STD, ASTM A-234 GR WPB
DatabaseIndex=0004
BOMSortSequence=8
ProgramCode=4
OptionalComponent=0
Status=0
Note=

[005-01]
DataFileSubDirectory=XS
DataFileName=45L_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=45%%D LR ELL
LongDescription=ELL, 45%%D LR S/XS, ASTM A-234 GR WPB
DatabaseIndex=0005
BOMSortSequence=9
ProgramCode=5
OptionalComponent=0
Status=0
Note=

[005-02]
DataFileSubDirectory=STD
DataFileName=45L_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=45%%D LR ELL
LongDescription=ELL, 45%%D LR S/STD, ASTM A-234 GR WPB
DatabaseIndex=0005
BOMSortSequence=10
ProgramCode=5
OptionalComponent=0
Status=0
Note=

[006-01]
DataFileSubDirectory=XS
DataFileName=180_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=180 LR RETURN
LongDescription=180%%D RETURN, LR S/XS, ASTM
DatabaseIndex=0006
BOMSortSequence=11
ProgramCode=6
OptionalComponent=0
Status=0
Note=

[006-02]
DataFileSubDirectory=STD
DataFileName=180_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=180 LR RETURN
LongDescription=180%%D RETURN, LR S/STD, ASTM A-234 GR WPB
DatabaseIndex=0006
BOMSortSequence=12
ProgramCode=6
OptionalComponent=0
Status=0
Note=

[007-01]
DataFileSubDirectory=XS
DataFileName=180_W_S
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=180 SR RETURN
LongDescription=180%%D RETURN, SR S/XS, ASTM A-234 GR WPB
DatabaseIndex=0007
BOMSortSequence=13
ProgramCode=7
OptionalComponent=0
Status=0
Note=

[007-02]
DataFileSubDirectory=STD
DataFileName=180_W_S
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=180 SR RETURN
LongDescription=180%%D RETURN, SR S/STD, ASTM A-234 GR WPB
DatabaseIndex=0007
BOMSortSequence=14
ProgramCode=7
OptionalComponent=0
Status=0
Note=

[008-01]
DataFileSubDirectory=XS
DataFileName=TEE_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=TEE STR
LongDescription=TEE, STR. S/XS, ASTM ASTM A-234 GR WPB
DatabaseIndex=0008
BOMSortSequence=15
ProgramCode=8
OptionalComponent=0
Status=0
Note=

[008-02]
DataFileSubDirectory=STD
DataFileName=TEE_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=TEE STR
LongDescription=TEE, STR. S/STD, ASTM A-234 GR WPB
DatabaseIndex=0008
BOMSortSequence=16
ProgramCode=8
OptionalComponent=0
Status=0
Note=

[009-01]
DataFileSubDirectory=XS
DataFileName=TEE_W_R
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=TEE RED
LongDescription=TEE, REDUCING S/XS, ASTM A-234 GR WPB
DatabaseIndex=0009
BOMSortSequence=17
ProgramCode=9
OptionalComponent=0
Status=0
Note=

[009-02]
DataFileSubDirectory=STD
DataFileName=TEE_W_R
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=TEE RED
LongDescription=TEE, REDUCING S/STD, ASTM A-234 GR WPB
DatabaseIndex=0009
BOMSortSequence=18
ProgramCode=9
OptionalComponent=0
Status=0
Note=

[010-01]
DataFileSubDirectory=XS
DataFileName=CNC_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=CONC RED
LongDescription=REDUCER, CONC S/XS, ASTM A-234 GR WPB
DatabaseIndex=0010
BOMSortSequence=19
ProgramCode=10
OptionalComponent=0
Status=0
Note=

[010-02]
DataFileSubDirectory=STD
DataFileName=CNC_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=CONC RED
LongDescription=REDUCER, CONC S/STD, ASTM A-234 GR WPB
DatabaseIndex=0010
BOMSortSequence=20
ProgramCode=10
OptionalComponent=0
Status=0
Note=

[011-01]
DataFileSubDirectory=XS
DataFileName=ECC_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=ECC RED
LongDescription=REDUCER, ECC S/XS, ASTM A-234 GR WPB
DatabaseIndex=0011
BOMSortSequence=21
ProgramCode=11
OptionalComponent=0
Status=0
Note=

[011-02]
DataFileSubDirectory=STD
DataFileName=ECC_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=ECC RED
LongDescription=REDUCER, ECC S/STD, ASTM A-234 GR WPB
DatabaseIndex=0011
BOMSortSequence=22
ProgramCode=11
OptionalComponent=0
Status=0
Note=

[012-01]
DataFileSubDirectory=XS
DataFileName=CAP_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=CAP
LongDescription=CAP, S/80, ASTM ASTM A-234 GR WPB
DatabaseIndex=0012
BOMSortSequence=23
ProgramCode=12
OptionalComponent=0
Status=0
Note=

[012-02]
DataFileSubDirectory=STD
DataFileName=CAP_W
StartSize=2.0000
EndSize=30.0000
ComponentTag=
ShortDescription=CAP
LongDescription=CAP, S/STD, ASTM A-234 GR WPB
DatabaseIndex=0012
BOMSortSequence=24
ProgramCode=12
OptionalComponent=0
Status=0
Note=

[013-01]
DataFileSubDirectory=XS
DataFileName=CRS_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=CROSS STR
LongDescription=CROSS, STR S/XS, ASTM A-234 GR WPB
DatabaseIndex=0013
BOMSortSequence=25
ProgramCode=13
OptionalComponent=0
Status=0
Note=

[013-02]
DataFileSubDirectory=STD
DataFileName=CRS_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=CROSS STR
LongDescription=CROSS, STR S/STD, ASTM A-234 GR WPB
DatabaseIndex=0013
BOMSortSequence=26
ProgramCode=13
OptionalComponent=0
Status=0
Note=

[014-01]
DataFileSubDirectory=XS
DataFileName=CRS_W_R
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=CROSS RED
LongDescription=CROSS, RED S/XS, ASTM A-234 GR WPB
DatabaseIndex=0014
BOMSortSequence=27
ProgramCode=14
OptionalComponent=0
Status=0
Note=

[014-02]
DataFileSubDirectory=STD
DataFileName=CRS_W_R
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=CROSS RED
LongDescription=CROSS, RED S/STD, ASTM A-234 GR WPB
DatabaseIndex=0014
BOMSortSequence=28
ProgramCode=14
OptionalComponent=0
Status=0
Note=

[015-01]
DataFileSubDirectory=XS
DataFileName=LAT_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=45%%D LAT
LongDescription=LATERAL, 45%%D S/XS, ASTM A-234 GR WPB
DatabaseIndex=0015
BOMSortSequence=29
ProgramCode=15
OptionalComponent=0
Status=0
Note=

[015-02]
DataFileSubDirectory=STD
DataFileName=LAT_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=45%%D LAT
LongDescription=LATERAL, 45%%D S/STD, ASTM A-234 GR WPB
DatabaseIndex=0015
BOMSortSequence=30
ProgramCode=15
OptionalComponent=0
Status=0
Note=

[016-01]
DataFileSubDirectory=XS
DataFileName=STB_W
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=STUB END
LongDescription=STUB END, S/XS, ASTM A-234 GR WPB
DatabaseIndex=0016
BOMSortSequence=31
ProgramCode=16
OptionalComponent=0
Status=0
Note=

[016-02]
DataFileSubDirectory=STD
DataFileName=STB_W
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=STUB END
LongDescription=STUB END, S/STD, ASTM A-234 GR WPB
DatabaseIndex=0016
BOMSortSequence=32
ProgramCode=16
OptionalComponent=0
Status=0
Note=

[017-01]
DataFileSubDirectory=150
DataFileName=LWN_F
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=RF LWN
LongDescription=LONG WELD NECK, RF 150LB
DatabaseIndex=0017
BOMSortSequence=33
ProgramCode=17
OptionalComponent=0
Status=0
Note=

[018-01]
DataFileSubDirectory=150
DataFileName=FLG_W
StartSize=0.5000
EndSize=2.0000
ComponentTag=
ShortDescription=FLG. RFWN
LongDescription=FLG, RFWN 150LB S/XS BORE, ASTM A-105
DatabaseIndex=0018
BOMSortSequence=34
ProgramCode=18
OptionalComponent=0
Status=0
Note=

[018-02]
DataFileSubDirectory=150
DataFileName=FLG_W
StartSize=2.5000
EndSize=24.0000
ComponentTag=
ShortDescription=FLG. RFWN
LongDescription=FLG, RFWN 150LB S/STD BORE, ASTM A-105
DatabaseIndex=0018
BOMSortSequence=35
ProgramCode=18
OptionalComponent=0
Status=0
Note=

[018-03]
DataFileSubDirectory=300
DataFileName=FLG_W_O
StartSize=1.0000
EndSize=24.0000
ComponentTag=
ShortDescription=FLG. ORIFICE
LongDescription=FLG, RFWN 300LB ORIFICE, ASTM A-105
DatabaseIndex=0018
BOMSortSequence=35
ProgramCode=18
OptionalComponent=1
Status=0
Note=

[019-01]
DataFileSubDirectory=150
DataFileName=FLG_O
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=FLG. RFSO
LongDescription=FLG, RF SLIP-ON 150LB, ASTM A-105
DatabaseIndex=0019
BOMSortSequence=36
ProgramCode=19
OptionalComponent=0
Status=0
Note=

[020-01]
DataFileSubDirectory=150
DataFileName=FLG_B
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=FLG. RF BLD
LongDescription=FLG, RF BLIND 150LB, ASTM A-105
DatabaseIndex=0020
BOMSortSequence=37
ProgramCode=20
OptionalComponent=0
Status=0
Note=

[021-01]
DataFileSubDirectory=150
DataFileName=FLG_L
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=FLG. RF LAP
LongDescription=FLG, RF LAP 150LB, ASTM A-105
DatabaseIndex=0021
BOMSortSequence=38
ProgramCode=21
OptionalComponent=0
Status=0
Note=

[022-01]
DataFileSubDirectory=150
DataFileName=FLG_S
StartSize=0.5000
EndSize=4.0000
ComponentTag=
ShortDescription=FLG. RFSW
LongDescription=FLG, RFSW 150LB S/80 BORE, ASTM A-105
DatabaseIndex=0022
BOMSortSequence=39
ProgramCode=22
OptionalComponent=0
Status=0
Note=

[023-01]
DataFileSubDirectory=150
DataFileName=FLG_T
StartSize=0.5000
EndSize=4.0000
ComponentTag=
ShortDescription=FLG. RF THRD.
LongDescription=FLG, RF THRD 150LB, ASTM A-105
DatabaseIndex=0023
BOMSortSequence=40
ProgramCode=23
OptionalComponent=0
Status=0
Note=

[024-01]
DataFileSubDirectory=150
DataFileName=BLT_F
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=STUD W/ NUTS
LongDescription=STUD BOLTS W/ NUTS
DatabaseIndex=0024
BOMSortSequence=41
ProgramCode=24
OptionalComponent=0
Status=0
Note=

[025-01]
DataFileSubDirectory=150
DataFileName=GAS_F_2
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=GASKET
LongDescription=GASKET, 1/8" THK, 150LB
DatabaseIndex=0025
BOMSortSequence=42
ProgramCode=25
OptionalComponent=0
Status=0
Note=

[026-01]
DataFileSubDirectory=XXS
DataFileName=NIP_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=NIPPLE
LongDescription=NIPPLE, S/XXS SMLS, ASTM A-106 GR B
DatabaseIndex=0026
BOMSortSequence=43
ProgramCode=26
OptionalComponent=0
Status=0
Note=

[027-01]
DataFileSubDirectory=XS
DataFileName=SWG_T_C
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CONC SWG
LongDescription=SWAGE, CONC. S/80, ASTM A-234 GR WPB
DatabaseIndex=0027
BOMSortSequence=44
ProgramCode=27
OptionalComponent=0
Status=0
Note=

[028-01]
DataFileSubDirectory=XS
DataFileName=SWG_T_E
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=ECC SWG
LongDescription=SWAGE, ECC. S/80, ASTM A-234 GR WPB
DatabaseIndex=0028
BOMSortSequence=45
ProgramCode=28
OptionalComponent=0
Status=0
Note=

[029-01]
DataFileSubDirectory=30C
DataFileName=90L_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=90%%D SW ELL
LongDescription=90%%D ELL, SW 3000LB FS, ASTM A-105
DatabaseIndex=0029
BOMSortSequence=46
ProgramCode=29
OptionalComponent=0
Status=0
Note=

[030-01]
DataFileSubDirectory=30C
DataFileName=90L_S_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=90 STREET SW
LongDescription=90%%D ELL, SW STREET, 3000LB ASTM-105
DatabaseIndex=0030
BOMSortSequence=47
ProgramCode=30
OptionalComponent=0
Status=0
Note=

[031-01]
DataFileSubDirectory=30C
DataFileName=90L_S_R
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=90%%D RED SW
LongDescription=90%%D ELL, SW RED., 3000LB ASTM-105
DatabaseIndex=0031
BOMSortSequence=48
ProgramCode=31
OptionalComponent=0
Status=0
Note=

[032-01]
DataFileSubDirectory=30C
DataFileName=45L_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=45%%D SW ELL
LongDescription=45%%D ELL, SW 3000LB FS, ASTM A-105
DatabaseIndex=0032
BOMSortSequence=49
ProgramCode=32
OptionalComponent=0
Status=0
Note=

[033-01]
DataFileSubDirectory=30C
DataFileName=TEE_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=TEE SW STR
LongDescription=TEE, STR. SW 3000LB FS, ASTM A-105
DatabaseIndex=0033
BOMSortSequence=50
ProgramCode=33
OptionalComponent=0
Status=0
Note=

[034-01]
DataFileSubDirectory=30C
DataFileName=TEE_S_R
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=TEE SW RED
LongDescription=TEE, RED. SW 3000LB FS, ASTM A-105
DatabaseIndex=0034
BOMSortSequence=51
ProgramCode=34
OptionalComponent=0
Status=0
Note=

[035-01]
DataFileSubDirectory=30C
DataFileName=LAT_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=45%%D LAT SW
LongDescription=LATERAL, 45%%D SW 3000LB, ASTM A-105
DatabaseIndex=0035
BOMSortSequence=52
ProgramCode=35
OptionalComponent=0
Status=0
Note=

[036-01]
DataFileSubDirectory=30C
DataFileName=CRS_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CROSS STR SW
LongDescription=CROSS, STR. SW 3000LB, ASTM A-105
DatabaseIndex=0036
BOMSortSequence=53
ProgramCode=36
OptionalComponent=0
Status=0
Note=

[037-01]
DataFileSubDirectory=30C
DataFileName=BUS_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=BUSHING SW
LongDescription=BUSHING, RED. SW 3000LB, ASTM A-105
DatabaseIndex=0037
BOMSortSequence=54
ProgramCode=37
OptionalComponent=0
Status=0
Note=

[038-01]
DataFileSubDirectory=30C
DataFileName=CAP_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CAP SW
LongDescription=CAP, SW 3000LB FS, ASTM A-105
DatabaseIndex=0038
BOMSortSequence=55
ProgramCode=38
OptionalComponent=0
Status=0
Note=

[039-01]
DataFileSubDirectory=30C
DataFileName=CPL_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=SW CPLG
LongDescription=CPLG, SW 3000LB FS, ASTM A-105
DatabaseIndex=0039
BOMSortSequence=56
ProgramCode=39
OptionalComponent=0
Status=0
Note=

[040-01]
DataFileSubDirectory=30C
DataFileName=CPL_S_H
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=HALF SW CPLG
LongDescription=CPLG, HALF SW 3000LB FS, ASTM A-105
DatabaseIndex=0040
BOMSortSequence=57
ProgramCode=40
OptionalComponent=0
Status=0
Note=

[041-01]
DataFileSubDirectory=30C
DataFileName=UNN_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=UNION SW
LongDescription=UNION, SW 3000LB FS, ASTM A-105
DatabaseIndex=0041
BOMSortSequence=58
ProgramCode=41
OptionalComponent=0
Status=0
Note=

[042-01]
DataFileSubDirectory=150
DataFileName=BLR_F
StartSize=0.5000
EndSize=6.0000
ComponentTag=
ShortDescription=BLEED RING
LongDescription=BLEED RING, 150LB
DatabaseIndex=0042
BOMSortSequence=59
ProgramCode=42
OptionalComponent=0
Status=0
Note=

[043-01]
DataFileSubDirectory=30C
DataFileName=90L_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=90%%D THRD ELL
LongDescription=90%%D ELL, THRD 3000LB, ASTM A-105
DatabaseIndex=0043
BOMSortSequence=60
ProgramCode=43
OptionalComponent=0
Status=0
Note=

[044-01]
DataFileSubDirectory=30C
DataFileName=90L_T_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=90 STREET THRD
LongDescription=90 ELL, THRD STREET 3000LB ASTM A-105
DatabaseIndex=0044
BOMSortSequence=61
ProgramCode=44
OptionalComponent=0
Status=0
Note=

[045-01]
DataFileSubDirectory=30C
DataFileName=90L_T_R
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=90%%D RED THRD
LongDescription=90 ELL, THRD RED. 3000LB ASTM A-105
DatabaseIndex=0045
BOMSortSequence=62
ProgramCode=45
OptionalComponent=0
Status=0
Note=

[046-01]
DataFileSubDirectory=30C
DataFileName=45L_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=45%%D THRD ELL
LongDescription=45%%D ELL, THRD 3000LB, ASTM A-105
DatabaseIndex=0046
BOMSortSequence=63
ProgramCode=46
OptionalComponent=0
Status=0
Note=

[047-01]
DataFileSubDirectory=30C
DataFileName=TEE_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=TEE THRD STR
LongDescription=TEE, STR. THRD 3000LB, ASTM A-105
DatabaseIndex=0047
BOMSortSequence=64
ProgramCode=47
OptionalComponent=0
Status=0
Note=

[048-01]
DataFileSubDirectory=30C
DataFileName=TEE_T_R
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=TEE THRD RED
LongDescription=TEE, RED. THRD 3000LB, ASTM A-105
DatabaseIndex=0048
BOMSortSequence=65
ProgramCode=48
OptionalComponent=0
Status=0
Note=

[049-01]
DataFileSubDirectory=30C
DataFileName=LAT_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=45%%D LAT THRD
LongDescription=LATERAL, 45%%D THRD 3000LB ASTM A-105
DatabaseIndex=0049
BOMSortSequence=66
ProgramCode=49
OptionalComponent=0
Status=0
Note=

[050-01]
DataFileSubDirectory=30C
DataFileName=CRS_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CROSS STR THRD
LongDescription=CROSS, STR. THRD 3000LB, ASTM A-105
DatabaseIndex=0050
BOMSortSequence=67
ProgramCode=50
OptionalComponent=0
Status=0
Note=

[051-01]
DataFileSubDirectory=30C
DataFileName=BUS_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=BUSHING THRD
LongDescription=BUSHING, RED. THRD 3000LB, ASTM A-105
DatabaseIndex=0051
BOMSortSequence=68
ProgramCode=51
OptionalComponent=0
Status=0
Note=

[052-01]
DataFileSubDirectory=30C
DataFileName=CAP_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CAP THRD
LongDescription=CAP, THRD 3000LB, ASTM A-105
DatabaseIndex=0052
BOMSortSequence=69
ProgramCode=52
OptionalComponent=0
Status=0
Note=

[053-01]
DataFileSubDirectory=30C
DataFileName=CPL_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=THRD CPLG
LongDescription=CPLG, THRD 3000LB FS, ASTM A-105
DatabaseIndex=0053
BOMSortSequence=70
ProgramCode=53
OptionalComponent=0
Status=0
Note=

[054-01]
DataFileSubDirectory=30C
DataFileName=CPL_T_H
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=HALF THRD CPLG
LongDescription=CPLG, HALF THRD 3000LB FS, ASTM A-105
DatabaseIndex=0054
BOMSortSequence=71
ProgramCode=54
OptionalComponent=0
Status=0
Note=

[055-01]
DataFileSubDirectory=30C
DataFileName=UNN_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=UNION THRD
LongDescription=UNION, THRD 3000LB, ASTM A-105
DatabaseIndex=0055
BOMSortSequence=72
ProgramCode=55
OptionalComponent=0
Status=0
Note=

[056-01]
DataFileSubDirectory=30C
DataFileName=PLG_T
StartSize=0.5000
EndSize=2.0000
ComponentTag=
ShortDescription=THRD PLUG
LongDescription=PLUG, 316 SS BAR STOCK, THRD
DatabaseIndex=0056
BOMSortSequence=73
ProgramCode=56
OptionalComponent=0
Status=0
Note=

[057-01]
DataFileSubDirectory=30C
DataFileName=EOL_S
StartSize=0.5000
EndSize=12.0000
ComponentTag=
ShortDescription=EOL SW
LongDescription=EOL, SW 3000LB FS, ASTM A-105
DatabaseIndex=0057
BOMSortSequence=74
ProgramCode=57
OptionalComponent=0
Status=0
Note=

[058-01]
DataFileSubDirectory=30C
DataFileName=EOL_T
StartSize=0.5000
EndSize=12.0000
ComponentTag=
ShortDescription=EOL THRD
LongDescription=EOL, THRD 3000LB FS, ASTM A-105
DatabaseIndex=0058
BOMSortSequence=75
ProgramCode=58
OptionalComponent=0
Status=0
Note=

[059-01]
DataFileSubDirectory=STD
DataFileName=EOL_W
StartSize=0.5000
EndSize=12.0000
ComponentTag=
ShortDescription=EOL WELD
LongDescription=EOL, WELD STD, ASTM A-105
DatabaseIndex=0059
BOMSortSequence=76
ProgramCode=59
OptionalComponent=0
Status=0
Note=

[060-01]
DataFileSubDirectory=30C
DataFileName=SOL_S
StartSize=0.5000
EndSize=12.0000
ComponentTag=
ShortDescription=SOL
LongDescription=SOCKOLET, 3000LB FS, ASTM A-105
DatabaseIndex=0060
BOMSortSequence=77
ProgramCode=60
OptionalComponent=0
Status=0
Note=

[061-01]
DataFileSubDirectory=30C
DataFileName=TOL_T
StartSize=0.5000
EndSize=12.0000
ComponentTag=
ShortDescription=TOL
LongDescription=THREDOLET, 3000LB FS, ASTM A-105
DatabaseIndex=0061
BOMSortSequence=78
ProgramCode=61
OptionalComponent=0
Status=0
Note=

[062-01]
DataFileSubDirectory=STD
DataFileName=WOL_W
StartSize=0.5000
EndSize=12.0000
ComponentTag=
ShortDescription=WOL
LongDescription=WELDOLET, SCH STD, ASTM A-105
DatabaseIndex=0062
BOMSortSequence=79
ProgramCode=62
OptionalComponent=0
Status=0
Note=

[063-01]
DataFileSubDirectory=150
DataFileName=BAL_F_S
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=BALL VAL FLG
LongDescription=BALL VALVE, 150LB FLG
DatabaseIndex=0063
BOMSortSequence=80
ProgramCode=63
OptionalComponent=0
Status=0
Note=

[064-01]
DataFileSubDirectory=800
DataFileName=BAL_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=BALL VAL SW
LongDescription=BALL VALVE, 800LB SW
DatabaseIndex=0064
BOMSortSequence=81
ProgramCode=64
OptionalComponent=0
Status=0
Note=

[065-01]
DataFileSubDirectory=800
DataFileName=BAL_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=BALL VAL THRD
LongDescription=BALL VALVE, 800LB THRD
DatabaseIndex=0065
BOMSortSequence=82
ProgramCode=65
OptionalComponent=0
Status=0
Note=

[066-01]
DataFileSubDirectory=150
DataFileName=BFY_F_W
StartSize=2.0000
EndSize=12.0000
ComponentTag=
ShortDescription=BF VAL FLG
LongDescription=BUTTERFLY VALVE, 150LB FLG.
DatabaseIndex=0066
BOMSortSequence=83
ProgramCode=66
OptionalComponent=0
Status=0
Note=

[067-01]
DataFileSubDirectory=150
DataFileName=CHK_F
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=CHECK VAL FLG
LongDescription=CHECK VALVE, 150LB FLG
DatabaseIndex=0067
BOMSortSequence=84
ProgramCode=67
OptionalComponent=0
Status=0
Note=

[067-02]
DataFileSubDirectory=150
DataFileName=CHK_B
StartSize=2.0000
EndSize=16.0000
ComponentTag=
ShortDescription=CHECK VALVE BW
LongDescription=CHECK VALVE, 150LB BW
DatabaseIndex=0067
BOMSortSequence=67
ProgramCode=67
OptionalComponent=1
Status=0
Note=

[068-01]
DataFileSubDirectory=800
DataFileName=CHK_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CHECK VAL SW
LongDescription=CHECK VALVE, 800LB SW
DatabaseIndex=0068
BOMSortSequence=85
ProgramCode=68
OptionalComponent=0
Status=0
Note=

[069-01]
DataFileSubDirectory=800
DataFileName=CHK_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CHECK VAL THRD
LongDescription=CHECK VALVE, 800LB THRD
DatabaseIndex=0069
BOMSortSequence=86
ProgramCode=69
OptionalComponent=0
Status=0
Note=

[070-01]
DataFileSubDirectory=150
DataFileName=GAT_F
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=GATE VAL FLG
LongDescription=GATE VALVE, 150LB FLG
DatabaseIndex=0070
BOMSortSequence=87
ProgramCode=70
OptionalComponent=0
Status=0
Note=

[070-02]
DataFileSubDirectory=150
DataFileName=GAT_B
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=GATE VALVE BW
LongDescription=GATE VALVE, 150LB BW
DatabaseIndex=0070
BOMSortSequence=70
ProgramCode=70
OptionalComponent=1
Status=0
Note=

[071-01]
DataFileSubDirectory=800
DataFileName=GAT_S_C
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=GATE VAL SW
LongDescription=GATE VALVE, 800LB SW
DatabaseIndex=0071
BOMSortSequence=88
ProgramCode=71
OptionalComponent=0
Status=0
Note=

[072-01]
DataFileSubDirectory=800
DataFileName=GAT_T_C
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=GATE VAL THRD
LongDescription=GATE VALVE, 800LB THRD
DatabaseIndex=0072
BOMSortSequence=89
ProgramCode=72
OptionalComponent=0
Status=0
Note=

[073-01]
DataFileSubDirectory=150
DataFileName=GLB_F
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=GLOBE VAL FLG
LongDescription=GLOBE VALVE, 150LB FLG
DatabaseIndex=0073
BOMSortSequence=90
ProgramCode=73
OptionalComponent=0
Status=0
Note=

[073-02]
DataFileSubDirectory=150
DataFileName=GLB_B
StartSize=2.0000
EndSize=14.0000
ComponentTag=
ShortDescription=GLOBE VALVE BW
LongDescription=GLOBE VALVE, 150LB BW
DatabaseIndex=0073
BOMSortSequence=73
ProgramCode=73
OptionalComponent=1
Status=0
Note=

[074-01]
DataFileSubDirectory=800
DataFileName=GLB_S_C
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=GLOBE VAL SW
LongDescription=GLOBE VALVE, 800LB SW
DatabaseIndex=0074
BOMSortSequence=91
ProgramCode=74
OptionalComponent=0
Status=0
Note=

[075-01]
DataFileSubDirectory=800
DataFileName=GLB_T_C
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=GLOBE VAL THRD
LongDescription=GLOBE VALVE, 800LB THRD
DatabaseIndex=0075
BOMSortSequence=92
ProgramCode=75
OptionalComponent=0
Status=0
Note=

[076-01]
DataFileSubDirectory=150
DataFileName=PLU_F_R
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=PLUG VAL FLG
LongDescription=PLUG VALVE, 150LB FLG.
DatabaseIndex=0076
BOMSortSequence=93
ProgramCode=76
OptionalComponent=0
Status=0
Note=

[077-01]
DataFileSubDirectory=800
DataFileName=PLU_S_R
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=PLUG VAL SW
LongDescription=PLUG VALVE, 800LB SW
DatabaseIndex=0077
BOMSortSequence=94
ProgramCode=77
OptionalComponent=0
Status=0
Note=

[078-01]
DataFileSubDirectory=800
DataFileName=PLU_T_R
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=PLUG VAL THRD
LongDescription=PLUG VALVE, 800LB THRD
DatabaseIndex=0078
BOMSortSequence=95
ProgramCode=78
OptionalComponent=0
Status=0
Note=

[079-01]
DataFileSubDirectory=150
DataFileName=REL_F
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=RELIEF VAL FLG
LongDescription=RELIEF VALVE, 150LB X 150LB FLG.
DatabaseIndex=0079
BOMSortSequence=96
ProgramCode=79
OptionalComponent=0
Status=0
Note=

[080-01]
DataFileSubDirectory=800
DataFileName=REL_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=RELIEF VAL SW
LongDescription=RELIEF VALVE, 800LB SW
DatabaseIndex=0080
BOMSortSequence=97
ProgramCode=80
OptionalComponent=0
Status=0
Note=

[081-01]
DataFileSubDirectory=800
DataFileName=REL_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=RELIEF VAL THD
LongDescription=RELIEF VALVE, 800LB THRD
DatabaseIndex=0081
BOMSortSequence=98
ProgramCode=81
OptionalComponent=0
Status=0
Note=

[082-01]
DataFileSubDirectory=800
DataFileName=NED_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=NEEDLE VAL SW
LongDescription=NEEDLE VALVE, 800LB SW
DatabaseIndex=0082
BOMSortSequence=99
ProgramCode=82
OptionalComponent=0
Status=0
Note=

[083-01]
DataFileSubDirectory=800
DataFileName=NED_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=NEEDLE VAL THD
LongDescription=NEEDLE VALVE, 800LB THRD
DatabaseIndex=0083
BOMSortSequence=100
ProgramCode=83
OptionalComponent=0
Status=0
Note=

[084-01]
DataFileSubDirectory=150
DataFileName=3VA_F
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=3-WAY VAL FLG
LongDescription=3-WAY VALVE, 150LB FLG
DatabaseIndex=0084
BOMSortSequence=101
ProgramCode=84
OptionalComponent=0
Status=0
Note=

[085-01]
DataFileSubDirectory=800
DataFileName=3VA_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=3-WAY VAL SW
LongDescription=3-WAY VALVE, 800LB SW
DatabaseIndex=0085
BOMSortSequence=102
ProgramCode=85
OptionalComponent=0
Status=0
Note=

[086-01]
DataFileSubDirectory=800
DataFileName=3VA_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=3-WAY VAL THRD
LongDescription=3-WAY VALVE, 800LB THRD
DatabaseIndex=0086
BOMSortSequence=103
ProgramCode=86
OptionalComponent=0
Status=0
Note=

[087-01]
DataFileSubDirectory=150
DataFileName=4VA_F
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=4-WAY VAL FLG
LongDescription=4-WAY VALVE, 150LB FLG
DatabaseIndex=0087
BOMSortSequence=104
ProgramCode=87
OptionalComponent=0
Status=0
Note=

[088-01]
DataFileSubDirectory=800
DataFileName=4VA_S
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=4-WAY VAL SW
LongDescription=4-WAY VALVE, 800LB SW
DatabaseIndex=0088
BOMSortSequence=105
ProgramCode=88
OptionalComponent=0
Status=0
Note=

[089-01]
DataFileSubDirectory=800
DataFileName=4VA_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=4-WAY VAL THRD
LongDescription=4-WAY VALVE, 800LB THRD
DatabaseIndex=0089
BOMSortSequence=106
ProgramCode=89
OptionalComponent=0
Status=0
Note=

[090-01]
DataFileSubDirectory=150
DataFileName=CNT_F_A
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=CONT VAL FLG
LongDescription=CONTROL VALVE, 150LB FLG.
DatabaseIndex=0090
BOMSortSequence=107
ProgramCode=90
OptionalComponent=0
Status=0
Note=

[091-01]
DataFileSubDirectory=800
DataFileName=CNT_S_E
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CONT VAL SW
LongDescription=CONTROL VALVE, 800LB SW
DatabaseIndex=0091
BOMSortSequence=108
ProgramCode=91
OptionalComponent=0
Status=0
Note=

[092-01]
DataFileSubDirectory=800
DataFileName=CNT_T_A
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=CONT VAL THRD
LongDescription=CONTROL VALVE, 800LB THRD
DatabaseIndex=0092
BOMSortSequence=109
ProgramCode=92
OptionalComponent=0
Status=0
Note=

[093-01]
DataFileSubDirectory=150
DataFileName=STR_F
StartSize=0.5000
EndSize=24.0000
ComponentTag=
ShortDescription=STRAINER FLG
LongDescription=STRAINER, 150LB FLG.
DatabaseIndex=0093
BOMSortSequence=110
ProgramCode=93
OptionalComponent=0
Status=0
Note=

[094-01]
DataFileSubDirectory=30C
DataFileName=STR_S
StartSize=0.5000
EndSize=2.0000
ComponentTag=
ShortDescription=STRAINER SW
LongDescription=STRAINER, 800LB SW
DatabaseIndex=0094
BOMSortSequence=111
ProgramCode=94
OptionalComponent=0
Status=0
Note=

[095-01]
DataFileSubDirectory=30C
DataFileName=STR_T
StartSize=0.5000
EndSize=2.0000
ComponentTag=
ShortDescription=STRAINER THRD
LongDescription=STRAINER, 800LB THRD
DatabaseIndex=0095
BOMSortSequence=112
ProgramCode=95
OptionalComponent=0
Status=0
Note=

[096-01]
DataFileSubDirectory=150
DataFileName=ANG_F
StartSize=2.5000
EndSize=24.0000
ComponentTag=
ShortDescription=ANGLE VAL FLG
LongDescription=ANGLE VALVE, 150LB FLG
DatabaseIndex=0096
BOMSortSequence=113
ProgramCode=96
OptionalComponent=0
Status=0
Note=

[097-01]
DataFileSubDirectory=800
DataFileName=ANG_S_C
StartSize=0.5000
EndSize=2.0000
ComponentTag=
ShortDescription=ANGLE VAL SW
LongDescription=ANGLE VALVE, 800LB SW
DatabaseIndex=0097
BOMSortSequence=114
ProgramCode=97
OptionalComponent=0
Status=0
Note=

[098-01]
DataFileSubDirectory=800
DataFileName=ANG_T_C
StartSize=0.5000
EndSize=2.0000
ComponentTag=
ShortDescription=ANGLE VAL THRD
LongDescription=ANGLE VALVE, 800LB THRD
DatabaseIndex=0098
BOMSortSequence=115
ProgramCode=98
OptionalComponent=0
Status=0
Note=

[100-01]
DataFileSubDirectory=60C
DataFileName=GAG_T
StartSize=0.5000
EndSize=2.5000
ComponentTag=
ShortDescription=GAGE VAL THRD
LongDescription=GAGE VALVE, 6000LB THRD
DatabaseIndex=0100
BOMSortSequence=117
ProgramCode=100
OptionalComponent=0
Status=0
Note=

[101-01]
DataFileSubDirectory=150
DataFileName=SPC_F
StartSize=2.5000
EndSize=24.0000
ComponentTag=
ShortDescription=SPEC BLD
LongDescription=BLIND, SPECTACLE, 150LB, ASTM A-105
DatabaseIndex=0101
BOMSortSequence=118
ProgramCode=101
OptionalComponent=0
Status=0
Note=

[102-01]
DataFileSubDirectory=150
DataFileName=EXP_F_2
StartSize=2.5000
EndSize=24.0000
ComponentTag=
ShortDescription=EXP JOINT
LongDescription=JOINT, EXPANSION, 150LB, FLG
DatabaseIndex=0102
BOMSortSequence=119
ProgramCode=102
OptionalComponent=0
Status=0
Note=

[115-01]
DataFileSubDirectory=150
DataFileName=FLG_O_RD
StartSize=0.7500
EndSize=12.0000
ComponentTag=
ShortDescription=FLG REDUCING
LongDescription=FLG REDUCING SO, ASTM A-105
DatabaseIndex=0115
BOMSortSequence=115
ProgramCode=115
OptionalComponent=0
Status=0
Note=

[116-01]
DataFileSubDirectory=150
DataFileName=FLG_T_RD
StartSize=0.7500
EndSize=12.0000
ComponentTag=
ShortDescription=FLG REDUCING
LongDescription=FLG REDUCING THRD, ASTM A-105
DatabaseIndex=0116
BOMSortSequence=116
ProgramCode=116
OptionalComponent=0
Status=0
Note=

[117-01]
DataFileSubDirectory=150
DataFileName=FLG_W_RD
StartSize=0.7500
EndSize=12.0000
ComponentTag=
ShortDescription=FLG REDUCING
LongDescription=FLG REDUCING WN, ASTM A-105
DatabaseIndex=0117
BOMSortSequence=117
ProgramCode=117
OptionalComponent=0
Status=0
Note=

[118-01]
DataFileSubDirectory=30C
DataFileName=CPL_S_R
StartSize=0.2500
EndSize=4.0000
ComponentTag=
ShortDescription=CPLG RED SW
LongDescription=COUPLING RED SW, ASTM A-105
DatabaseIndex=0118
BOMSortSequence=118
ProgramCode=118
OptionalComponent=0
Status=0
Note=

[119-01]
DataFileSubDirectory=30C
DataFileName=CPL_T_R
StartSize=0.2500
EndSize=4.0000
ComponentTag=
ShortDescription=CPLG RED THRD
LongDescription=COUPLING RED THRD, ASTM A-105
DatabaseIndex=0119
BOMSortSequence=119
ProgramCode=119
OptionalComponent=0
Status=0
Note=

[120-01]
DataFileSubDirectory=30C
DataFileName=LOL_S
StartSize=1.2500
EndSize=10.0000
ComponentTag=
ShortDescription=LOL SW
LongDescription=LATERAL-O-LET SW, ASTM A-105
DatabaseIndex=0120
BOMSortSequence=120
ProgramCode=120
OptionalComponent=0
Status=0
Note=

[121-01]
DataFileSubDirectory=30C
DataFileName=LOL_T
StartSize=1.2500
EndSize=10.0000
ComponentTag=
ShortDescription=LOL THRD
LongDescription=LATERAL-O-LET THRD, ASTM A-105
DatabaseIndex=0121
BOMSortSequence=121
ProgramCode=121
OptionalComponent=0
Status=0
Note=

[122-01]
DataFileSubDirectory=STD
DataFileName=LOL_W
StartSize=1.2500
EndSize=10.0000
ComponentTag=
ShortDescription=LOL WELED
LongDescription=LATERAL-O-LET WELD, ASTM A-105
DatabaseIndex=0122
BOMSortSequence=122
ProgramCode=122
OptionalComponent=0
Status=0
Note=

[123-01]
DataFileSubDirectory=XS
DataFileName=NOL_T
StartSize=1.2500
EndSize=10.0000
ComponentTag=
ShortDescription=NOL THRD
LongDescription=NIP-O-LET THRD, ASTM A-105
DatabaseIndex=0123
BOMSortSequence=123
ProgramCode=123
OptionalComponent=0
Status=0
Note=

[124-01]
DataFileSubDirectory=XS
DataFileName=NOL_W
StartSize=1.2500
EndSize=10.0000
ComponentTag=
ShortDescription=NOL PLAIN
LongDescription=NIP-O-LET PLAIN, ASTM A-105
DatabaseIndex=0124
BOMSortSequence=124
ProgramCode=124
OptionalComponent=0
Status=0
Note=

[141-01]
DataFileSubDirectory=800
DataFileName=EGAT_S
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=X-GATE SW
LongDescription=XBODY GATE VALVE SW
DatabaseIndex=0141
BOMSortSequence=141
ProgramCode=141
OptionalComponent=0
Status=0
Note=

[142-01]
DataFileSubDirectory=800
DataFileName=EGAT_T
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=X-GATE THRD
LongDescription=XBODY GATE VALVE THRD
DatabaseIndex=0142
BOMSortSequence=142
ProgramCode=142
OptionalComponent=0
Status=0
Note=

[143-01]
DataFileSubDirectory=800
DataFileName=EGAT_B
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=X-GATE BW
LongDescription=XBODY GATE VALVE BW
DatabaseIndex=0143
BOMSortSequence=143
ProgramCode=143
OptionalComponent=0
Status=0
Note=

[173-01]
DataFileSubDirectory=XS
DataFileName=WELD_1
StartSize=0.5000
EndSize=1.5000
ComponentTag=
ShortDescription=WELD
LongDescription=WELD GAP, 1/16" THK
DatabaseIndex=0173
BOMSortSequence=173
ProgramCode=173
OptionalComponent=0
Status=0
Note=

[173-02]
DataFileSubDirectory=STD
DataFileName=WELD_2
StartSize=2.0000
EndSize=24.0000
ComponentTag=
ShortDescription=WELD
LongDescription=WELD GAP, 1/8" THK
DatabaseIndex=0173
BOMSortSequence=173
ProgramCode=173
OptionalComponent=0
Status=0
Note=

