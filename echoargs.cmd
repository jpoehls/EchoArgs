@echo off

echo # %%CmdCmdLine%%
echo %CmdCmdLine%
echo.

echo # %%0
echo %0
echo.

echo # %%*
set /a c=1

setlocal ENABLEDELAYEDEXPANSION
FOR %%A IN (%*) DO (
	echo [!c!]: %%A
	set /a c=!c! + 1
)