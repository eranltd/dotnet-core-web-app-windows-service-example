#Requires -RunAsAdministrator
#Functions.psm1
Import-Module ./Functions.psm1
$service_name = "cpapiservice"


QueryServiceStatus $service_name


