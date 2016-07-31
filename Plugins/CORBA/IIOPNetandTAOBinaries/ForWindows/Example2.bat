echo off
cls
title Example 2 - ACE/TAO NameService with TAO Server, TAO Client, .NET Client
echo -----------------------------------------------------------------------
echo Starting ACE/TAO Naming Service on  %COMPUTERNAME%:12345
start StartNS.bat 12345
pause
echo Starting TAOAdderServer on %COMPUTERNAME% 12345
start StartTaoAdderServer.bat %COMPUTERNAME% 12345
pause
echo Running nslister to show the NameService Name Graph...
start ShowNS.bat %COMPUTERNAME% 12345
pause
echo Starting TAOAdderClient on %COMPUTERNAME% 12345
start StartTaoAdderClient.bat %COMPUTERNAME% 12345
pause
echo Starting DotNetNSAdderClient on %COMPUTERNAME% 12345
start StartDotNetNSAdderClient.bat %COMPUTERNAME% 12345
pause
