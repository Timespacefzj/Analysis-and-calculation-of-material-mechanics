; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "材力分析计算精灵"
#define MyAppVersion "1.0"
#define MyAppPublisher "冯智健"
#define MyAppExeName "材料软件.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
AppId={{5F1F3CA2-9E1A-44AD-83DE-C204D70BFA55}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=F:\Visual Studio 2017\Projects\材料软件\材料软件\许可文件.txt
InfoBeforeFile=F:\Visual Studio 2017\Projects\材料软件\材料软件\安装前信息.txt
InfoAfterFile=F:\Visual Studio 2017\Projects\材料软件\材料软件\安装后信息.txt
OutputDir=F:\Visual Studio 2017\Projects\材料软件
OutputBaseFilename=材力分析计算精灵
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"
Name: "english"; MessagesFile: "compiler:Languages\English.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\材料软件.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\AGI.STKX.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\AxInterop.AGI.STKX.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\db1.mdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\db2.mdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\db3.mdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\texture1.bmp"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\texture2.jpg"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\材料软件.exe.CodeAnalysisLog.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\材料软件.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\材料软件.exe.lastcodeanalysissucceeded"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Visual Studio 2017\Projects\材料软件\材料软件\bin\Debug\材料软件.pdb"; DestDir: "{app}"; Flags: ignoreversion
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Registry]
Root:HKCU;Subkey:"Software\HIT";Flags:uninsdeletekeyifempty
