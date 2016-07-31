echo off
cls
title Example 1 - .NET Server with .NET Client and TAODirectClient
echo -----------------------------------------------------------------------
echo Starting DotNetAdderServer
start StartDotNetAdderServer.bat %COMPUTERNAME% 12346
pause
echo Starting DotNetAdderClient
start StartDotNetAdderClient.bat %COMPUTERNAME% 12346
pause
echo Starting TAODirectAdderClient
start StartTaoDirectAdderClient.bat %COMPUTERNAME% 12346
pause
