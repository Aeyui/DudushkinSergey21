Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer, Pr As Long = 1

        Console.WriteLine("������, � ���������� �����! ������ ���-������ ��������?")

        Do
            num = Console.ReadLine()
            Pr = Pr * num
        Loop Until num = 1

        Console.WriteLine("����������� �����={0}", Pr)
    End Sub
End Module
