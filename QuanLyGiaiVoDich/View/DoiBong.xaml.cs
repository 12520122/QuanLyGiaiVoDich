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
        QuanLyGiaiVoDichDataContext dataContext = new QuanLyGiaiVoDichDataContext();

        public DoiBong()
        {
            InitializeComponent();

            ObservableCollection<DoiBongSan> doiBongSans = FillData();

            DataGrid_DoiBongSan.ItemsSource = doiBongSans;

        }

        private ObservableCollection<DoiBongSan> FillData()
        {
            ObservableCollection<DoiBongSan> doiBongSans = new ObservableCollection<DoiBongSan>();
            List<DOIBONG> doibongs = GetDoiBong();
            List<SAN> sans = GetSan();
            
            for (int i = 0; i < doibongs.Count; i++)
            {
                doiBongSans.Add(new DoiBongSan(doibongs[i].MADOI,doibongs[i].TENDOI,sans[i].MASAN,sans[i].TENSAN,sans[i].SUCCHUA,sans[i].DIACHI));
            }
            

            return doiBongSans;
        }

        private List<DOIBONG> GetDoiBong()
        {
            return (from db in dataContext.DOIBONGs select db).ToList();
        }

        private List<SAN> GetSan()
        {
            return (from s in dataContext.SANs select s).ToList();
        }

        private void btn_Xacnhan(object sender, RoutedEventArgs e)
        {
            dataContext.DOIBONGs.Add(new DOIBONG() {TENDOI = txtTendoi.Text});
            dataContext.SANs.Add(new SAN()
            {
                TENSAN = txtTensan.Text.Trim(),
                SUCCHUA = int.Parse(txtSucchua.Text.Trim()),
                DIACHI = txtDiachi.Text.Trim()
            });
            dataContext.SaveChanges();
            MessageBox.Show("ngon");
        }

    }
}
