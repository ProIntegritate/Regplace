# Regplace

Replace with pattern regexp. Bulk processing of logs.

<img src="Regplace.png">

# Examples:

*Anonymize specific ips*
- Regplace.exe file.log ", 100.64." ", x.x." 

*Remove part of string*
- Regplace.exe file.log "This is [crap|shit|junk] and needs to be removed" "" 

*Anonymizing hostname entries, i.e. PC123 to PCxxx*
- Regplace.exe file.log ", PC[0-9]{3}" ", PCxxx" 
