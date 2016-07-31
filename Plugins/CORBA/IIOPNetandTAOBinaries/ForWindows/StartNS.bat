echo off
cls
title NameService - %COMPUTERNAME%:%1
echo -----------------------------------------------------------------------
echo Starting ACE/TAO Naming Service on  %COMPUTERNAME%
echo -m 0 -ORBEndpoint iiop://%COMPUTERNAME%:%1 -ORBDebugLevel 4
echo -----------------------------------------------------------------------
%TAO_ROOT%\orbsvcs\Naming_Service\Release\Naming_Service.exe -m 0 -ORBEndpoint iiop://%COMPUTERNAME%:%1 -ORBDebugLevel 4
