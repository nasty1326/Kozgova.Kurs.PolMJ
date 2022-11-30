using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kozgova.Kurs.PolMJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double min0Pol; // максимальное значение выживаемости (близость к ответу)
        double sredPol; // среднее значение выживаемости
        int numberGenPol; // число поколений
        int numberPopPol; // размер популяции
        int numberTurnPol; // размер турнира 
        double pcrossPol; // вероятность скрещивания
        double pmutationPol; // вероятность мутации
        int genNowPol; // текущее поколение
        int sizeNewPol; // число популяции после скрещивания

        const int lchrom = 2; // число генов
        const int maxpop = 500; // максимальный размер популяции
        const double xmax = 2;
        const double xmin = 0;

        public double[] maxmass;
        public double[] sredmass;

        public class individualPol //особь без пола
        {
            public bool pol;
            public double[] chrom { get; set; } = new double[lchrom];
            public double fitness { get; set; }  // коэффициент выживаемости (значение функции) 
            public individualPol()
            {
                pol = false;
                for (int i = 0; i < lchrom; i++)
                {
                    chrom[i] = -1;
                }
                fitness = -1;
            }
        }

        // Создаем массивы для беcполового скрещивания
        individualPol[] oldpopPol = new individualPol[maxpop]; // массив для старого поколения полового скрещивания
        individualPol[] newpopPol = new individualPol[maxpop]; // массив для нового поколения полового скрещивания
        individualPol[] intpopPol = new individualPol[maxpop]; // массив для сортировки поколения для полового скрещивания

        //основная функция 
        double objfunc(double x1, double x2)
        {
            return x1 * x1 + x2 * x2;
        }

        public void initpopPol()
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < numberPopPol; i++)
            {
                k = rnd.NextDouble();
                if (k < 0.5)
                {
                    oldpopPol[i].pol = false; //мальчик
                }
                else
                {
                    oldpopPol[i].pol = true; //девочка
                }

                oldpopPol[i].chrom[0] = 0 + rnd.NextDouble() * 2;
                oldpopPol[i].chrom[1] = 0 + rnd.NextDouble() * 2;
                oldpopPol[i].fitness = objfunc(oldpopPol[i].chrom[0], oldpopPol[i].chrom[1]);
            }
        }

        public void statisticsPol(individualPol[] pop)
        {
            min0Pol = pop[0].fitness;
            sredPol = pop[0].fitness;
            for (int i = 1; i < sizeNewPol; i++)
            {
                sredPol += pop[i].fitness;
                if (pop[i].fitness < min0Pol)
                {
                    min0Pol = pop[i].fitness;
                }
            }
            sredPol = sredPol / sizeNewPol;
            chart1.Series[0].Points.AddXY(genNowPol, min0Pol);
            chart1.Series[1].Points.AddXY(genNowPol, sredPol);
            maxmass[genNowPol-1]=min0Pol;
            sredmass[genNowPol-1]=sredPol;
        }

        public void selectPol()
        {
            int k;
            Random rnd = new Random();
            individualPol BestIndivid;

            individualPol[] polMan = new individualPol[sizeNewPol];
            individualPol[] polWoman = new individualPol[sizeNewPol];
            int jM = 0; //счетчик мужчин
            int jW = 0; //счетчик женщин

            for (int i = 0; i < sizeNewPol; i++)
            {
                if (oldpopPol[i].pol)
                {
                    polWoman[jW] = oldpopPol[i];
                    jW += 1;
                }
                else
                {
                    polMan[jM] = oldpopPol[i];
                    jM += 1;
                }
            }

            int l = 0;
            
            for (int i = 0; i < jW; i++)
            {
                k = rnd.Next(0, jM - 1);                
                BestIndivid = polMan[k];
                for (int j = 1; j < numberTurnPol; j++)
                {
                    k = rnd.Next(0, jM - 1);                    
                    if (polMan[k].fitness < BestIndivid.fitness)
                    {
                        BestIndivid = polMan[k];
                    }
                }
                intpopPol[l] = polWoman[i];
                intpopPol[l + 1] = BestIndivid;
                l += 2;
            }
            sizeNewPol = l - 1;
        }

        public double mutation(double fit)
        {
            Random rnd = new Random();
            double p = rnd.NextDouble();
            double j=0;
            if (p < pmutationPol)
            {
                fit = fit - (rnd.NextDouble() / 20);
               
            }
            
            return fit;
        }

        public void crossoverPol()
        {
            double p = 0;
            double per1;
            double p1,p2;
            Random rnd = new Random();
            for (int i = 0; i <= sizeNewPol; i += 2)
            {
                per1 = rnd.NextDouble();
                p1 = rnd.NextDouble();
                p2 = rnd.NextDouble();
                p = rnd.NextDouble();
                individualPol c1 = new individualPol();
                individualPol c2 = new individualPol();

                if (p < pcrossPol)
                {
                    if (p1 < 0.5)
                    {
                        c1.pol = false;
                    }
                    else
                    {
                        c1.pol = true;
                    }
                    c1.chrom[0] = (1 - per1) * intpopPol[i].chrom[0] + per1 * intpopPol[i + 1].chrom[0];
                    c1.chrom[1] = (1 - per1) * intpopPol[i].chrom[1] + per1 * intpopPol[i + 1].chrom[1];
                    c1.fitness = objfunc(newpopPol[i].chrom[0], newpopPol[i].chrom[1]);

                    if (p1 < 0.5)
                    {
                        c2.pol = false;
                    }
                    else
                    {
                        c2.pol = true;
                    }

                    c2.chrom[0] = mutation((1 - per1) * intpopPol[i + 1].chrom[0]) + mutation(per1 * intpopPol[i].chrom[0]);
                    c2.chrom[1] = mutation((1 - per1) * intpopPol[i + 1].chrom[1]) + mutation(per1 * intpopPol[i].chrom[1]);
                    c2.fitness = objfunc(newpopPol[i + 1].chrom[0], newpopPol[i + 1].chrom[1]);

                    if (c1.pol) // если первый ребенок девочка
                    {
                        if (intpopPol[i].fitness > c1.fitness) // если 1 ребенок-девочка хуже матери
                        {
                            intpopPol[i] = c1;
                        }
                    }
                    else // если первый ребенок мальчик 
                    {
                        if (intpopPol[i+1].fitness > c1.fitness) // если 1 ребенок-мальчик хуже отца
                        {
                            intpopPol[i+1] = c1;
                        }
                    }

                    if (c2.pol) // если второй ребенок девочка
                    {
                        if (intpopPol[i].fitness > c2.fitness) // если 2 ребенок-девочка хуже матери
                        {
                            intpopPol[i] = c2;
                        }
                    }
                    else // если второй ребенок мальчик 
                    {
                        if (intpopPol[i + 1].fitness > c2.fitness) // если 2 ребенок-мальчик хуже отца
                        {
                            intpopPol[i + 1] = c2;
                        }
                    }
                    newpopPol[i] = intpopPol[i];
                    newpopPol[i + 1] = intpopPol[i + 1];

                }
                else
                {
                    newpopPol[i] = intpopPol[i];
                    newpopPol[i+1] = intpopPol[i + 1];
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < maxpop; i++)
            {
                oldpopPol[i] = new individualPol();//старое поколение популяции
                newpopPol[i] = new individualPol();// новое поколение популяции
                intpopPol[i] = new individualPol();// полонение для сортировки 
            }

            numberGenPol = (int)numGen.Value;
            numberPopPol = (int)numPop.Value;
            numberTurnPol = (int)numTurn.Value;
            pcrossPol = (double)numCross.Value;
            pmutationPol = (double)numMut.Value;
            sizeNewPol = numberPopPol;

            initpopPol(); //создаем первое поколение популяции
            
            genNowPol = 1;
            maxmass=new double[numberGenPol];
            sredmass=new double[numberPopPol];
            statisticsPol(oldpopPol);

            do
            {
                genNowPol++;

                selectPol();
                Console.WriteLine("Поколение после сортировки");
                
                crossoverPol();
                Console.WriteLine("Поколение новое");
                for (int k = 0; k < sizeNewPol; k++)
                {
                   // Console.WriteLine(newpopPol[k].chrom[0]);
                   // Console.WriteLine(newpopPol[k].chrom[1]);
                    Console.WriteLine(newpopPol[k].fitness);
                   // Console.WriteLine(" ");
                }
                statisticsPol(newpopPol); // находим больший коэффициент выживаемости у поколения

                for (int i = 0; i < maxpop; i++) // новое поколение превращаем в старое 
                { oldpopPol[i] = newpopPol[i]; }
                

            } while (genNowPol < numberGenPol); // сколько раз было задано 

            double v = 10000;
            for (int i=0; i<genNowPol-1; i++)
            {
                if (maxmass[i] < v)
                {
                    v=maxmass[i];
                }
            }

            label2.Text = v.ToString();

        }
    }
}
