using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    /// <summary>
    /// Klasa za definiranje podataka i funkcionalnosti tima studenata.
    /// </summary>
    public class Tim
    {
        #region Constructors

        public Tim()
        {

        }


        public Tim(DbDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["Id"].ToString());
                OznakaTima = dr["OznakaTima"].ToString();
                NazivProjekta = dr["NazivProjekta"].ToString();
                OpisProjekta = dr["OpisProjekta"].ToString();
                Napomena = dr["Napomena"].ToString();
            }
        }

        #endregion

        #region Private Fields

        private int id;
        private string oznakaTima;
        private string nazivProjekta;
        private string opisProjekta;
        private string napomena;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator tima.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Jedinstvena oznaka tima.
        /// </summary>
        public string OznakaTima
        {
            get
            {
                return oznakaTima;
            }
            set
            {
                if (oznakaTima != value)
                {
                    oznakaTima = value;
                }
            }
        }

        /// <summary>
        /// Naziv projekta kojeg je tim odabrao.
        /// </summary>
        public string NazivProjekta
        {
            get
            {
                return nazivProjekta;
            }
            set
            {
                if (nazivProjekta != value)
                {
                    nazivProjekta = value;
                }
            }
        }

        /// <summary>
        /// Detaljan opis projekta kojeg je tim odabrao.
        /// </summary>
        public string OpisProjekta
        {
            get
            {
                return opisProjekta;
            }
            set
            {
                if (opisProjekta != value)
                {
                    opisProjekta = value;
                }
            }
        }

        /// <summary>
        /// Dodatne opcionalne napomene o timu i projektu.
        /// </summary>
        public string Napomena
        {
            get
            {
                return napomena;
            }
            set
            {
                if (napomena != value)
                {
                    napomena = value;
                }
            }
        }

        #endregion

        #region Methods

        public int MetodaSpremi()
        {
            string SQLUpit = " ";
            if (Id == 0)
            {
                SQLUpit = "insert into Tim (Id, OznakaTima, NazivProjekta, OpisProjekta, Napomena) values (null, '" + OznakaTima + "','" + NazivProjekta + "','" + OpisProjekta + "','" + Napomena + "')";
            }
            else                
            {
                SQLUpit = "update Tim set OznakaTima = '" + OznakaTima + "',  NazivProjekta = '" + NazivProjekta + "' , OpisProjekta = '" + OpisProjekta + "', Napomena = '" + Napomena + "' WHERE Id = " + Id;
            }
            return DB.Instance.IzvrsiUpit(SQLUpit);
            }

        public int MetodaBrisi()
        {
            string SQLDel = "delete from Tim where Id = " + Id;
            return DB.Instance.IzvrsiUpit(SQLDel);
        }

        public static List<Tim> DohvatiTimove()
        {
            List<Tim> list = new List<Tim>();
            string SQLUpit = "select * from Tim";
            DbDataReader dr = DB.Instance.DohvatiDataReader(SQLUpit);
            while (dr.Read())
            {
                Tim tim = new Tim(dr);
                list.Add(tim);
            }
            dr.Close();
            return list;
        }

        public override string ToString()
        {
            return OznakaTima;
        }

        #endregion
    }
}
