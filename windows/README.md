# Windows

## Powershell

### Checking Version

```powershell
Get-Host | Select-Object Version
```

### Updating to Latest

To update to the latest version of Powershell via Powershell run the following:

```powershell
iex "& { $(irm https://aka.ms/install-powershell.ps1) } -UseMSI"
```
