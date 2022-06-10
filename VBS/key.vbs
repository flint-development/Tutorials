' Extract Windows 7 and Office 2010 Product Keys
' Windows 10 Product Keys from migration of Windows 7 are also shown
' Double click in explorer or run in cmd with cscript MSProductKeys.vbs
' Tested for Win 7 & 10, Office 2010 32bit & 64bit
' Source ref: http://jacobsalmela.com/find-your-windows-product-key-without-any-software/
' Source ref: http://www.instructables.com/id/How-to-Find-Lost-Windows-Product-Key/
' Reference: https://support.microsoft.com/de-ch/kb/2581695
' Reference: https://autohotkey.com/board/topic/73278-microsoft-office-and-windows-product-key-enumeration-script/
' Reference: http://stackoverflow.com/questions/6462462/office-2010-product-key-registration-lookup

Set WshShell = CreateObject("WScript.Shell")

winKey = ConvertToKey(WshShell.RegRead("HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId"), "Windows")

On Error Resume Next
' 64bit
officeBit = "64bit"
officeKey = ConvertToKey(WshShell.RegRead("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office\14.0\Registration\{90140000-003D-0000-1000-0000000FF1CE}\DigitalProductId"), "Office2010")
If Err <> 0 Then
    ' Wscript.Echo Err.Number & " -- " &  Err.Description
    Err.Clear

    ' 32bit
    officeBit = "32bit"
    officeKey = ConvertToKey(WshShell.RegRead("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Office\14.0\Registration\{90140000-003D-0000-0000-0000000FF1CE}\DigitalProductId"), "Office2010")
    If Err <> 0 Then
        ' Wscript.Echo Err.Number & " -- " &  Err.Description
        Err.Clear
        officeKey = ""
        officeBit = ""
    End If
End If

' On Error GoTo 0
' Set fso = CreateObject ("Scripting.FileSystemObject")
' Set stdout = fso.GetStandardStream (1)
' Set stderr = fso.GetStandardStream (2)

keys = "Windows:           " & winKey & " / " & "Office 2010 " & officeBit & ": " & officeKey

' http://stackoverflow.com/questions/128463/use-clipboard-from-vbscript
Set WshShell = WScript.CreateObject("WScript.Shell")
cmd = "cmd.exe /c echo " & keys & " | clip"
' stdout.WriteLine cmd
WshShell.Run cmd, 0, TRUE

' stdout.WriteLine "Windows:           " & winKey
' stdout.WriteLine "Office 2010 " & officeBit & ": " & officeKey

msg = "Windows: " & vbNewLine & winKey & vbNewLine & vbNewLine & "Office 2010 " & officeBit & ": " & vbNewLine & officeKey & vbNewLine & vbNewLine & "Copied to clipboard"
' MsgBox msg, vbOKOnly, "MS Product Keys"
Wscript.Echo "MS Product Keys" & vbNewLine & vbNewLine & msg



Function ConvertToKey(Key, Product)
    if (Product = "Office2010") then
        KeyOffset = 808
    else
        KeyOffset = 52
    end if
    i = 28
    Chars = "BCDFGHJKMPQRTVWXY2346789"
    Do
        Cur = 0
        x = 14
        Do
            Cur = Cur * 256
            Cur = Key(x + KeyOffset) + Cur
            Key(x + KeyOffset) = (Cur \ 24) And 255
            Cur = Cur Mod 24
            x = x -1
        Loop While x >= 0
        i = i -1
        KeyOutput = Mid(Chars, Cur + 1, 1) & KeyOutput
        If (((29 - i) Mod 6) = 0) And (i <> -1) Then
            i = i -1
            KeyOutput = "-" & KeyOutput
        End If
    Loop While i >= 0
    ConvertToKey = KeyOutput
End Function