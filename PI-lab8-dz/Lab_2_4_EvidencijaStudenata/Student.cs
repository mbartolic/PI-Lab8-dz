using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    /// <summary>
    /// Klasa za definiranje podataka i funkcionalnosti studenta.
    /// </summary>
    public class Student
    {
        #region Constructors

        public Student()
        {

        }
        
        public Student(DbDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["Id"].ToString());
                Ime = dr["Ime"].ToString();
                Prezime = dr["Prezime"].ToString();
                Email = dr["Email"].ToString();
                Napomena = dr["Napomena"].ToString();
                string nesto = dr ["Odabranimodel"].ToString();
                OdabraniModel = nesto[0];
                string nesto2 = dr["Status"].ToString();
                Status = nesto2[0];

/*
 * Ovaj dio ovdje ne radi, jer ne znam na koji način da pretvorim objekt id tima u neki broj. Probao sam razne verzije ovog što je napisano dolje,
 * nisam uspio, probao sam u klasi NoviStudent staviti globalnu varijablu u koju bi spremio taj tim id kako bi nasljeđivanjem mogao onda ovdje koristiti,
 * ali ni to nije radilo, uvijek javlja grešku kod pretvaranja tipova podataka. Nakon 2 dana muke s tim, sad odustajem i predajem vam program bez tog 
 * dijela. Ostale funkcionalsti programa rade, osim tog ispisa kojem timu student pripada.
                
 *              Tim = dr["TimId"].ToString();
 *              Tim = Int32.Parse(dr["TimId"].ToString());
 *              
*/
            }
        }

        #endregion

        #region Private Fields

        private int id;
        private string ime;
        private string prezime;
        private char status;
        private char odabraniModel;
        private string email;
        private string napomena;
        private Tim tim;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator studenta.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Ime studenta.
        /// </summary>
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (ime != value)
                {
                    ime = value;
                }
            }
        }

        /// <summary>
        /// Prezime studenta.
        /// </summary>
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (prezime != value)
                {
                    prezime = value;
                }
            }
        }

        /// <summary>
        /// Status studenta (Izvanredni = I; Redoviti = R).
        /// </summary>
        public char Status
        {
            get
            {
                return status;
            }
            set
            {
                if (status != value)
                {
                    status = value;
                }
            }
        }

        /// <summary>
        /// Odabrani model praćenja (A ili B).
        /// </summary>
        public char OdabraniModel
        {
            get
            {
                return odabraniModel;
            }
            set
            {
                if (odabraniModel != value)
                {
                    odabraniModel = value;
                }
            }
        }

        /// <summary>
        /// Email studenta.
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    email = value;
                }
            }
        }

        /// <summary>
        /// Napomena o studentu.
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

        /// <summary>
        /// Tim kojem student pripada.
        /// </summary>
        public Tim Tim
        {
            get
            {
                return tim;
            }
            set
            {
                if (tim != value)
                {
                    tim = value;
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
                SQLUpit = "insert into Student (Id, Ime, Prezime, Status, OdabraniModel, Email, Napomena, TimId) values (null, '" + Ime + "','" + Prezime + "','" + Status + "','" + OdabraniModel + "','" + Email + "','" + Napomena + "','" + Tim.Id + "')";
            }
            else
            {
                SQLUpit = "update Student set Ime = '" + Ime + "',  Prezime = '" + Prezime + "', Status = '" + Status + "', OdabraniModel= '" + OdabraniModel + "', Email = '" + Email + "', Napomena = '" + Napomena + "' WHERE Id = " + Id;
            }
            return DB.Instance.IzvrsiUpit(SQLUpit);
        }

        public int MetodaBrisi()
        {
            string SQLDel = "delete from Student where Id = " + Id;
            return DB.Instance.IzvrsiUpit(SQLDel);
        }

        public static List<Student> DohvatiStudente()
        {
            List<Student> lista = new List<Student>();
            string upit = "select * from Student";
            DbDataReader dr = DB.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                Student student = new Student(dr);
                lista.Add(student);
            }
            dr.Close();
            return lista;
        }

        public override string ToString()
        {
            return Ime;
        }

        #endregion
    }
}
