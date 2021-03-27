C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe "%~dp0AntivirusService\bin\Debug\AntivirusService.exe"
if not exist "C:\NWAntivirus" mkdir C:\NWAntivirus
copy /Y "%~dp0AntiDB.db" "C:\NWAntivirus\AntiDB.db"
pause