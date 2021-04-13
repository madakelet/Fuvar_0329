using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar_0329
{
    class Fuvar
    {
        private int taxi_id;
        private string indulas;
        private int idotartam;
        private double tav;
        private double dij;
        private double borravalo;
        private string fizetes_modja;

        public Fuvar(string sor)
        {
            string[] s = sor.Split(';');
            this.taxi_id = int.Parse(s[0]);
            this.indulas = s[1];
            this.idotartam = int.Parse(s[2]);
            this.tav = Double.Parse(s[3]);
            this.dij = Double.Parse(s[4]);
            this.borravalo = Double.Parse(s[5]);
            this.fizetes_modja = s[6];
        }

        public int getId() { return taxi_id; }
        public double getDij() { return dij; }
        public double getBorravalo() { return borravalo; }
        public string getFizetesModja() { return fizetes_modja; }
        public double getTav() { return tav; }
        public int getIdotartam() { return idotartam; }
    }
}
