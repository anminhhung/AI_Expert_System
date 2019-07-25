using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    class SuKien
    {
        String maSuKien;

        public String MaSuKien
        {
            get { return maSuKien; }
            set { maSuKien = value; }
        }

        String motaSuKien;
        public String MotaSuKien
        {
            get { return motaSuKien; }
            set { motaSuKien = value; }
        }

        public String LoaiSuKien { get; set; }
    }
}
