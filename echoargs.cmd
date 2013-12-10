setlocal ENABLEDELAYEDEXPANSION
@echo off

echo [0]: %0

set /a c=1

FOR %%A IN (%*) DO (
	echo [!c!]: %%A
	set /a c=!c! + 1
)