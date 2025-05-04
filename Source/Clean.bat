@ECHO OFF
PUSHD %~dp0

RD .vs /S /Q 2>nul
FOR /D /R %%a IN (obj) DO RD "%%a" /S /Q 2>nul
FOR /D /R %%a IN (bin) DO RD "%%a" /S /Q 2>nul

POPD
