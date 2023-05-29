using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourse_NetFrameWork
{
    public partial class Practice06_08 : Form
    {
        public Practice06_08()
        {
            InitializeComponent();
        }

        private void Practice06_08_Load(object sender, EventArgs e)
        {
            Data<int> a = new Data<int>(3, 5, 2, 8, 7, 6);
            a.Sort();
            lblShow.Text = a.Display();
            Data<double> b = new Data<double>(3.5, 7.5, 2.1, 9.9, 5.4, 6.9);
            b.Sort();
            lblShow.Text += b.Display();
            Data<char> c = new Data<char>('b', '3', 'r', '-', 'F', 'O' );
            c.Sort();
            lblShow.Text += c.Display();

        }

        // 泛型类
        class Data<T> where T:struct
        {
            private T[] datas;
            public Data(params T[] x)
            {
                datas= x;
            }

            // 排序
            public void Sort()
            {
                for(int i = 0; i < datas.Length; i++)
                {
                    int k = i;
                    for(int j = i; j < datas.Length; j++)
                    {
                        if (Convert.ToDouble(datas[k]) < Convert.ToDouble(datas[j]))
                            k = j;
                    }
                    if(k != i)
                    {
                        T t = datas[i];
                        datas[i] = datas[k];
                        datas[k] = t;
                    }
                }
            }

            // 排序
            public string Display()
            {
                string info = "\n";
                for(int i = 0; i < datas.Length; i++)
                {
                    info += datas[i].ToString() + " ";
                }
                return info;
            }

            public T Max()
            {
                T max = datas[0];
                for(int i = 0; i < datas.Length; i++)
                {
                    if(Convert.ToDouble(max) < Convert.ToDouble(datas[i]))
                    {
                        max = datas[i];
                    }
                }
                return max;
            }

            public T Min()
            {
                T min = datas[0];
                for (int i = 0; i < datas.Length; i++)
                {
                    if (Convert.ToDouble(min) < Convert.ToDouble(datas[i]))
                    {
                        min = datas[i];
                    }
                }
                return min;
            }

            public T Mid()
            {
                int mid = datas.Length / 2;
                Data<T> ts = this;
                ts.Sort();
                T t = ts.datas[mid];
                return t;
            }

            public T Avg()
            {
                T sum = 0;
                foreach (var item in datas)
                {
                    sum += Convert.ToDouble(item);
                }
                sum /= datas.Length;
                return sum;
            }
        }
    }
}
