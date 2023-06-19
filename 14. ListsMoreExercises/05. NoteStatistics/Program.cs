using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._NoteStatistics
{
    class Program
    {
        static void Main()
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<string> notes = FindNote(input);
            List<string> naturalsNotes = new List<string>();
            List<string> sharpsNotes = new List<string>();
            double sumNaturals = 0;
            double sumSharps = 0;


            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Contains("#"))
                {
                    sharpsNotes.Add(notes[i]);
                    sumSharps += input[i];
                }
                else
                {
                    naturalsNotes.Add(notes[i]);
                    sumNaturals += input[i];
                }
            }

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine("Naturals: " + string.Join(", ", naturalsNotes));
            Console.WriteLine("Sharps: " + string.Join(", ", sharpsNotes));
            Console.WriteLine($"Naturals sum: {sumNaturals}");
            Console.WriteLine($"Sharps sum: {sumSharps}");


        }

        static List<string> FindNote(List<double> input)
        {
            List<string> notes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            List<double> frequencies = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63,
                349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };
            List<string> output = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                for (int a = 0; a < frequencies.Count; a++)
                {
                    if (input[i] == frequencies[a])
                    {
                        output.Add(notes[a]);
                        break;
                    }
                }
            }

            return output;
        }
    }

}