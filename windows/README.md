# Windows

## Powershell

### Checking Version

```powershell
Get-Host | Select-Object Version
```

Disable UAC

Disable Windows from asking you for Admin privileges every time you make a change to the computer.

```powershell
Set-ItemProperty -Path REGISTRY::HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\System -Name ConsentPromptBehaviorAdmin -Value 0
```

### Updating to Latest

To update to the latest version of Powershell via Powershell run the following:

```powershell
iex "& { $(irm https://aka.ms/install-powershell.ps1) } -UseMSI"
```

### Windows 11

[Bring back Windows 10 context menus](https://twitter.com/Nick_Craver/status/1494661475553714177).

```powershell
reg.exe add "HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32" /f /ve
```
