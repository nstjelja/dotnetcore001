echo off
set currentDirectory=%1
echo on
dotnet restore %currentDirectory%\src\People
dotnet build %currentDirectory%\src\People
dotnet restore %currentDirectory%\src\Start
dotnet build %currentDirectory%\src\Start
dotnet restore %currentDirectory%\test\People.Tests
dotnet restore %currentDirectory%\test\Start.Test
dotnet test %currentDirectory%\test\People.Tests
dotnet test %currentDirectory%\test\Start.Test