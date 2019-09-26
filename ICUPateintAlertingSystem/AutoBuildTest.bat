@echo off
@echo off
set "BAT_PATH=%~dp0"

@echo off


call "C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\Tools\VsDevCmd.bat"

echo %BAT_PATH%

echo Executing batch file

devenv "%BAT_PATH%\ICUPateintAlertingSystem.sln" /build

pause

set "SIM_PATH=C:\Users\320067257\Downloads\Simian\bin"

cd "%SIM_PATH%"

simian-2.5.10.exe "%BAT_PATH%\**\*.cs"  

pause