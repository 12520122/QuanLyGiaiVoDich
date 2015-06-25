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
        private QuanLyGiaiVoDichDataContext db;
        private ObservableCollection<DOIBONG> doi_bong;
        
        public DoiBong()
        {
            InitializeComponent();

        }

        //private ObservableCollection<DoiBongSan> FillData()
        //{
        //    List<DOIBONG> doibongs = GetDoiBong();
        //    List<SAN> sans = GetSan();
            
        //    for (int i = 0; i < doibongs.Count; i++)
        //    {
        //        doiBongSans.Add(new DoiBongSan(doibongs[i].MADOI,doibongs[i].TENDOI,sans[i].MASAN,sans[i].TENSAN,sans[i].SUCCHUA,sans[i].DIACHI));
        //    }
            

        //    return doiBongSans;
        //}

        //private List<DOIBONG> GetDoiBong()
        //{
        //    using (var dataContext_Temp = new QuanLyGiaiVoDichDataContext())
        //    {
        //        return dataContext_Temp.DOIBONGs.ToList();
        //    }
        //}

        //private List<SAN> GetSan()
        //{
        //    using(var dataContext_Temp = new QuanLyGiaiVoDichDataContext())
        //    {
        //        return dataContext_Temp.SANs.ToList();
        //    }
        //}


        //private void btn_Xacnhan_Click(object sender, RoutedEventArgs e)
        //{
        //    //dataContext.DOIBONGs.Add(new DOIBONG() { TENDOI = txtTendoi.Text });
        //    //dataContext.SANs.Add(new SAN()
        //    //{
        //    //    TENSAN = txtTensan.Text.Trim(),
        //    //    SUCCHUA = int.Parse(txtSucchua.Text.Trim()),
        //    //    DIACHI = txtDiachi.Text.Trim()
        //    //});
        //    //dataContext.SaveChanges();
        //    //MessageBox.Show("ngon");
        //    //doiBongSans = FillData();
        //    //DataGrid_DoiBongSan.ItemsSource = doiBongSans;
        //}

        //private void btn_Sua_Click(object sender, RoutedEventArgs e)
        //{
            
        //    //DoiBongSan doiBongSan = (DoiBongSan)DataGrid_DoiBongSan.SelectedItem;
        //    //txtTendoi.Text = doiBongSan.TENDOI;
        //}

        //private void DataGrid_DoiBongSan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //DoiBongSan doiBongSan = (DoiBongSan)DataGrid_DoiBongSan.SelectedItem;
        //    //txtTendoi.Text = doiBongSan.TENDOI;
        //}

      

    }
}
