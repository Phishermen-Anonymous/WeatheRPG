Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim line As Int16
        line = 5



    End Sub

    Function StatSeperation(Line As Int16)
        Dim LineOfStats As String
        Dim StatsArray(6) As String

        'Dim SpellID As Int16
        'Dim DMG As Double
        'Dim PRC As Double
        'Dim Type As Int16
        'Dim MGC As Int16
        'Dim SPD As Int16
        'Dim Name As String
        Dim count As Int16
        Dim count2 As Int16
        FileOpen(1, Moves.txt, OpenMode.Output)
        For c = 1 To Line
            LineOfStats = LineInput(1)
        Next
        FileClose(1)
        count = 0
        count = 0
        Do
            count = count + 1
            If Strings.Mid(LineOfStats, count, 1) = "," Then
                StatsArray(count2) = Strings.Left(LineOfStats, count - 1)
                LineOfStats = Strings.Right(LineOfStats, Strings.Len(LineOfStats - count))
                count2 = count2 + 1
                count = 0
            End If
        Loop Until count = Strings.Len(LineOfStats)
        'to get the last shit out
        StatsArray(6) = LineOfStats


    End Function


End Class
