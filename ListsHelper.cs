using System;
using System.Collections.Generic;
using System.IO;


namespace Analitik
{
    internal class ListsHelper
    {
        readonly List<string> common;
        readonly List<Obj> objs = new List<Obj>();
        readonly string path;

        public ListsHelper(List<string> ListFileNames, string p)
        {

            this.common = ListFileNames;
            this.path = p;
            GetAllObjects();
        }


        public List<Obj> GetAllObjects()
        {
            objs.Clear();
            foreach (string file in common)
            {
                //считываем содержание файла по строкам
                string[] lines = File.ReadAllLines(path + "/" + file);

                int i = 0; // индекс объекта одного файла (изображения)
                //построчно
                foreach (string l in lines)
                {
                    string[] temp = l.Split(' ');
                    Obj obj = new Obj
                    {
                        ClassNumber = Convert.ToInt32(temp[0]),
                        X = double.Parse(temp[1]),
                        Y = double.Parse(temp[2]),
                        W = double.Parse(temp[3]),
                        H = double.Parse(temp[4]),
                        Condident = double.Parse(temp[5]),
                        FromFile = file,
                        NFile = i
                    };

                    obj.S();
                    obj.ID();
                    i++;
                    objs.Add(obj);
                }



            }
            return objs;
        }

        public List<Obj> ByClass(int n)
        {

            List<Obj> list = new List<Obj>();


            for (int i = 0; i < objs.Count; i++)
            {
                if (objs[i].ClassNumber == n)
                {
                    list.Add(objs[i]);
                }
            }
            return list;
        }
    }
}
