Attribute VB_Name = "Module1"
Sub dcc()
Attribute dcc.VB_ProcData.VB_Invoke_Func = " \n14"

   'Dim sheetCount As Integer
    Dim sheetName As Worksheet
    Dim getValue As String
    Dim planRow, rowNum, startRow, endRow, nextRow As Integer
       
    
    'sheetCount = ActiveWorkbook.Worksheets.count
    
    For Each sheetName In Worksheets
        With sheetName
            planRow = 7
            startRow = 0
            rowNum = planRow + 1
            endRow = 0
            nextRow = 0
            
            If .Cells(planRow, 5) = "Plan" And .Name <> "VeriWave" And .Name <> "DCC" Then
                While .Cells(rowNum, 5) <> ""
                    If .Cells(rowNum, 5) = "P00" Then
                        If startRow > 0 Then
                            nextRow = rowNum
                            endRow = rowNum - 1
                            .Cells(startRow, 1) = JudgeResult(sheetName, startRow, endRow)
                            startRow = nextRow
                        Else
                            startRow = rowNum
                        End If
                    End If
                    rowNum = rowNum + 1
                Wend
                .Cells(startRow, 1) = JudgeResult(sheetName, startRow, rowNum - 1)
            End If
        End With
    Next

    MsgBox "END"

End Sub

Public Function JudgeResult(ByVal passSheet As Worksheet, ByVal startNum As Integer, ByVal endNum As Integer) As String

    Dim result As String
    Dim count As Integer
    Dim FAIL, PASS, NA, NT As Boolean
    
    FAIL = False
    PASS = False
    NA = False
    NT = False
    
    For count = startNum + 1 To endNum
        Select Case (passSheet.Cells(count, 1))
            Case "Fail"
                FAIL = True
            Case "Pass"
                PASS = True
            Case "Fix"
                PASS = True
            Case "NT"
                NT = True
            Case "NA"
                NA = True
        End Select
    Next count
    
    If FAIL = True Then
        result = "Fail"
    ElseIf PASS = True Then
        result = "Pass"
    ElseIf NT = True Then
        result = "NT"
    ElseIf NA = True Then
        result = "NA"
    End If
    
    JudgeResult = result
End Function
