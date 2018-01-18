Imports System.Runtime.CompilerServices

<HideModuleName()>
Public Module ListArrayExtensions

  ''' <summary>
  ''' Splits a IEnumerable-list into lists of maximum <paramref name="ChunkSize"/> Items.
  ''' </summary>
  <Extension()>
  Public Iterator Function Chunk(Of T)(Source As IEnumerable(Of T), ChunkSize As Integer) As IEnumerable(Of IEnumerable(Of T))
    While Source.Any()
      Yield Source.Take(ChunkSize)
      Source = Source.Skip(ChunkSize)
    End While
  End Function

End Module
