using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Analitik
{
    public struct ResClassStruct
    {
        // номер класса
        public int class_num;
        // количество объектов
        public int count;
        // максимальные значения конфидента и площади
        public double max_c;
        public double max_s;
        // средние значения конфидента и площади
        public double ave_c;
        public double ave_s;
        //  площадь покрытия
        public double comm_S;
        // кооринаты центра масс
        public double xf;
        public double yf;
        // Дисперсия
        public double xd;
        public double yd;
        // объект с наибольшим конфидентом
        public Obj obj_c;
        // объект с наибольшей площадью
        public Obj obj_s;

    }

    public struct Rec_obj
    {
        // номер класса
        public int n;
        // координаты
        public double x;
        public double y;
        // высота
        public double h;
        //ширина
        public double w;
        // конфиденс
        public double c;
        // площадь
        public double S;
        // идентификация объекта
        public string id;
    }


    public partial class Form1 : Form
    {

        #region переменные 
        public const int CLASS_COUNT = 7;
        string FilePath; // папка с данными
        string SavePath;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        private void Button_open_dir_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                inputdir.Text = fbd.SelectedPath;
            }
        }

        private void Button_save_dir_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                outputdir.Text = fbd.SelectedPath;
            }
            SavePath = outputdir.Text;
        }

        bool Check_input()
        {
            if (string.IsNullOrEmpty(inputdir.Text))
            {
                return false;
            }

            FilePath = inputdir.Text;

            if (string.IsNullOrEmpty(outputdir.Text))
            {
                SavePath = FilePath;
                outputdir.Text = SavePath;
            }
            else
            {
                outputdir.Text = SavePath;
            }
            return true;
        }

        

        Writer Config_report()
        {

            Writer report = new Writer(SaveFile(), FilePath);
            return report;
        }
        string SaveFile()
        {
            var dir = new DirectoryInfo(FilePath);
            string temp = SavePath + "//" + dir.Name + "_report.txt";
            return temp;

        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            if (Check_input())
            {
                listBox1.Items.Clear();

                Writer report = Config_report();


                DirAnaliz dirAnaliz = new DirAnaliz(FilePath);
                ListsHelper listsHelper = new ListsHelper(dirAnaliz.ListFileNames(), dirAnaliz.ChPath());
                List<Obj> t = new List<Obj>();
                var dir = new DirectoryInfo(FilePath);

                listBox1.Enabled = false;
                listBox1.Visible = false;

                if (dirAnaliz.IsOne())
                {

                    report.Write("Тип: единственный файл");
                    report.Write("PATH ID: " + dir.Name);

                    for (int i = 0; i < CLASS_COUNT; i++)
                    {
                        t = listsHelper.ByClass(i);
                        if (t.Count >= 1)
                        {
                            ClassAnalitik d = new ClassAnalitik(t);
                            ResClassStruct res = new ResClassStruct();
                            res = d.GetRes();

                            pictureBox1.Image = Image.FromFile(report.GetImgName(res.obj_c.FromFile));
                            report.ReSClass(res);
                        }

                    }

                }
                else
                {
                    listBox1.Enabled = true;
                    listBox1.Visible = true;

                    report.Write("Тип: множество файлов");
                    report.Write("PATH ID: " + dir.Name);

                    List<Obj> all = new List<Obj>();
                    ListsHelper list = new ListsHelper(dirAnaliz.ListFileNames(), dirAnaliz.ChPath());
                    all = list.GetAllObjects();
                    ClassAnalitik all_an = new ClassAnalitik(all);

                    ResClassStruct temp = new ResClassStruct();
                    temp = all_an.GetRes();
                    report.ResMultyFile(temp);

                    for (int i = 0; i < CLASS_COUNT; i++)
                    {
                        t = listsHelper.ByClass(i);
                        if (t.Count >= 1)
                        {
                            ClassAnalitik d = new ClassAnalitik(t);
                            ResClassStruct res = new ResClassStruct();
                            res = d.GetRes();
                            report.Files = true;
                            report.ReSClass(res);

                            listBox1.Items.Add(report.GetImgName(res.obj_c.FromFile));
                            listBox1.Items.Add(report.GetImgName(res.obj_s.FromFile));

                        }

                    }





                }
                report.Cl();
                view.Text = File.ReadAllText(SaveFile());
                return;

            }



            return;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(listBox1.Text);
        }
    }
}
