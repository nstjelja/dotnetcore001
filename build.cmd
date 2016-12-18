echo off
set currentDirectory=%1
echo on
@CALL :build %currentDirectory%\src\Algorithms
@CALL :build %currentDirectory%\src\People
@CALL :build %currentDirectory%\src\Start
@CALL :build %currentDirectory%\test\Algorithms.Tests
@CALL :build %currentDirectory%\test\People.Tests
@CALL :build %currentDirectory%\test\Start.Test

dotnet test %currentDirectory%\test\Algorithms.Tests
dotnet test %currentDirectory%\test\People.Tests
dotnet test %currentDirectory%\test\Start.Test


:build
dotnet restore %~f1
dotnet build  %~f1 
@IF /I "%ERRORLEVEL%" NEQ "0" (
    ECHO execution failed  %currentDirectory%\src\Algorithms
    Exit
)
@EXIT /B

