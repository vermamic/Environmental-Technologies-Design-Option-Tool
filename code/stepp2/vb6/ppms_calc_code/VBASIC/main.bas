Attribute VB_Name = "MainProgram"
Option Explicit
'
' GLOBAL CONSTANTS.
'
Global Global_fpath_dir_StartIn As String
Global MAIN_APP_PATH As String
'
'splash_mode: 0 = Continue/Exit window
'             1 = I Agree/I agree, never show again/Exit window
'
Global splash_mode As Integer
'
'splash_button_pressed:
'1 = Continue or I Agree
'2 = I agree, never show again
'3 = Exit
'
Global splash_button_pressed As Integer
'
'
Global fn_Master_MDB As String
Global fn_Block5_MDB As String
'
'
'
Const MainProgram_declarations_end = 0


Function get_program_version_with_build_info_VB4() As String
Dim ver As String
  ver = ver & Trim$(App.Major) & "."
  ver = ver & Trim$(App.Minor) & "."
  ver = ver & Trim$(App.Revision)
  get_program_version_with_build_info_VB4 = ver
End Function


Function frmSplash_Run() As Boolean
Dim tpath$
Dim tstr$
Dim must_read_disclaimer As Integer
Dim msg As String
  '
  ' SHOW THE CONTINUE/EXIT FRONT WINDOW.
  '
  splash_mode = 0
  splash_button_pressed = 0
  On Error GoTo err_frmSplash_Run
  frmSplash.Show 1
  Select Case splash_button_pressed
    Case 1:         'Hit Continue
      'DO NOTHING.
    Case 3:         'Hit Exit
      frmSplash_Run = False
      Exit Function
  End Select
  '
  ' IS THE DISCLAIMER WINDOW STILL ACTIVE?
  '
  must_read_disclaimer = True
  ''tstr$ = INI_GetSetting0(fn_INI_path, "disclaimer", "has_read_disclaimer")
  tstr$ = INI_GetSetting0(fn_OldFileList, "disclaimer", "has_read_disclaimer")
  'tstr$ = ini_getsetting("has_seen_disclaimer")
  If (tstr$ = "1") Then
    must_read_disclaimer = False
  End If
  If (must_read_disclaimer) Then
    '
    ' SHOW THE DISCLAIMER WINDOW.
    '
    splash_mode = 1
    splash_button_pressed = 0
    frmSplash.Show 1
    Select Case splash_button_pressed
      Case 1:         'Hit I Agree
        'DO NOTHING.
      Case 2:         'Hit I agree, never show again
        ''Call ini_putsetting0(fn_INI_path, "disclaimer", "has_read_disclaimer", "1")
        'Call ini_putsetting("has_seen_disclaimer", "1")
        Call ini_putsetting0(fn_OldFileList, "disclaimer", "has_read_disclaimer", "1")
      Case 3:         'Hit Exit
        frmSplash_Run = False
        Exit Function
    End Select
  End If
  frmSplash_Run = True
  Exit Function
exit_err_frmSplash_Run:
  Call Show_Error("Halting due to an error.")
  frmSplash_Run = False
  Exit Function
err_frmSplash_Run:
  msg = "Detected an error.  " & _
      "Err.Number = " & Trim$(Str$(Err.Number)) & "; " & _
      "Err.Source = `" & Err.Source & "`.  Now halting program."
  Call Show_Message(msg)
  Resume exit_err_frmSplash_Run
End Function


Sub ChangeDir_Exes()
  ChDrive MAIN_APP_PATH
  ChDir MAIN_APP_PATH & "\EXES"
End Sub
Sub ChangeDir_Main()
  ChDrive MAIN_APP_PATH
  ChDir MAIN_APP_PATH
End Sub


Sub Main()
Dim fn_misc1 As String
Dim LicFileLocation As Integer
Dim fpath_INI As String
Dim msg As String
  '
  ' SET UP MAIN APP PATH VARIABLE.
  '
'  If (File_IsExists(Global_fpath_dir_StartIn & "\debug_in_vb6.txt")) Then
'    'FOR DEBUGGING IN THE VB5 ENVIRONMENT.
''>>>>>>>>>>>>>>>>>>>> *TODO* UPDATE THIS PATHNAME <<<<<<<<<<<<<<<<<<<<<<<<<
'    MAIN_APP_PATH = "X:\pdt10\code\ppms\vb6"
'    ChDrive MAIN_APP_PATH
'    ChDir MAIN_APP_PATH
'  Else
    'DO NOTHING.
    MAIN_APP_PATH = Global_fpath_dir_StartIn
