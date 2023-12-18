using System.IO;


namespace Analitik
{
    internal class Writer
    {
        readonly StreamWriter res;
        private string imgpath;
        private bool files;
        public bool Files
        {
            get
            {
                return files;    // возвращаем значение свойства
            }
            set
            {
                files = value;   // устанавливаем новое значение свойства
            }
        }

        public Writer(string path, string imgp)
        {
            this.res = new StreamWriter(path);
            this.imgpath = imgp;
        }
        public void Cl()
        {
            this.res.Close();
        }
        ~Writer()
        {
            this.res.Close();
        }
        void ClassMean(int n)
        {
            switch (n)
            {
                case 0:
                    res.WriteLine("Класс: " + n + " ColSwast  Свастика (ЦВ)");
                    break;
                case 1:
                    res.WriteLine("Класс: " + n + " GraySwast  Свастика (ЧБ)");
                    break;
                case 2:
                    res.WriteLine("Класс: " + n + " Igil  Игил ");
                    break;
                case 3:
                    res.WriteLine("Класс: " + n + " RSector  Правый сектор ");

                    break;
                case 4:
                    res.WriteLine("Класс: " + n + " Taliban   Талибан ");
                    break;
                case 5:
                    res.WriteLine("Класс: " + n + " Ichkeria  Ичкерия  ");
                    break;
            }



        }
        public void ResMultyFile (ResClassStruct cl){
            res.WriteLine("");
            res.WriteLine("Всего найдено объектов: " + cl.count);
            if (cl.count > 0)
            {
                res.WriteLine("Максимальный конфидент: " + cl.max_c);
                res.WriteLine("Площадь покрытия: " + cl.comm_S);
            }
        }

        public void ReSClass(ResClassStruct cl)
        {
            res.WriteLine("");
            res.WriteLine("_________________________________________________");
            ClassMean(cl.class_num);
            res.WriteLine("Количество объектов: " + cl.count);
            res.WriteLine("Максимальный конфидент: " + cl.max_c);
            res.WriteLine("Средний конфиденс: " + cl.ave_c);
            res.WriteLine("Максимальная площадь: " + cl.max_s);
            res.WriteLine("Средняя площадь: " + cl.ave_s);
            res.WriteLine("Площадь покрытия: " + cl.comm_S);
            res.WriteLine("Центр фокусировки: " + cl.xf + " " + cl.yf);
            res.WriteLine("Дисперсия абсцисс : " + cl.xd);
            res.WriteLine("Дисперсия ординат: " + cl.yd);
            res.WriteLine("************************************************");
            res.WriteLine("Объект с max точностью:");
            if (files)
            {
                res.WriteLine("Расположение изображения объекта: ");
                res.WriteLine(GetImgName(cl.obj_c.FromFile));
            }


            res.WriteLine("Точность : " + cl.obj_c.Condident);
            res.WriteLine("Площадь: " + cl.obj_c.S());
            res.WriteLine("Центр фокуса: " + cl.obj_c.X + " " + cl.obj_c.Y);
            res.WriteLine("************************************************");
            res.WriteLine("Объект с max площадью:");

            if (files)
            {
                res.WriteLine("Расположение изображения объекта: ");
                res.WriteLine(GetImgName(cl.obj_s.FromFile));
            }

            res.WriteLine("Точность : " + cl.obj_s.Condident);

            res.WriteLine("Площадь: " + cl.obj_s.S());
            res.WriteLine("Центр фокуса: " + cl.obj_s.X + " " + cl.obj_s.Y);
            res.Flush();
        }
        public string GetImgName(string sourse)
        {

            int index = sourse.IndexOf(".");
            if (index >= 0)
                sourse = sourse.Substring(0, index);
            sourse += ".jpg";
            string res = imgpath + "\\images\\" + sourse;
            return res;
        }

        public void Write(string str)
        {
            res.WriteLine(str);
            res.Flush();
        }


    }
}

