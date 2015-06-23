using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using QuanLyGiaiVoDich.Model;
using QuanLyGiaiVoDich.Model.tbModel;

namespace QuanLyGiaiVoDich.View
{
    /// <summary>
    /// Interaction logic for DoiBong.xaml
    /// </summary>
    public partial class DoiBong : UserControl
    {
        public DoiBong()
        {
            InitializeComponent();
            ObservableCollection<DoiBongSan> tbDoiBongSans = Get_DoiBong_San();
            DataGridDoi.ItemsSource = tbDoiBongSans;
        }

        QuanLyGiaiVoDichDataContext dataContext = new QuanLyGiaiVoDichDataContext();


        public ObservableCollection<DoiBongSan> Get_DoiBong_San()
        {
            
            ObservableCollection<DoiBongSan> ds = new ObservableCollection<DoiBongSan>();
            ds.Add(new DoiBongSan(1,1,"đội 1","mùa 1", 1,"sân 1",123,"bình"));       
            ds.Add(new DoiBongSan(2,1,"đội 1","mùa 1", 1,"sân 1",123,"bình"));       
            ds.Add(new DoiBongSan(3,1,"đội 1","mùa 1", 1,"sân 1",123,"bình"));       
            ds.Add(new DoiBongSan(4,1,"đội 1","mùa 1", 1,"sân 1",123,"bình"));       
            ds.Add(new DoiBongSan(5,1,"đội 1","mùa 1", 1,"sân 1",123,"bình"));       
            ds.Add(new DoiBongSan(6,1,"đội 1","mùa 1", 1,"sân 1",123,"bình"));       

            return ds;
        }

    }
}
