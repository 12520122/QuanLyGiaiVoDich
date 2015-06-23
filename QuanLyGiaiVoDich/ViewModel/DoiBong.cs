using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaiVoDich.Model;

namespace QuanLyGiaiVoDich.ViewModel
{
    class DoiBong
    {
        QuanLyGiaiVoDichDataContext dataContext = new QuanLyGiaiVoDichDataContext();
        private ObservableCollection<DOIBONG> db;

  
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

        public void laysan()
        {
            var quer = from s in dataContext.SANs
                select s;

        }
    }
}
