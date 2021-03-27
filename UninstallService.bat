sc delete "NWAntivirusService"
if not exist "C:\NWAntivirus" mkdir C:\NWAntivirus
rd /s /q "C:\NWAntivirus"
pause