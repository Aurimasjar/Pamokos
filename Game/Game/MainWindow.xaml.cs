using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Shape> etapai;
        string zodis;
        int zingsnis;
        string speta;
        bool baigtas;

        public MainWindow()
        {
            InitializeComponent();
            paruosti();
        }

        private void slepimas()
        {
            foreach (var item in etapai)
            {
                item.Visibility = Visibility.Hidden;
            }
        }

        private void paruosti()
        {
            etapai = new List<Shape>();
            zodis = "etapas";
            zingsnis = 0;
            baigtas = false;

            speta = "";
            for (int i = 0; i < zodis.Length; i++)
            {
                speta += "_";
            }
            textBlock.Text = speta;

            etapai.Add(rct1);
            etapai.Add(rct2);
            etapai.Add(virve);
            etapai.Add(galva);
            etapai.Add(kunas);
            etapai.Add(ranka1);
            etapai.Add(ranka2);
            etapai.Add(koja1);
            etapai.Add(koja2);

            slepimas();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!baigtas)
            {
                if (zingsnis < 9)
                {
                    if (!string.IsNullOrWhiteSpace(textBox.Text))
                    {

                        if (!speta.Contains(textBox.Text))
                        {
                            if (!zodis.Contains(textBox.Text))
                            {
                                etapai[zingsnis].Visibility = Visibility.Visible;
                                zingsnis++;
                            }
                            else
                            {
                                string naujas = "";
                                for (int i = 0; i < zodis.Length; i++)
                                {
                                    if (textBox.Text == zodis[i].ToString())
                                    {
                                        naujas += textBox.Text;
                                    }
                                    else
                                    {
                                        naujas += speta[i];
                                    }
                                }
                                speta = naujas;
                                textBlock.Text = speta;
                                if (speta == zodis)
                                {
                                    MessageBox.Show("Laimėjai :)");
                                    baigtas = true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tokia raidė jau spėta");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pralaimėjai :(");
                    baigtas = true;
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            paruosti();
        }
    }
}
