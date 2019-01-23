using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DAO;
using Entities;
using NPOI.SS.Formula.Functions;


namespace DomainObjects
{
    public class FOrder2018DO:UniversalDO
    {
        void AddParametersToSqlCommand(FOrder2018 ent, ref SqlCommand sc)
        {
            sc.Parameters.Add("@FAbonentID", ent.FAbonentID);
            //sc.Parameters.Add("@DateIn", ent.DateIn);
            //sc.Parameters.Add("@DateOut", ent.DateOut);
            //sc.Parameters.Add("@Comment", ent.Comment);
            //sc.Parameters.Add("@IsPaid", ent.IsPaid);
            sc.Parameters.Add("@ActionType", ent.ActionType);
            //sc.Parameters.Add("@PaymentDay", ent.PaymentDay);
            sc.Parameters.Add("@UserID", ent.UserID);
            //sc.Parameters.Add("@DefectVodomer", ent.DefectVodmer);
        }

        void addParameters(FOrder2018 ent)
        {
            AddParametersToSqlCommand(ent, ref sc);
        }

        public int CreateFOrder(FOrder2018 ent)
        {
            int createid = 0;
            FOrder2018DAO entDAO = new FOrder2018DAO();
            sc = new SqlCommand("CreateFOrder2018");
            sc.CommandType = CommandType.StoredProcedure;
            addParameters(ent);
            createid = (entDAO.createEntity(sc));
            return createid;
        }

       /* public UniversalEntity RetrieveFOrderById(int id)
        {
            FOrder2018DAO entDAO = new FOrder2018DAO();
            sc = new SqlCommand("RetrieveFOrderById");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@ID", id);
            return (entDAO.retrieveEntity(sc));
        }*/

        
        public UniversalEntity RetrieveFOrderById(int id)
        {
            FOrder2018DAO entDAO = new FOrder2018DAO();
            sc = new SqlCommand("RetrieveFOrderById2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@ID", id);
            return (entDAO.retrieveEntity(sc));
        }
         
         

        public bool UpdateFOrder(FOrder2018 ent)
        {
            /*bool success = true;
            FOrder2018DAO entDAO = new FOrder2018DAO();
            sc = new SqlCommand("UpdateFOrder2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@DefectVodomer", ent.DefectVodmer);
            sc.Parameters.Add("@UserID", ent.UserID);
            sc.Parameters.Add("@IsPaid", ent.IsPaid);
            if (ent.DateOut == null)
            {
                sc.Parameters.Add("@DateOut", DBNull.Value);
            }
            else
            {
                sc.Parameters.Add("@DateOut", ent.DateOut);
            }
            if (ent.PaymentDay == null)
            {
                sc.Parameters.Add("@PaymentDay", DBNull.Value);
            }
            else
            {
                sc.Parameters.Add("@PaymentDay", ent.PaymentDay);
            }
            success = (entDAO.updateEntity(sc));
            return success;*/

            
            bool success = true;
            FOrder2018DAO entDAO = new FOrder2018DAO();
            sc = new SqlCommand("UpdateFOrder2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@ID", ent.ID);
            sc.Parameters.Add("@IsPaid", ent.IsPaid);
            sc.Parameters.Add("@DefectVodomer", ent.DefectVodmer);
            sc.Parameters.Add("@UserID", ent.UserID);
            if (ent.DateOut == null)
            {
                sc.Parameters.Add("@DateOut", DBNull.Value);
            }
            else
            {
                sc.Parameters.Add("@DateOut", ent.DateOut);
            }
            if (ent.PaymentDay == null)
            {
                sc.Parameters.Add("@PaymentDay", DBNull.Value);
            }
            else
            {
                sc.Parameters.Add("@PaymentDay", ent.PaymentDay.Value);
            }
            //addParameters(ent);
            success = entDAO.updateEntity(sc);
            return success;
             
             
             
        }
    }
}