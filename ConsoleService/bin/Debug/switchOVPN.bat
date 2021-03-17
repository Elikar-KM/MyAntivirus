set max=5
set min=1
set /a number=%random%%%(max-min+1)+min

openvpn "config\VPN (%number%).ovpn"
pause