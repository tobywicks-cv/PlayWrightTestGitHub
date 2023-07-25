@echo off
setlocal
if not defined PLAYWRIGHT_NODEJS_PATH set PLAYWRIGHT_NODEJS_PATH=%~dp0node.exe
"%PLAYWRIGHT_NODEJS_PATH%" "%~dp0..\..\package\lib\cli\cli.js" %*
rem "%PLAYWRIGHT_NODEJS_PATH%" --inspect-brk "%~dp0..\..\package\lib\cli\cli.js" %*