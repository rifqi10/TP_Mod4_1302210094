﻿public class KodePos_1302210094
{
    public string getKodePos_1302210094(string kelurahan)
    {
        switch (kelurahan)
        {
            case "Batununggal":
                return "40266";
            case "Kujangsari":
            case "Cijaura":
                return "40287";
            case "Mengger":
                return "40267";
            case "Wates":
                return "40256";
            case "Jatisari":
            case "Margasari":
            case "Sekejati":
                return "40286";
            case "Kebonwaru":
                return "40272";
            case "Maleer":
                return "40274";
            case "Samoja":
                return "40273";
            default:
                return "Kode pos tidak ditemukan";
        }
    }
} 

public class Program
{
    static void Main()
    {
        KodePos_1302210094 kodePos = new KodePos_1302210094();

        Console.WriteLine("| Kelurahan\t\t| Kode Pos |");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"| Batununggal\t\t| {kodePos.getKodePos_1302210094("Batununggal")}\t|");
        Console.WriteLine($"| Kujangsari\t\t| {kodePos.getKodePos_1302210094("Kujangsari")}\t|");
        Console.WriteLine($"| Mengger\t\t| {kodePos.getKodePos_1302210094("Mengger")}\t|");
        Console.WriteLine($"| Wates\t\t\t| {kodePos.getKodePos_1302210094("Wates")}\t|");
        Console.WriteLine($"| Cijaura\t\t| {kodePos.getKodePos_1302210094("Cijaura")}\t|");
        Console.WriteLine($"| Jatisari\t\t| {kodePos.getKodePos_1302210094("Jatisari")}\t|");
        Console.WriteLine($"| Margasari\t\t| {kodePos.getKodePos_1302210094("Margasari")}\t|");
        Console.WriteLine($"| Sekejati\t\t| {kodePos.getKodePos_1302210094("Sekejati")}\t|");
        Console.WriteLine($"| Kebonwaru\t\t| {kodePos.getKodePos_1302210094("Kebonwaru")}\t|");
        Console.WriteLine($"| Maleer\t\t| {kodePos.getKodePos_1302210094("Maleer")}\t|");
        Console.WriteLine($"| Samoja\t\t| {kodePos.getKodePos_1302210094("Samoja")}\t|");

        Console.WriteLine("--------------------------------------");
    }
}
