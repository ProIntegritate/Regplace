# Regplace

Replace with pattern regexp. Bulk processing of logs.

<img src="Regplace.png">

# Examples:

*Anonymize specific ips*
- Regplace.exe file.log ", 100.64." ", x.x." 

*Remove part of string*
- Regplace.exe file.log "This is crap and needs to be removed" "" 
