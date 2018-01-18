Imports System.Runtime.CompilerServices

<HideModuleName()>
Public Module OtherExtensions

  ''' <summary>
  ''' Converts ACE (ASCII-compatible encoding) URL to IDN (internationalized domain name) URL. Example: xn--dmin-moa0i.example → dömäin.example
  ''' </summary>
  <Extension()>
  Public Function IdnUrlToUnicodeUrl(Url As String) As String
    Try
      Dim idn As New System.Globalization.IdnMapping
      Return idn.GetUnicode(Url)
    Catch ex As Exception
      Return Url
    End Try
  End Function

  ''' <summary>
  ''' Converts IDN (internationalized domain name) URL to ACE (ASCII-compatible encoding) URL. Example: dömäin.example → xn--dmin-moa0i.example
  ''' </summary>
  <Extension()>
  Public Function IdnUnicodeUrlToAsciiUrl(Url As String) As String
    Try
      Dim idn As New System.Globalization.IdnMapping
      Return idn.GetAscii(Url)
    Catch ex As Exception
      Return Url
    End Try
  End Function

End Module
