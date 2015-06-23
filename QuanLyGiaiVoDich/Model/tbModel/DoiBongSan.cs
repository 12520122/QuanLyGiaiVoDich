using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaiVoDich.Annotations;

namespace QuanLyGiaiVoDich.Model.tbModel
{
    public class DoiBongSan : INotifyPropertyChanged
    {
        public int MADOI;
        public string TENDOI;
        public int MASAN;
        public string TENSAN;
        public int? SUCCHUA;
        public string DIACHI;

        public int? Succhua
        {
            get { return SUCCHUA; }
            set
            {
                if (value == SUCCHUA) return;
                SUCCHUA = value;
                OnPropertyChanged();
            }
        }

        public int Madoi
        {
            get { return MADOI; }
            set
            {
                if (value == MADOI) return;
                MADOI = value;
                OnPropertyChanged();
            }
        }

        public string Tendoi
        {
            get { return TENDOI; }
            set
            {
                if (value == TENDOI) return;
                TENDOI = value;
                OnPropertyChanged();
            }
        }

        public int Masan
        {
            get { return MASAN; }
            set
            {
                if (value == MASAN) return;
                MASAN = value;
                OnPropertyChanged();
            }
        }

        public string Tensan
        {
            get { return TENSAN; }
            set
            {
                if (value == TENSAN) return;
                TENSAN = value;
                OnPropertyChanged();
            }
        }

      

        public string Diachi
        {
            get { return DIACHI; }
            set
            {
                if (value == DIACHI) return;
                DIACHI = value;
                OnPropertyChanged();
            }
        }

        public DoiBongSan(int madoi, string tendoi, int masan, string tensan, int? succhua, string diachi)
        {
            MADOI = madoi;
            TENDOI = tendoi;
            MASAN = masan;
            TENSAN = tensan;
            DIACHI = diachi;
            SUCCHUA = succhua;

        }

        public DoiBongSan() { }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
