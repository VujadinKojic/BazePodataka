using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerBase;

namespace Client
{
    public class ServiceProvider
    {

        #region Procedure
        public int P_AIRPLANE_Remont(int id)
        {
            var P_Count = new SqlParameter("@P_COUNT", SqlDbType.Int);
            P_Count.Direction = ParameterDirection.Output;
            int retVal = -1;
            using (var db = new MilitaryAviationBaseContainer())
            {
                var query = db.Database.ExecuteSqlCommand("EXEC P_AIRPLANE_Remont @P_ID,@P_COUNT OUTPUT", new SqlParameter("@P_Id", id), P_Count);
                retVal =Int32.Parse(P_Count.Value.ToString());
            }

            return retVal;
        }

        public void P_INS_Radionica()
        {
            string ime;
            int brojMesta;
            using (var db = new MilitaryAviationBaseContainer())
            {
                Random generator = new Random();
                ime = "Radionica_Test";
                brojMesta = generator.Next(100);
                db.Database.SqlQuery<MilitaryAviationBaseContainer> ("EXEC P_INS_Radionica '" + ime + "'," + brojMesta + ";").ToList();
            }
        }


        #endregion


        #region Funkcije

        public int F_BEST_PILOT()
        {
            int broj;
            var return_value = new SqlParameter("@return_value", SqlDbType.NVarChar, 20);
            return_value.Direction = ParameterDirection.Output;
            using (var db = new MilitaryAviationBaseContainer())
            {
                var query = db.Database.ExecuteSqlCommand("EXEC @return_value = F_BEST_PILOT", return_value);
                broj = Int32.Parse(return_value.Value.ToString());
            }
            return broj;
        }

        public double F_LOVAC_NUMBER()
        {
            double broj;
            var return_value = new SqlParameter("@return_value", SqlDbType.NVarChar, 20);
            return_value.Direction = ParameterDirection.Output;

            using (var db = new MilitaryAviationBaseContainer())
            {
                var query = db.Database.ExecuteSqlCommand("EXEC @return_value = F_LOVAC_NUMBER", return_value);
                broj = Double.Parse(return_value.Value.ToString());
            }
            return broj;
        }


        #endregion



        #region Radionica
        public void AddRadionica(string imeRad, int bmRad)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {

                Radionica r = new Radionica()
                {
                    IME_RAD = imeRad,
                    BM_RAD = bmRad
                };

                db.Radionice.Add(r);
                db.SaveChanges();
            }
        }

        public void DeleteRadionica(int id)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                db.Radionice.Remove(db.Radionice.FirstOrDefault((s) => s.ID_RAD == id));

                ObservableCollection<AvioTehnicar> temp = GetAllAT();

                foreach (var at in temp)
                {
                    if (at.RadionicaID_RAD == id)
                    {
                        at.RadionicaID_RAD = -1;
                        UpdateAT(at);
                    }
                }

