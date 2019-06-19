using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansalTablolarAnalizi.Fonksiyonlar
{
    class Formlar
    {
        public void DonenVarliklar(bool Ac = false)
        {
            Modul_Bilanco.frm_Donenvarliklar frm = new Modul_Bilanco.frm_Donenvarliklar();
            frm.ShowDialog();
   
        }
    }
}
