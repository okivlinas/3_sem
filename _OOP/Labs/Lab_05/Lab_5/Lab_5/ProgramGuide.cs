using Lab_04;
using LAB_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public partial class ProgramGuide
    {

        private TV_program[] _Programs;
        public TV_program[] Programs
        {
            get => _Programs;
            set => _Programs = value;
        }

        private uint CCount = 0;
        public uint MaxCount { get; } = 5;
       
 
        public ProgramGuide() =>
            Programs = new TV_program[MaxCount];


        public override string ToString()
        {
            Console.WriteLine("ПРОГРАММА ПЕРЕДАЧ СОСТОИТ ИЗ: ");
            int i = 0;
            foreach (var item in Programs)
            {
                Console.WriteLine();
                item.ToString();
                i++;

                if (i == CCount)
                {
                    break;
                }
            }
            return "";
        }
    }

    public partial class ProgramGuide
    {
        public void AddProgram(TV_program Program)
        {
            if (this.CCount != this.MaxCount )
            {
                Programs[this.CCount++] = Program;
            }
        }

        public void AddsProgram(params TV_program[] Programs)
        {
            for (var i = 0; i < Programs.Length; i++)
            {
                this.AddProgram(Programs[i]);
            }
        }
       
    }
}