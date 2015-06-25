using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaiVoDich.Annotations;
using System.Windows.Input;
using System.Windows;
using QuanLyGiaiVoDich.Model;
using QuanLyGiaiVoDich.Model.tbModel;

namespace QuanLyGiaiVoDich.ViewModel
{
    public class DoiBongVM : ViewModelBase
    {
        #region  properties

        private string TENDOI;
        private string TENSAN;
        private int? SUCCHUA;
        private string DIACHI;

        public string Tendoi
        {
            get { return TENDOI; }
            set
            {
                if (TENDOI != value)
                {
                    TENDOI = value;
                    OnPropertyChanged("Tendoi");    
                }
                
            }
        }

        public string Tensan
        {
            get { return TENSAN; }
            set
            {
                if (TENSAN != value)
                {
                    TENSAN = value;
                    OnPropertyChanged("Tensan");
                }
            }
        }

        public int? Succhua
        {
            get { return SUCCHUA; }
            set
            {
                if (SUCCHUA != value)
                {
                    SUCCHUA = value;
                    OnPropertyChanged("Succhua");

                }
            }
        }

        public string Diachi
        {
            get { return DIACHI; }
            set
            {
                if (DIACHI != value)
                {
                    DIACHI = value;
                    OnPropertyChanged("Diachi");
                }
                
            }
        }

        private ICommand _XacnhanCmd;
        private ICommand _SuaCmd;
        private ICommand _XoaCmd;
        private ICommand _HuyCmd;
        public ObservableCollection<DoiBongSan> _DoiBongSan;
        public QuanLyGiaiVoDichDataContext _DataContext;
        private DOIBONG doibong;
        private SAN san;
        private DOIBONG_MUAGIAI doibongmuagiai;

        public SAN San
        {
            get { return san; }
            set { san = value; }
        }

        public DOIBONG_MUAGIAI Doibongmuagiai
        {
            get { return doibongmuagiai; }
            set { doibongmuagiai = value; }
        }

        public DOIBONG Doibong
        {
            get { return doibong; }
            set { doibong = value; }
        }

        public ObservableCollection<DoiBongSan> DoiBongSan
        {
            get { return _DoiBongSan; }
            set { _DoiBongSan = value; }
        }

        public QuanLyGiaiVoDichDataContext DataContext
        {
            get { return _DataContext; }
            set { _DataContext = value; }
        }


        public ICommand XacnhanCmd
        {
            get { return _XacnhanCmd; }
            set { _XacnhanCmd = value; }
        }

        public ICommand SuaCmd
        {
            get { return _SuaCmd; }
            set { _SuaCmd = value; }
        }

        public ICommand XoaCmd
        {
            get { return _XoaCmd; }
            set { _XoaCmd = value; }
        }

        public ICommand HuyCmd
        {
            get { return _HuyCmd; }
            set { _HuyCmd = value; }
        }

         

        #endregion

        

        private ObservableCollection<DoiBongSan> FillData()
        {
            var query = from element in DataContext.DOIBONG_MUAGIAI
                       join db in DataContext.DOIBONGs on element.MADOI equals db.MADOI
                       join s in DataContext.SANs on element.MASANNHA equals s.MASAN
                       select new
                       {
                           db,
                           s
                       };
            ObservableCollection<DoiBongSan> doiBongsan = new ObservableCollection<DoiBongSan>();
            
            foreach (var element in query.ToList())
            {
                doiBongsan.Add(new DoiBongSan(element.db.MADOI,element.db.TENDOI,element.s.MASAN,element.s.TENSAN,element.s.SUCCHUA,element.s.DIACHI));
            }
            return doiBongsan;
        }


        public DoiBongVM()
        {
            DataContext = new QuanLyGiaiVoDichDataContext();
            DoiBongSan = new ObservableCollection<DoiBongSan>(FillData());
            XacnhanCmd = new RelayCommand(new Action<object>(XacnhanCmd_Xuly) , new Predicate<object>(XacnhanCmd_Dieukien));
        }


        private void XacnhanCmd_Xuly(object obj)
        {
          
            MessageBox.Show("Ngon :))");
        }

        private bool XacnhanCmd_Dieukien(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
