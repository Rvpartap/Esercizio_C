Imports System

Module Program
    Sub Main()
        Console.WriteLine("Qual'è il tuo Sport preferito? ")
        Dim sport As String = Console.ReadLine()
        Console.WriteLine("Qual'è il tuo Giocatore preferito? ")
        Dim giocatore As String = Console.ReadLine()
        Console.WriteLine("Qual'è la tua Squadra preferita? ")
        Dim squadra As String = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Il mio Sport preferito è " & sport)
        Console.WriteLine("Il mio Giocatore preferito è " & giocatore)
        Console.WriteLine("La mia Squadra preferita è " & squadra)
        Console.ReadLine()
    End Sub
End Module
