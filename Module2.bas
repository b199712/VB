Attribute VB_Name = "Module2"
Sub fw()

    Dim sheetName As Worksheet
    Dim fw As String
    Dim fwRow, fwCol, count As Integer
    
    fwRow = 7
    fwCol = 3
    count = 1
    
    For Each sheetName In Worksheets
        With sheetName
            If .Name = "Report" Then
                fw = "[" & .Cells(6, 3) & "]"
                'MsgBox fw
            End If
            If .Cells(fwRow, fwCol) = "Version" Then
                Do While .Cells(fwRow + count, fwCol) <> ""
                    If .Cells(fwRow + count, fwCol) <> "old" Then
                        .Cells(fwRow + count, fwCol) = fw
                    End If
                    count = count + 1
                Loop
                'MsgBox count
            End If
            count = 1
        End With
    Next
    MsgBox "end"
End Sub
