Imports System

Module Program
    Sub Main()
        Console.WriteLine("Qual'� il tuo Sport preferito? ")
        Dim sport As String = Console.ReadLine()
        Console.WriteLine("Qual'� il tuo Giocatore preferito? ")
        Dim giocatore As String = Console.ReadLine()
        Console.WriteLine("Qual'� la tua Squadra preferita? ")
        Dim squadra As String = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Il mio Sport preferito � " & sport)
        Console.WriteLine("Il mio Giocatore preferito � " & giocatore)
        Console.WriteLine("La mia Squadra preferita � " & squadra)
        Console.ReadLine()
    End Sub
End Module
