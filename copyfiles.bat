mkdir packaging


:: NET 4.0
mkdir packaging\lib\NET40
copy build\NET40\UnitWrappers.dll packaging\lib\NET40\
copy build\NET40\UnitWrappers.pdb packaging\lib\NET40\
copy build\NET40\UnitWrappers.xml packaging\lib\NET40\

mkdir packaging\lib\NET40\src\
copy src\UnitWrappers.Helpers\*.cs packaging\lib\NET40\src\

:: NET 3.5
mkdir packaging\lib\NET35
copy build\NET35\UnitWrappers.dll packaging\lib\NET35\
copy build\NET35\UnitWrappers.pdb packaging\lib\NET35\
copy build\NET35\UnitWrappers.xml packaging\lib\NET35\