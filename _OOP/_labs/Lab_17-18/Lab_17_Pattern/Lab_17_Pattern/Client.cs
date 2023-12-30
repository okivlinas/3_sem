﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    public interface GetClone
    {
        public GetClone clone();
    }
    public class Client:GetClone
    {
        public string nameOfClient;

        public CarFlight CreateNewFlight(string name, int weight, int experience)
        {
            CarFlight newFlight = new CarFlight(name,weight,experience);
            return newFlight;
        }

        public Client(string na)
        {
            this.nameOfClient = na;
        }
        public GetClone clone()
        {
            return new Client(this.nameOfClient);
        }
    }
}
