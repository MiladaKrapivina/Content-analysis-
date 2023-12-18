using System.Collections.Generic;
using System.Linq;

namespace Analitik
{
    // передаютcя заранее отсортированные листы
    internal class ClassAnalitik
    {
        readonly List<Obj> objs;

        public ResClassStruct GetRes()
        {
            ResClassStruct res = new ResClassStruct
            {
                class_num = ClassNum(),
                count = CountElements(),
                max_c = MaxC(),
                max_s = MaxS(),
                ave_c = AveC(),
                ave_s= AveS(),
                comm_S = SCoverage(),
                xf = Xf(),
                yf = Yf(),
                xd = Dx(),
                yd = Dy(),
                obj_c = ConfObj(),
                obj_s = SObj()

            };

            return res;
        }


        private int class_num; // номер класса

        // колличество объекта класса
        private int count = 0;
        //Максимальная точность
        private double max_c;

        private double ave_s = 0;
        //Максимальная площадь
        private double max_s;
        //средняя точность
        private double ave_c = 0;
        // Площадь заполнения
        private double comm_S = 0;
        //Центр фокуса Xf Yf
        private double xf = 0;
        private double yf = 0;
        //Дисперсия абцисс
        private double xd = 0;
        private double yd = 0;
        //Объект с max точностью
        private Obj obj_c;
        //Объект с max площадью
        private Obj obj_s;


        public int ClassNum()
        {
            this.class_num = objs.FirstOrDefault().ClassNumber;
            return class_num;
        }
        public int CountElements()
        {
            count = objs.Count;
            return count;
        }
        public double MaxC()
        {
            List<double> temp = objs.ConvertAll(e => e.Condident);
            max_c = temp.Max();

            return max_c;
        }
        public double MaxS()
        {
            List<double> temp = objs.ConvertAll(e => e.S());
            max_s = temp.Max();

            return max_s;
        }
        public double AveC()
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += objs[i].Condident;
            }
            ave_c = sum / count;
            return ave_c;
        }
        public double AveS()
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += objs[i].S();
            }
            ave_s = sum / count;
            return ave_s;
        }

        public double SCoverage()
        {
            for (int i = 0; i < count; i++)
            {
                comm_S += objs[i].S();
            }

            return comm_S;
        }
        public double Xf()
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += objs[i].X;
            }
            xf = sum / count;
            return xf;
        }
        public double Yf()
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += objs[i].Y;
            }
            yf = sum / count;
            return yf;
        }
        public double Dx()
        {
            double part = 0;

            for (int i = 0; i < count; i++)
            {
                double t = xf - objs[i].X;
                double k = t * t;
                part += k;
            }
            xd = part / count;
            return xd;
        }
        public double Dy()
        {
            double part = 0;

            for (int i = 0; i < count; i++)
            {
                double t = yf - objs[i].Y;
                double k = t * t;
                part += k;
            }
            yd = part / count;
            return yd;
        }

        public Obj ConfObj()
        {
            obj_c = objs.Where(obj => obj.Condident == max_c).FirstOrDefault();

            return obj_c;
        }
        public Obj SObj()
        {
            obj_s = objs.Where(obj => obj.S() == max_s).FirstOrDefault();
            return obj_s;
        }
        public ClassAnalitik()
        {

        }
        public ClassAnalitik(List<Obj> o)
        {
            this.objs = o;
        }

    }
}
