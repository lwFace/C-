echo off
cls
title TAOAdderClient
echo -----------------------------------------------------------------------
echo Starting TAOAdderClient on %1:%2
echo -ORBInitRef NameService=iiop://%1:%2/NameService
echo -----------------------------------------------------------------------
TAOAdderClient -ORBInitRef NameService=iiop://%1:%2/NameService
