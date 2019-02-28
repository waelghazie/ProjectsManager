@ECHO OFF
ECHO Plaese Don't Close This Window !
ECHO.
ECHO Welcome To Projects Manager Setup!
ECHO.
ECHO Installing Prerequisites, This may take several minutes

#ECHO.
#ECHO.
#ECHO Installing Projects Manager , Please Wait..
#START /W  Files\Setup.exe /passive

ECHO.
ECHO.
ECHO Installing SQL EXPRESS 2012, Please Wait..
START /W Files\SQLEXPR_x86_ENU.exe /ACTION=INSTALL /Role=ALLFeatures_WithDefaults /INSTANCENAME=SQLEXPRESS2012 /SAPWD=Proj3ct$M@nag3r /SECURITYMODE=SQL  /TCPENABLED=1 /BROWSERSVCSTARTUPTYPE="Automatic"  /IACCEPTSQLSERVERLICENSETERMS /UpdateEnabled=0  /ADDCURRENTUSERASSQLADMIN=true /QS


ECHO Thank You ..
ECHO.

PAUSE