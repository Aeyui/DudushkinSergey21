Imports System

Module 
    Sub Main(args As String())
        Console.WriteLine("������� ������")

        Dim str As String
        Dim spaces, signs, vowels, consonants As Integer

        str = Console.ReadLine()

        For i As Integer = 0 To str.Length - 1
            Select Case Asc(str.Chars(i))
                Case 32
                    spaces += 1
                Case 33 To 48  To 64  To 96  To 126
                    signs += 1
                Case 65
                    vowels += 1
                Case 66 To 68  To 72  To 78  To 84  To 88   To 100  To 104  To 110  To 116  To 120 
                    consonants += 1
            End Select
        Next

        Console.WriteLine("� ������ {0} ��������", spaces)
        Console.WriteLine("� ������ {0} ������ ����������", signs)
        Console.WriteLine("� ������ {0} �������", vowels)
        Console.WriteLine("� ������ {0} ���������", consonants)

    End Sub
End Module
