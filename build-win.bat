@echo off

PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319

set ICON=icon\wol-orange.ico

csc /win32icon:%ICON%  wol.cs

echo Done

pause
