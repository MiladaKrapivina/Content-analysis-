namespace Analitik
{

    public class Obj
    {
        private int n;// номер класса
        private double x;// координаты
        private double y;
        private double h;// высота
        private double w; //ширина
        private double c;// конфиденс       
        private string file;
        private int str;//
        private double s;// площадь
        private string id;// идентификация объекта

        public int ClassNumber
        {
            get
            {
                return n;    
            }
            set
            {
                n = value;   
            }
        }
        public double X
        {
            get
            {
                return x;    
            }
            set
            {
                x = value;   
            }
        }
        public double Y
        {
            get
            {
                return y;    
            }
            set
            {
                y = value;   
            }
        }
        public double H
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }
        public double W
        {
            get
            {
                return w;    
            }
            set
            {
                w = value;   
            }
        }
        public double Condident
        {
            get
            {
                return c;   
            }
            set
            {
                c = value;   
            }
        }
        public double S()
        {
            this.CulcS();
            return s;

        }
        private void CulcS()
        {
            s = this.h * this.w;
        }
        public string FromFile
        {
            get
            {
                return file;    
            }
            set
            {
                file = value; 
            }
        }
        public int NFile
        {
            get
            {
                return str;   
            }
            set
            {
                str = value; 
            }
        }
        private void ConfigID()
        {
            id = this.file + this.str.ToString();
        }
        public string ID()
        {
            this.ConfigID();
            return id;    

        }

    }
}