'  End If
  '
  ' VERIFY THAT PATHS ARE PROPERLY SET UP.
  '
  fn_misc1 = MAIN_APP_PATH & "\dbase\misc1.dat"
  If (File_IsExists(fn_misc1)) Then
    'DO NOTHING; THIS IS OKAY.
  Else
    Call Show_Error("The file `" & fn_misc1 & "` is missing.  " & _
        "Therefore the software must have been improperly installed.  " & _
        "Recommendation: Check the `Start In` path specified in the " & _
        "program icon, or else perform a re-install of the software.")
    GoTo exit_err_main
  End If
  '
  ' READ IN THE LICENSE FILE DATA.
  '
  If (TURN_LICENSING_OFF = True) Then
    lfd.Z_USERNAME = "Unspecified User"
    lfd.Z_USERCOMPANY = "Unspecified Company"
    lfd.Z_SERIALNUMBER = "Unspecified Serial Number"
    lfd.Z_RELEASETYPE = "STANDARD"
    fpath_INI = GetWindowsDir()
  Else
    If (False = LicFileData_Read(Global_fpath_dir_CPAS)) Then
      GoTo exit_err_main
    End If
    fpath_INI = Global_fpath_dir_CPAS & "\DBASE"
  End If
  On Error GoTo err_main
  '
  ' OPEN WORKSPACE TO HOLD DATABASES, STORE DATABASE NAMES.
  '
  Set Ws1 = Workspaces(0)
  fpath_dir_DBASE = MAIN_APP_PATH & "\dbase"
    'TODOTODO: Add checks to verify that each
    'database is available for exclusive use
    'by this program.
  If (File_IsExists(MAIN_APP_PATH & "\force_dbase_path.txt")) Then
    '
    '  If this file exists, then the dbase path is temporarily
    '  reset to the following path for testing purposes:
    '
    '      c:\work\990519_master_mdb_with_dippr801_data
    '
    '  Eric J. Oman
    '  3:22 PM 5/19/99
    '
    fpath_dir_DBASE = "c:\work\990519_master_mdb_with_dippr801_data"
  End If
  fn_Master_MDB = fpath_dir_DBASE & "\master.mdb"
  fn_Block5_MDB = fpath_dir_DBASE & "\block5.mdb"
  If (File_IsExists(fn_Master_MDB) = False) Then
    Call Show_Error("The file `" & fn_Master_MDB & "` is missing.  " & _
        "Therefore the software must have been improperly installed.  " & _
        "Recommendation: Check the `Start In` path specified in the " & _
        "program icon, or else perform a re-install of the software.")
    GoTo exit_err_main
  End If
  If (File_IsExists(fn_Block5_MDB) = False) Then
    Call Show_Error("The file `" & fn_Block5_MDB & "` is missing.  " & _
        "Therefore the software must have been improperly installed.  " & _
        "Recommendation: Check the `Start In` path specified in the " & _
        "program icon, or else perform a re-install of the software.")
    GoTo exit_err_main
  End If
  '
  ' SET UP INI FILENAME FOR DISCLAIMER CHECK, AND
  ' SHOW SPLASH/DISCLAIMER.
  '
  fn_OldFileList = fpath_INI & "\" & fn_INI_name
  Call PrefEnvironment_SetDefaults
  Call PrefEnvironment_LoadFromINI
  If (frmSplash_Run() = False) Then
    Exit Sub
  End If
  '
  ' INITIALIZE THE UNIT STRUCTURES.
  '
  Call unitsys_initialize
  '
  ' LAUNCH THE MAIN WINDOW.
  '
  If (False = frmMain.frmMain_Go()) Then
    ' DO NOTHING.
  End If
  Exit Sub
exit_err_main:
  Call Show_Error("Halting due to an error.")
  Exit Sub
err_main:
  msg = "Detected an error in main().  " & _
      "Err.Number = " & Trim$(Str$(Err.Number)) & "; " & _
      "Err.Source = `" & Err.Source & "`.  Now halting program."
  Call Show_Message(msg)
  Resume exit_err_main
End Sub


Sub debug_output(s As String)
Dim F As Integer
  F = FreeFile
  Open "c:\bug.txt" For Append As #F
  Write #F, "PPMS", Date$ & " " & Time$ & " -- " & s
  Close #F
End Sub


'Returns:
'TRUE = The program is internal to MTU, thus show the hidden menu
'FALSE = The program is distributed, hide the menu
Function check_internal_to_mtu() As Integer
Dim file_1_not_found As Integer
Dim file_2_not_found As Integer
Dim is_internal_to_mtu As Integer
  On Error GoTo err_check_internal_to_mtu1
  file_1_not_found = True
  If (Dir("c:\a_aaaaaa\internal.txt") <> "") Then file_1_not_found = False
res_err_check_internal_to_mtu1:
  On Error GoTo err_check_internal_to_mtu1
  file_2_not_found = True
  'If (Dir("g:\a_aaaaaa\internal.txt") <> "") Then file_2_not_found = False
  'NOTE: Scanning the G: drive on some computers causes a
  '"hanging" problem so this scan was removed.  EJO, 1/6/98.
res_err_check_internal_to_mtu2:
  is_internal_to_mtu = True
  If (file_1_not_found) And (file_2_not_found) Then
    is_internal_to_mtu = False
  End If
  check_internal_to_mtu = is_internal_to_mtu
  Exit Function
err_check_internal_to_mtu1:
  file_1_not_found = True
  Resume res_err_check_internal_to_mtu1
err_check_internal_to_mtu2:
  file_2_not_found = True
  Resume res_err_check_internal_to_mtu2
End Function

