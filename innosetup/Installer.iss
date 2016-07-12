; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Nextest Utilization Tracker"
#define MyAppVersion "2.1.0.0"
#define MyAppPublisher "Lattice Semiconductor"
#define MyAppURL "www.latticesemi.com"
#define MyAppExeName "nxtuitrack.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4D81E2E3-5886-4342-8AF1-D20355752124}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=nxtuitrack-setup
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin

[Registry]
Root:  HKLM; Subkey: "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"; ValueType: string;  ValueName: "nxttrackui"; ValueData: "{app}\{#MyAppExeName}" 
Root:  HKLM; Subkey: "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"; ValueType: string;  ValueName: "SystemService"; ValueData: "{win}\systemservice.exe"
Root:  HKLM; Subkey: "SOFTWARE\Lattice\Nextest Utilization Tracker\"; ValueType: string; ValueName: "InstallPath"; ValueData: "{app}"
;Root:  HKLM; Subkey: "SOFTWARE\Lattice\Nextest Utilization Tracker\"; ValueType: string; ValueName: "app1"; ValueData: "ui.exe,none,Nextest UI"
;Root:  HKLM; Subkey: "SOFTWARE\Lattice\Nextest Utilization Tracker\"; ValueType: string; ValueName: "app2"; ValueData: "lotcontrolform.exe,C:\nextest\LotControlForm\Release\,Lot Control Form"

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\systemservice\bin\Debug\systemservice.exe"; DestDir: "{win}"; Flags: ignoreversion
Source: "..\nxtuitracker\bin\Debug\nxtuitrack.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "uninstall.bat"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\Uninstall"; Filename: "{app}\uninstall.bat"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
;Filename: "{win}\SystemService.exe"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
