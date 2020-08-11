function Test-Call(){
Write-Host
		"Running from Functions.pff file."
}

function Get-Service-My([string]$serviceName = $(throw "serviceName is required"))
{
	$srvName = $serviceName
     Write-Host
			"Query about service: $serviceName"
    $service = Get-Service | Where-Object {($_.Name -like "$srvName")}
	

    return $service

}

 function QueryServiceStatus([string]$serviceName = $(throw "serviceName is required"))
 {
     Write-Host
			"Query about service: $serviceName"

	 $service = Get-Service-My $serviceName

    if (!($service))
    { 
        Write-Warning "Failed to find service $serviceName."
        return
    }
    "Found service $serviceName"
    "Query Service Status:"
    
    if ($service.Started)
    {
        Write-Host 'Service is now Running on remote machine'
    }
    else
        {
    Write-Host 'Service is NOT Running on remote machine'
        }

 }

 function Stop-Service([string]$serviceName = $(throw "serviceName is required"))
{
    $service = Get-Service-My $serviceName 
     
    if (!($service))
    { 
        Write-Warning "Failed to find service $serviceName."
        return
    }
     
    "Found service $serviceName checking status"
             
    if ($service.Started)
    {
        "Stopping service $serviceName"
        #could also use Set-Service, net stop, SC, psservice, psexec etc.
#        $service.StopService()

		$result = Stop-Service -Name "$serviceName" -Force -Confirm
    }

     #query again to check service status
     $service = Get-Service-My $serviceName 
     if ($arrService.Status -eq 'Running')
    {
        Write-Host 'Service is now Running on remote machine'
    }
        else
        {
        Write-Host 'Service is NOT Running on remote machine'
        }
    
 }

 function Start-Service-My([string]$serviceName = $(throw "serviceName is required"))
 {
 
     $service = Get-Service-My $serviceName 
     
    if (!($service))
    { 
        Write-Warning "Failed to find service $serviceName."
        return
    }
    "Found service $serviceName"
    "Starting Service..."
    if (!$service.Started)
    {
		$result = Start-Service -Name "$serviceName"
        "Service has been started..."
       
    }
    else
    {
    "$serviceName has been Started already."
    }
 }

function Uninstall-Service(
    [string]$serviceName = $(throw "serviceName is required") 
    )
{
    $service = Get-Service-My $serviceName 
     
    if (!($service))
    { 
        Write-Warning "Failed to find service $serviceName . Nothing to uninstall."
        return
    }
     
    "Found service $serviceName; checking status"
             
    if ($service.Started)
    {
        "Stopping service $serviceName"
        #could also use Set-Service, net stop, SC, psservice, psexec etc.
        $result = $service.StopService()
        Test-ServiceResult -operation "Stop service $serviceName" -result $result
    }
     
    "Attempting to uninstall service $serviceName"
    $result = $service.Delete()
    Test-ServiceResult -operation "Delete service $serviceName" -result $result   
}

function Test-ServiceResult(
    [string]$operation = $(throw "operation is required"), 
    [object]$result = $(throw "result is required"), 
    [switch]$continueOnError = $false)
{
    $retVal = -1
    if ($result.GetType().Name -eq "UInt32") { $retVal = $result } else {$retVal = $result.ReturnValue}
         
    if ($retVal -eq 0) {return}
     
    $errorcode = 'Success,Not Supported,Access Denied,Dependent Services Running,Invalid Service Control'
    $errorcode += ',Service Cannot Accept Control, Service Not Active, Service Request Timeout'
    $errorcode += ',Unknown Failure, Path Not Found, Service Already Running, Service Database Locked'
    $errorcode += ',Service Dependency Deleted, Service Dependency Failure, Service Disabled'
    $errorcode += ',Service Logon Failure, Service Marked for Deletion, Service No Thread'
    $errorcode += ',Status Circular Dependency, Status Duplicate Name, Status Invalid Name'
    $errorcode += ',Status Invalid Parameter, Status Invalid Service Account, Status Service Exists'
    $errorcode += ',Service Already Paused'
    $desc = $errorcode.Split(',')[$retVal]
     
    $msg = ("{0} failed with code {1}:{2}" -f $operation, $retVal, $desc)
     
    if (!$continueOnError) { Write-Error $msg } else { Write-Warning $msg }        
}


Export-ModuleMember Test-ServiceResult
Export-ModuleMember Uninstall-Service
Export-ModuleMember Start-Service-My
Export-ModuleMember QueryServiceStatus
Export-ModuleMember Stop-Service
Export-ModuleMember Get-Service-My
Export-ModuleMember Test-Call
