using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Lab1
{
    public class Vector
    {
        public int Dimension { get; set; }
        public decimal[] Cords { get; set; }
        [JsonConstructor] 
        public Vector(int Dimension, decimal[] Cords)
        {
                     this.Dimension= Dimension ;
                     this.Cords = Cords;
        }
        public Vector MinusVector(Vector Vecto) //віднімання векторів
        {
            for (int i = 0; i < Dimension; i++)
                Cords[i] = Vecto.Cords[i] - Cords[i];
            return this;
        }
        public Vector multConst(decimal Nconst) //множення вектора на скаляр
        {
            decimal[] Cordinates = new decimal[Dimension];
            for (int i = 0; i < Dimension; i++)
                Cordinates[i] = Cords[i] * Nconst;
            return new Vector(Dimension, Cordinates);
        }
        public Vector incCords() //збільшення кіькості координат
        {
            Dimension++;
            decimal[] Cordinates = new decimal[Dimension];
            for (int i = 0; i < Dimension - 1; i++)
                Cordinates[i] = Cords[i];
            Cordinates[Dimension - 1] = 0;
            return new Vector(Dimension, Cordinates);
        }
        public Vector decCords() //зменшення кількості координат
        {
            Dimension--;
            decimal[] Cordinates = new decimal[Dimension];
            for (int i = 0; i < Dimension; i++)
                Cordinates[i] = Cords[i];
            return new Vector(Dimension, Cordinates);
        }
        public decimal MultiVector(Vector Vector1) //множення векторів
        {
            decimal Multirez = 0;
            for (int i = 0; i < Cords.Length; i++)
            {
                Multirez += Vector1.Cords[i] * Cords[i];
            }
            return Multirez;
        }
        public decimal lengthVector()//довжина вектора
        {
            decimal rez = 0;
            for (int i = 0; i < Cords.Length; i++)
            {
                rez += Cords[i] * Cords[i];
            }
            return (decimal)Math.Sqrt((double)rez);
        }

        public void SaveVector()//зберегти джсон
        {
            string fileName = "Vector.json";
            string jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(fileName, jsonString);
        }
        
        public Vector LoadVector()//завантажити джсон
        {
            string fileName = "Vector.json";
            string jsonString = File.ReadAllText(fileName);
            Vector Vector = JsonSerializer.Deserialize<Vector>(jsonString);
            return Vector;
         }

    }
}