echo off
cls
title nslister
echo -----------------------------------------------------------------------
echo Listing NameService Contexts on %COMPUTERNAME%
echo nslister.exe -ORBInitRef NameService=iiop://%1:%2/NameService
echo -----------------------------------------------------------------------
nslister.exe -ORBInitRef NameService=iiop://%1:%2/NameService



