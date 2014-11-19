
set outputDirectory=nuget

mkdir %outputDirectory%
:: NET 4.0
mkdir %outputDirectory%\lib\NET40
copy bin\NET40\UnitWrappers.dll %outputDirectory%\lib\NET40\
copy bin\NET40\UnitWrappers.pdb %outputDirectory%\lib\NET40\
copy bin\NET40\UnitWrappers.xml %outputDirectory%\lib\NET40\

:: NET 3.5
mkdir %outputDirectory%\lib\NET35
copy bin\NET35\UnitWrappers.dll %outputDirectory%\lib\NET35\
copy bin\NET35\UnitWrappers.pdb %outputDirectory%\lib\NET35\
copy bin\NET35\UnitWrappers.xml %outputDirectory%\lib\NET35\