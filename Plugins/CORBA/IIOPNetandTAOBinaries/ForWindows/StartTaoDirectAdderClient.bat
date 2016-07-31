echo off
cls
title TAODirectAdderClient
echo -----------------------------------------------------------------------
echo Starting TAODirectAdderClient
echo -ORBInitRef IAdder=iiop://%1:%2/IAdder
echo -----------------------------------------------------------------------
TAODirectAdderClient -ORBInitRef IAdder=iiop://%1:%2/IAdder

