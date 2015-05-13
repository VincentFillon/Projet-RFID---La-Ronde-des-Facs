using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MoreLinq;

namespace App_LaRondeDesFacs
{
    public class BorneClass
    {
        #region GetBorne
        public static List<Borne> getBorneByUserID(string id)
        {
            List<Borne> bornes = new List<Borne>();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var broneEntities = from b in facSecondaireEntity.Borne
                             where b.user_id == id
                             select b;
            bornes = broneEntities.OrderBy(b => b.nb_passage).ToList();
            return bornes;
        }
        public static Borne getPassageByNbPassage(string user_id, int nb_passage)
        {
            Borne borne = new Borne();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntity = from b in facSecondaireEntity.Borne
                              where b.user_id == user_id && b.nb_passage == nb_passage
                              select b;
            borne = borneEntity.FirstOrDefault();
            return borne;
        }
        public static Borne getLastNbPassageByUserID(string id)
        {
            Borne borne = new Borne();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntity = from b in facSecondaireEntity.Borne
                              where b.user_id == id
                              select b;
            borne = borneEntity.OrderByDescending(u => u.nb_passage).FirstOrDefault();
            return borne;
        }
        public static Borne getProblemBorneByUserID(string id)
        {
            Borne borne = new Borne();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntity = from b in facSecondaireEntity.Borne
                                where b.user_id == id && b.nb_passage == -1
                                select b;
            borne = borneEntity.FirstOrDefault();
            return borne;
        }
        public static Borne getAvertissementBorneByUserID(string id)
        {
            Borne borne = new Borne();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntity = from b in facSecondaireEntity.Borne
                              where b.user_id == id && b.nb_passage == -2
                              select b;
            borne = borneEntity.FirstOrDefault();
            return borne;
        }

        public static Boolean getExistBorne(string id)
        {
            Borne borne = new Borne();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntity = from b in facSecondaireEntity.Borne
                             where b.user_id == id
                             select b;
            borne = borneEntity.FirstOrDefault();
            if (borne != null) return true;
            else return false;
        }

        public static List<Borne> getAllListBorne()
        {
            List<Borne> listBornes = new List<Borne>();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntities = from b in facSecondaireEntity.Borne
                               select b;
            listBornes = borneEntities.OrderBy(b => b.user_id).ToList();
            return listBornes;
        }
        public static List<Borne> getNombreTourAllListBorne()
        {
            List<Borne> listBornes = new List<Borne>();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntities = facSecondaireEntity.classementNbTours2();
            foreach (classementNbTours2_Result borneResult in borneEntities)
            {
                Borne borne = new Borne();
                borne.borne_id = 0;
                borne.user_id = borneResult.user_id;
                borne.nb_passage = Convert.ToInt32(borneResult.nb_passage);
                borne.temps = new DateTime();
                listBornes.Add(borne);
            }
            return listBornes;
        }
        //public static List<Borne> getMeilleurTempAllListBorne()
        //{
        //    List<Borne> listBornes = new List<Borne>();
        //    FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
        //    var borneEntities = from b in facSecondaireEntity.Borne
        //                        where b.nb_passage != -1 || b.nb_passage != -2
        //                        select b;

            
        //    foreach (User user in UserClass.getAllListUsers())
        //    {
        //        if (getExistBorne(user.user_id))
        //        {
        //            List<Borne> TempsBornes = new List<Borne>();
        //            var borneUserEntities = borneEntities.Where(b=>b.user_id == user.user_id);

        //            foreach (Borne borneFirst in borneUserEntities.ToList())
        //            {
        //                if (borneFirst.nb_passage != getLastNbPassageByUserID(user.user_id).nb_passage)
        //                {
        //                    Borne borneNext = borneUserEntities.Where(b => b.nb_passage != borneFirst.nb_passage + 1).FirstOrDefault();
                            
        //                    Borne tempsBorne = new Borne();
        //                    int hF = borneFirst.temps.Second + borneFirst.temps.Minute * 60;
        //                    int hN = borneNext.temps.Second + borneNext.temps.Minute * 60;

        //                    tempsBorne.temps = Convert.ToDateTime(hN - hF);
        //                    TempsBornes.Add(tempsBorne);
        //                }
        //            }
        //            Borne meilleurTourBorne = TempsBornes.Sort(b => b.temps, 
        //        }
        //    }
        //    listBornes = borneEntities.OrderBy(b => b.nb_passage).ToList();
        //    return listBornes;
        //}
        public static List<Borne> getProblemAllListBorne()
        {
            List<Borne> listBornes = new List<Borne>();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntities = from b in facSecondaireEntity.Borne
                                where b.nb_passage == -1
                                select b;
            listBornes = borneEntities.OrderBy(b => b.nb_passage).ToList();
            return listBornes;
        }
        public static List<Borne> getAvertissementAllListBorne()
        {
            List<Borne> listBornes = new List<Borne>();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var borneEntities = from b in facSecondaireEntity.Borne
                                where b.nb_passage == -2
                                select b;
            listBornes = borneEntities.OrderBy(b => b.nb_passage).ToList();
            return listBornes;
        }
        #endregion

        #region SetBorne
        public static void setBorne(Borne borne)
        {
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            facSecondaireEntity.Borne.Add(borne);

            facSecondaireEntity.SaveChanges();
        }
        #endregion

        #region DeleteBorne
        public static void DeleteBorne(Borne borne)
        {
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            facSecondaireEntity.Borne.Remove(borne);
            facSecondaireEntity.SaveChanges();
        }
        public static void DeleteBornebyUserID(string id)
        {
            List<Borne> bornes = getBorneByUserID(id);
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            foreach (Borne borne in bornes)
            {
                facSecondaireEntity.Borne.Remove(borne);
                facSecondaireEntity.SaveChanges();
            }
        }
        #endregion
    }
}