                db.SaveChanges();
            }
        }

        public void UpdateRadionica(Radionica r)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                var radionicaForDb = new Radionica()
                {
                    ID_RAD = r.ID_RAD,
                    BM_RAD = r.BM_RAD,
                    IME_RAD = r.IME_RAD
                };

                var radionicaFromDb = db.Radionice.FirstOrDefault((s) => s.ID_RAD == radionicaForDb.ID_RAD);
                db.Entry(radionicaFromDb).CurrentValues.SetValues(radionicaForDb);
                db.SaveChanges();
            }
        }

        public ObservableCollection<Radionica> GetAllRadionica()
        {
            var retVal = new ObservableCollection<Radionica>();
            using (var db = new MilitaryAviationBaseContainer())
            {
                foreach (var radionicaDb in db.Radionice.ToList())
                {
                    var radionica = new Radionica()
                    {
                       ID_RAD = radionicaDb.ID_RAD,
                       IME_RAD = radionicaDb.IME_RAD,
                       BM_RAD = radionicaDb.BM_RAD
                    };
                    retVal.Add(radionica);
                }
            }
            return retVal;
        }
        #endregion

        #region Eskadrila
        public void AddEskadrila(string imeEsk, string grbEsk)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {

                Eskadrila r = new Eskadrila()
                {
                    IME_ESK = imeEsk,
                    GRB_ESK = grbEsk
                };

                db.Eskadrile.Add(r);
                db.SaveChanges();
            }
        }

        public void DeleteEskadrila(int id)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                db.Eskadrile.Remove(db.Eskadrile.FirstOrDefault((s) => s.ID_ESK == id));

                ObservableCollection<AvioTehnicar> temp = GetAllAT();

                foreach (var at in temp)
                {
                    if (at.EskadrilaID_ESK == id)
                    {
                        at.EskadrilaID_ESK = -1;
                        UpdateAT(at);
                    }
                }

                ObservableCollection<Pilot> pilots = GetAllPilot();

                foreach (var pilot in pilots)
                {
                    if (pilot.EskadrilaID_ESK1 == id)
                    {
                        pilot.EskadrilaID_ESK1 = -1;
                        UpdatePilot(pilot);
                    }
                }

                db.SaveChanges();
            }
        }

        public void UpdateEskadrila(Eskadrila r)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                var eskadrilaForDb = new Eskadrila()
                {
                    ID_ESK = r.ID_ESK,
                    IME_ESK = r.IME_ESK,
                    GRB_ESK = r.GRB_ESK
                };

                var eskadrilaFromDb = db.Eskadrile.FirstOrDefault((s) => s.ID_ESK == eskadrilaForDb.ID_ESK);
                db.Entry(eskadrilaFromDb).CurrentValues.SetValues(eskadrilaForDb);
                db.SaveChanges();
            }
        }

        public ObservableCollection<Eskadrila> GetAllEskadrila()
        {
            var retVal = new ObservableCollection<Eskadrila>();
            using (var db = new MilitaryAviationBaseContainer())
            {
                foreach (var eskadrilaDb in db.Eskadrile.ToList())
                {
                    var eskadrila = new Eskadrila()
                    {
                        ID_ESK = eskadrilaDb.ID_ESK,
                        IME_ESK = eskadrilaDb.IME_ESK,
                        GRB_ESK = eskadrilaDb.GRB_ESK
                    };
                    retVal.Add(eskadrila);
                }
            }
            return retVal;
        }
        #endregion

        #region OZL
        public void AddOZL(string nacelnik, string adresa)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {

                OZL r = new OZL()
                {
                    NO_OZL = nacelnik,
                    ADR_OZL = adresa
                };

                db.OZLs.Add(r);
                db.SaveChanges();
            }
        }

        public void DeleteOZL(int id)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                db.OZLs.Remove(db.OZLs.FirstOrDefault((s) => s.ID_OZL == id));

                ObservableCollection<Pilot> pilots = GetAllPilot();

                foreach (var pilot in pilots)
                {
                    if (pilot.OZLID_OZL == id)
                    {
                        pilot.OZLID_OZL = -1;
                        UpdatePilot(pilot);
                    }
                }

                db.SaveChanges();
            }
        }

        public void UpdateOZL(OZL r)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                var OZLForDb = new OZL()
                {
                    ID_OZL = r.ID_OZL,
                    NO_OZL = r.NO_OZL,
                    ADR_OZL = r.ADR_OZL
                };

                var OZLFromDb = db.OZLs.FirstOrDefault((s) => s.ID_OZL == OZLForDb.ID_OZL);
                db.Entry(OZLFromDb).CurrentValues.SetValues(OZLForDb);
                db.SaveChanges();
            }
        }

        public ObservableCollection<OZL> GetAllOZL()
        {
            var retVal = new ObservableCollection<OZL>();
            using (var db = new MilitaryAviationBaseContainer())
            {
                foreach (var ozlDb in db.OZLs.ToList())
                {
                    var ozl = new OZL()
                    {
                        ID_OZL = ozlDb.ID_OZL,
                        NO_OZL = ozlDb.NO_OZL,
                        ADR_OZL = ozlDb.ADR_OZL
                    };
                    retVal.Add(ozl);
                }
            }
            return retVal;
        }
        #endregion

        #region OC
        public void AddOC(int brojBojevihGlava)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {

                OC r = new OC()
                {
                    BBG_OC = brojBojevihGlava
                };

                db.OCs.Add(r);
                db.SaveChanges();
            }
        }

        public void DeleteOC(int id)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                db.OCs.Remove(db.OCs.FirstOrDefault((s) => s.ID_OC == id));
                db.SaveChanges();
            }
        }

        public void UpdateOC(OC r)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                var OCForDb = new OC()
                {
                    ID_OC = r.ID_OC,
                    BBG_OC = r.BBG_OC
                };

                var OCFromDb = db.OCs.FirstOrDefault((s) => s.ID_OC == OCForDb.ID_OC);
                db.Entry(OCFromDb).CurrentValues.SetValues(OCForDb);
                db.SaveChanges();
            }
        }

        public ObservableCollection<OC> GetAllOC()
        {
            var retVal = new ObservableCollection<OC>();
            using (var db = new MilitaryAviationBaseContainer())
            {
                foreach (var ozlDb in db.OCs.ToList())
                {
                    var oc = new OC()
                    {
                        ID_OC = ozlDb.ID_OC,
                        BBG_OC = ozlDb.BBG_OC
                    };
                    retVal.Add(oc);
                }
            }
            return retVal;
        }
        #endregion

        #region Pilot
        public void AddPilot(string cin, int idEsk, int idAvion, int idOzl)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {

                Pilot r = new Pilot()
                {
                    RN_PIL = cin,
                };
                if(idEsk == -1)
                {
                    r.EskadrilaID_ESK1 = null;
                }
                else
                {
                    r.EskadrilaID_ESK1 = idEsk;
                }
                if(idAvion == -1)
                {
                    r.AvionID_AV = null;
                }
                else
                {
                    r.AvionID_AV = idAvion;
                }
                if(idOzl == -1)
                {
                    r.OZLID_OZL = null;
                }
                else
                {
                    r.OZLID_OZL = idOzl;
                }

                db.Pilots.Add(r);
                db.SaveChanges();
            }
        }

        public void DeletePilot(int id)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                db.Pilots.Remove(db.Pilots.FirstOrDefault((s) => s.ID_PIL == id));
                db.SaveChanges();
            }
        }

        public void UpdatePilot(Pilot r)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                Pilot pilotForDb = new Pilot()
                {
                    ID_PIL = r.ID_PIL,
                    RN_PIL = r.RN_PIL
                };
                if (r.EskadrilaID_ESK1 == -1)
                {
                    pilotForDb.EskadrilaID_ESK1 = null;
                }
                else
                {
                    pilotForDb.EskadrilaID_ESK1 = r.EskadrilaID_ESK1;
                }
                if (r.AvionID_AV == -1)
                {
                    pilotForDb.AvionID_AV = null;
                }
                else
                {
                    pilotForDb.AvionID_AV = r.AvionID_AV;
                }
                if (r.OZLID_OZL == -1)
                {
                    pilotForDb.OZLID_OZL = null;
                }
                else
                {
                    pilotForDb.OZLID_OZL = r.OZLID_OZL;
                }

                var pilotFromDb = db.Pilots.FirstOrDefault((s) => s.ID_PIL == pilotForDb.ID_PIL);
                db.Entry(pilotFromDb).CurrentValues.SetValues(pilotForDb);
                db.SaveChanges();
            }
        }

        public ObservableCollection<Pilot> GetAllPilot()
        {
            var retVal = new ObservableCollection<Pilot>();
            using (var db = new MilitaryAviationBaseContainer())
            {
                foreach (var pilotDb in db.Pilots.ToList())
                {
                    var pilot = new Pilot()
                    {
                        ID_PIL = pilotDb.ID_PIL,
                        RN_PIL = pilotDb.RN_PIL,
                        AvionID_AV = pilotDb.AvionID_AV,
                        OZLID_OZL = pilotDb.OZLID_OZL,
                        EskadrilaID_ESK1 = pilotDb.EskadrilaID_ESK1
                    };
                    retVal.Add(pilot);
                }
            }
            return retVal;
        }
        #endregion

        #region Avion
        public void AddAvion(int hPower, int fHours, string tipAv)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {

                Avion r = new Avion()
                {
                    HP_AV = hPower,
                    BL_AV = fHours.ToString(),
                    TIP_AV = tipAv == "Lovac" ? TIP_AV.Lovac : TIP_AV.Transportni

                };

                db.Avions.Add(r);
                db.SaveChanges();
            }
        }

        public void DeleteAvion(int id)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                db.Avions.Remove(db.Avions.FirstOrDefault((s) => s.ID_AV == id));

                ObservableCollection<Pilot> pilots = GetAllPilot();

                foreach (var pilot in pilots)
                {
                    if (pilot.AvionID_AV == id)
                    {
                        pilot.AvionID_AV = -1;
                        UpdatePilot(pilot);
                    }
                }

                db.SaveChanges();
            }
        }

        public void UpdateAvion(Avion r)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                var AvionForDb = new Avion()
                {
                    ID_AV = r.ID_AV,
                    HP_AV = r.HP_AV,
                    BL_AV = r.BL_AV,
                    TIP_AV = r.TIP_AV
                };

                var AvionFromDb = db.Avions.FirstOrDefault((s) => s.ID_AV == AvionForDb.ID_AV);
                db.Entry(AvionFromDb).CurrentValues.SetValues(AvionForDb);
                db.SaveChanges();
            }
        }

        public ObservableCollection<Avion> GetAllAvion()
        {
            var retVal = new ObservableCollection<Avion>();
            using (var db = new MilitaryAviationBaseContainer())
            {
                foreach (var avionDb in db.Avions.ToList())
                {
                    var avion = new Avion()
                    {
                        ID_AV = avionDb.ID_AV,
                        HP_AV = avionDb.HP_AV,
                        BL_AV = avionDb.BL_AV,
                        TIP_AV = avionDb.TIP_AV
                    };
                    retVal.Add(avion);
                }
            }
            return retVal;
        }

        #endregion

        #region AvioTehnicar
        public void AddAT(string ime, int godine, int radId, int eskId, string tip)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                var r = new AvioTehnicar()
                {
                    IME_AT = ime,
                    BG_AT = godine
                };

                if(tip == "ElektronskaOprema")
                {
                    r.TIP_AT = TIP_AT.ElektronskaOprema;
                }
                else if (tip == "VazduhoplovIMotor")
                {
                    r.TIP_AT = TIP_AT.VazduhoplovIMotor;
                }
                else
                {
                    r.TIP_AT = TIP_AT.ElektroOprema;
                } 

                if(radId == -1)
                {
                    r.RadionicaID_RAD = null;
                }
                else
                {
                    r.RadionicaID_RAD = radId;
                }

                if(eskId == -1)
                {
                    r.EskadrilaID_ESK = null;
                }
                else
                {
                    r.EskadrilaID_ESK = eskId;
                }

                db.AvioTehnicari.Add(r);
                db.SaveChanges();
            }
        }

        public void DeleteAT(int id)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                db.AvioTehnicari.Remove(db.AvioTehnicari.FirstOrDefault((s) => s.ID_AT == id));
                db.SaveChanges();
            }
        }

        public void UpdateAT(AvioTehnicar atDb)
        {
            using (var db = new MilitaryAviationBaseContainer())
            {
                var ATForDb = new AvioTehnicar()
                {
                    ID_AT = atDb.ID_AT,
                    IME_AT = atDb.IME_AT,
                    BG_AT = atDb.BG_AT,
                    RadionicaID_RAD = atDb.RadionicaID_RAD,
                    EskadrilaID_ESK = atDb.EskadrilaID_ESK,
                    TIP_AT = atDb.TIP_AT
                };

                if (ATForDb.RadionicaID_RAD == -1)
                {
                    ATForDb.RadionicaID_RAD = null;
                }

                if (ATForDb.EskadrilaID_ESK == -1)
                {
                    ATForDb.EskadrilaID_ESK = null;
                }

                var ATFromDb = db.AvioTehnicari.FirstOrDefault((s) => s.ID_AT == ATForDb.ID_AT);
                db.Entry(ATFromDb).CurrentValues.SetValues(ATForDb);
                db.SaveChanges();
            }
        }

        public ObservableCollection<AvioTehnicar> GetAllAT()
        {
            var retVal = new ObservableCollection<AvioTehnicar>();
            using (var db = new MilitaryAviationBaseContainer())
            {
                foreach (var atDb in db.AvioTehnicari.ToList())
                {
                    var avion = new AvioTehnicar()
                    {
                        ID_AT = atDb.ID_AT,
                        IME_AT = atDb.IME_AT,
                        BG_AT = atDb.BG_AT,
                        RadionicaID_RAD = atDb.RadionicaID_RAD,
                        EskadrilaID_ESK = atDb.EskadrilaID_ESK,
                        TIP_AT = atDb.TIP_AT
                    };
                    retVal.Add(avion);
                }
            }
            return retVal;
        }

        #endregion
    }
}
