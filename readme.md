# DSOFramer WinForms Demo

This demo shows Microsoft Office interoperability/embedding in .NET WinForms using the Microsoft `DSOFramer` ActiveX sample control.

## Usage

1. Microsoft Office has to be installed.
2. Copy `dsoframer.ocx` to `C:\Windows\SysWow64` (with administrative rights)
3. Register `dsoframer.ocx` once (with administrative rights): `C:\Windows\SysWow64\regsvr32.exe C:\Windows\SysWow64\dsoframer.ocx`
4. Run `DSOFramer.DemoAppForms.exe`

## Updating AxDSOFramer.dll

If necessary, you can update the ActiveX/Typelib interop libraries following these steps:

1. Open a `Developer Command Prompt for VS 2022` (or higher).
2. Change to the drive and folder where the `.csproj` is located.
3. `cd lib`
4. `aximp C:\Windows\SysWow64\dsoframer.ocx`
5. Done!

## Change List

* 2025-02-16 Rework by @prof79 started
* 2019-08-14 init projects

## References

* <https://stackoverflow.com/questions/4075802/creating-a-dpi-aware-application>
* <https://learn.microsoft.com/en-us/windows/win32/hidpi/setting-the-default-dpi-awareness-for-a-process>
 