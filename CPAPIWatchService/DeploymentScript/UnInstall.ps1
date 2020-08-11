#Requires -RunAsAdministrator
#Functions.psm1
Import-Module ./Functions.psm1

$service_name = "cpapiservice"
$installation_path = "C:\Program Files\R2Net\CPAPIService\"

#stopping the service and wait for status...
Write-Host
        "Stopping the service..."

Stop-Service $service_name

Start-Sleep -Seconds 2
#remove service
Remove-Service -Name $service_name

#remove files from C:\Program Files\R2Net\R2NetCPAPIService

Write-Host
        "Removing the service files from $installation_path_dst"


Remove-Item -Recurse -Force $installation_path

#checking 