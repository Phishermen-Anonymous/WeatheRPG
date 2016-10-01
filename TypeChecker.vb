Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim AttackType As Int16
        Dim DefendType As Int16

        '0=lightning
        '1=Ice
        '2=Water
        '3=Wind 
        '4=sun
        '5=ghost
        '6=normal
        '7=rainbow
        AttackType = 0
        DefendType = 0
        Call TypeCheck(AttackType, DefendType)

    End Sub

    Function TypeCheck(AttackType As Integer, DefendType As Int16)
        Dim TypeDifference As Int16
        TypeDifference = DefendType - AttackType
        Dim DamageBonus As Int16
        Const Supereffective As Integer = 2
        Const Uneffective As Integer = 0.5
        Const Regularlyeffective As Integer = 1
        ' a type difference of 1 or 2 means the attack is super effective
        'a type diffence of -1 or -2 means it is uneffective
        'a type difference of anything else is regularly effective
        'type 7 is super effective against and from everything
        If AttackType = 7 Or DefendType = 7 Then
            DamageBonus = Supereffective
        Else

            Select Case TypeDifference
                Case -6 Or -5 Or 1 Or 2
                    DamageBonus = Supereffective
                Case -1 Or -2 Or 5 Or 6
                    DamageBonus = Uneffective
                Case Else
                    DamageBonus = Regularlyeffective
            End Select
        End If

        Return (DamageBonus)


    End Function
End Class
