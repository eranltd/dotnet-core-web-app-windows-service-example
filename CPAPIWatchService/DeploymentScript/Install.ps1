#Requires -RunAsAdministrator
#Functions.psm1
Import-Module ./Functions.psm1
$installation_path_src = "../bin\Debug\netcoreapp2.2\win7-x64\"
$installation_path_dst = "C:\Program Files\R2Net\CPAPIService\"
#copy files to C:\Program Files\R2Net\R2NetCPAPIService

Write-Host
        "Copying Service Files to $installation_path_dst"

#New-Item -ItemType Directory -Force -Path $installation_path_dst
Copy-Item -Path $installation_path_src -Destination $installation_path_dst -Recurse -Force #works

Write-Host
        "Copying Service Files Done."

Write-Host
        "Installing Service..."

#install service

#$acl = Get-Acl "$installation_path_dst"
#$aclRuleArgs = {VMCLUSTER2\CertProcessorService}, "Read,Write,ReadAndExecute", "ContainerInherit,ObjectInherit", "None", "Allow"
#$accessRule = New-Object System.Security.AccessControl.FileSystemAccessRule($aclRuleArgs)
#$acl.SetAccessRule($accessRule)
#$acl | Set-Acl "$installation_path_dst"

$service_name = "cpapiservice"
$binary_path_name = "$installation_path_dst\CPAPIWatchService.exe"
$cred = "VMCLUSTER2\CertProcessorService"
$description = "CPAPI service, monitors the activity of CertProcessor API and Certificates Cache Remover,http://localhost:5050"
$display_name = "R2Net CPAPI Windows Service"

Write-Host
        "service_name : $service_name"
Write-Host
        "binary_path_name : $binary_path_name"
Write-Host
        "cred : $cred"
Write-Host
        "description : $description"
Write-Host
        "display_name : $display_name"


#with Credential
New-Service -Name $service_name -Credential $cred  -BinaryPathName $binary_path_name -Description $description -DisplayName $display_name -StartupType Automatic

#without Credential
#New-Service -Name $service_name -BinaryPathName $binary_path_name -Description $description -DisplayName $display_name -StartupType Automatic

#start Service


Write-Host
        "Starting Service..."

Start-Sleep -Seconds 2

Start-Service-My $service_name
