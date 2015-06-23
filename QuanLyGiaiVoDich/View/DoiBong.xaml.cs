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
            ObservableCollection<DOIBONG> db = laydoi();
            muagiai.DataContext = db;

        }

        QuanLyGiaiVoDichDataContext dataContext = new QuanLyGiaiVoDichDataContext();


        public ObservableCollection<DOIBONG> laydoi()
        {
            var quer = from s in dataContext.DOIBONGs
                       select s;
            ObservableCollection<DOIBONG> doibongs = new ObservableCollection<DOIBONG>();
            foreach (var VAr in quer)
            {
                doibongs.Add(VAr);
            }
            return doibongs;
        }

    }
}
