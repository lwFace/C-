echo off
cls
title TAOAdderServer
echo -----------------------------------------------------------------------
echo Starting TAOAdderServer on %1:%2
echo -ORBInitRef NameService=iiop://%1:%2/NameService
echo -----------------------------------------------------------------------
TAOAdderServer -ORBInitRef NameService=iiop://%1:%2/NameService
