﻿using System.Text;

using(FileStream fStream = File.Open("MyMessage.dat", FileMode.Create))
{
    string? msg = "Hello";
    byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
    fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
    fStream.Position = 0;

    Console.Write("Your message as an array of bytes: ");
    byte[] bytesFromFile = new byte[msgAsByteArray.Length];
    for (int i = 0; i < msgAsByteArray.Length; i++)
    {
    bytesFromFile[i] = (byte)fStream.ReadByte();
    Console.Write(bytesFromFile[i]);
    }

    Console.Write("\nDecoded Message: ");
    Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
}
File.Delete("MyMessage.dat");
