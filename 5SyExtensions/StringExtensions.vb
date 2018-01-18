Imports System.Runtime.CompilerServices

<HideModuleName()>
Public Module StringExtensions

  ''' <summary>
  ''' Replace function with optional replacing with ignore case. 
  ''' </summary>
  <Extension()>
  Public Function Replace(ByVal Expression As String, ByVal Find As String, ByVal Replacement As String, Optional ByVal CaseSensitive As Boolean = False) As String
    Return Microsoft.VisualBasic.Strings.Replace(Expression, Find, Replacement, Compare:=If(CaseSensitive, CompareMethod.Binary, CompareMethod.Text))
  End Function

  ''' <summary>
  ''' Converts a String to a ByteArray.
  ''' </summary>
  <Extension()>
  Public Function ToByteArray(ByRef InputString As String, Optional Encoding As Text.Encoding = Nothing) As Byte()
    If Encoding Is Nothing Then Encoding = System.Text.Encoding.Default
    Return Encoding.GetBytes(InputString)
  End Function

  ''' <summary>
  ''' Converts a String in ProperCase (hello world => Hello World).
  ''' </summary>
  <Extension()>
  Public Function ToProperCase(strInput As String) As String
    Try
      Return Strings.StrConv(strInput, VbStrConv.ProperCase)
    Catch ex As Exception
      Return strInput
    End Try
  End Function

  ''' <summary>
  ''' Cuts a String to a maximum length with keeping whole words - from left.
  ''' </summary>
  <Extension()>
  Public Function LeftPreserveWords(ByVal InputText As String, ByVal MaximumCharCount As Integer, Optional ReductionSign As String = "") As String
    If InputText.Length > MaximumCharCount Then
      InputText &= " "
      InputText = InputText.Substring(0, MaximumCharCount)
      If InputText.Contains(" ") Then InputText = InputText.Substring(0, InStrRev(InputText, " ")).Trim
      InputText &= ReductionSign
    End If
    Return InputText
  End Function

  ''' <summary>
  ''' Cuts a String to a maximum length with keeping whole words - from right.
  ''' </summary>
  <Extension()>
  Public Function RightPreserveWords(ByVal InputText As String, ByVal MaximumCharCount As Integer) As String
    InputText = " " & InputText
    InputText = Right(InputText, MaximumCharCount)
    If InputText.Contains(" ") Then InputText = Right(InputText, InputText.Length - InStr(InputText, " ")).Trim
    Return InputText
  End Function


End Module
