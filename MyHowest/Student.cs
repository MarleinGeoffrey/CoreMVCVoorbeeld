using System;
using System.Collections.Generic;
using System.Text;

namespace MyHowest
{

    public enum Graad
    {
        Voldoening,
        Onderscheiding,
    }
    public class Student
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Graad AfstudeerdGraad { get; set; }

        public override string ToString()
        {
            return $"De student met naam {Naam} is met {AfstudeerdGraad} afgestudeerd.";
        }

    }
}
