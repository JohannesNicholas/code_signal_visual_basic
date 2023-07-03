' https://app.codesignal.com/challenge/qtsq77DyTtDrNs2dX


Function solution(roadRegister As List(Of List(Of Boolean))) As List(Of List(Of Boolean)) 
    Dim out As New List(Of List(Of Boolean)) 
    
    Dim size = roadRegister.Count


    ' Fill out
    For i As Integer = 0 To size - 1
        Dim row As New List(Of Boolean)
        For j As Integer = 0 To size - 1

            ' Take the value from the previous row and column, loop around if necessary
            Dim value = roadRegister((i - 1 + size) Mod size)((j - 1 + size) Mod size)

            row.Add(value)
        Next
        out.Add(row)
    Next

    Return out
End Function
