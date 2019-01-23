using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Entities;
using DAO;


namespace DomainObjects
{
    public class NewFOrderDO : UniversalDO
    {
        void AddParametersToSqlCommand(NewFOrder ent, ref SqlCommand sc)
        {
            sc.Parameters.Add("@FAbonentID", ent.FAbonentID);
            sc.Parameters.Add("@ActionType", ent.ActionType);
            sc.Parameters.Add("@UserID", ent.UserID);
        }
        void addParameters(NewFOrder ent)
        {
            AddParametersToSqlCommand(ent, ref sc);
        }
        public int Create(NewFOrder ent)
        {
            int createdid = 0;
            NewFOrderDAO entDAO = new NewFOrderDAO();
            sc = new SqlCommand("CreateFOrder2018");
            sc.CommandType = CommandType.StoredProcedure;
            addParameters(ent);
            createdid = entDAO.createEntity(sc);
            return createdid;
        }
        public bool UpdateFOrder(NewFOrder ent)
        {
            bool success = true;
            NewFOrderDAO entDAO = new NewFOrderDAO();
            sc = new SqlCommand("UpdateFOrder2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@ID", ent.ID);
            sc.Parameters.Add("@IsPaid", ent.IsPaid);
            sc.Parameters.Add("@DefectVodomer", ent.DefectVodomer);
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

        
        public UniversalEntity RetrieveFOrderById(int id)
        {
            NewFOrderDAO entDAO = new NewFOrderDAO();
            sc = new SqlCommand("RetrieveFOrderById2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@ID", id);
            return (entDAO.retrieveEntity(sc));
        }

        public UniversalEntity RetrieveFOrderAndVodomerID(int id)
        {
            FOrderDAO entDAO = new FOrderDAO();
            sc = new SqlCommand("RetrieveFOrderAndVodomerById");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@ID", id);
            return (entDAO.retrieveEntity(sc));
        }

        public UniversalEntity RetrieveFOAVID(int id)
        {
            FOrderDAO entDAO = new FOrderDAO();
            sc = new SqlCommand("RetrieveFAbonentByOrderByVodomerID");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@OrderID", id);
            return (entDAO.retrieveEntity(sc));
        }
        /*
        public UniversalEntity RetrieveFOrders()
        {
            FOrderDAO entDAO = new FOrderDAO();
            sc = new SqlCommand("RetrieveFOrders");
            sc.CommandType = CommandType.StoredProcedure;
            return (entDAO.retrieveEntity(sc));
        }
        public UniversalEntity RetrieveFOrdersByDiameter(int d)
        {
            FOrderDAO entDAO = new FOrderDAO();
            sc = new SqlCommand("RetrieveFOrdersByDiameter");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@Diameter", d);
            return (entDAO.retrieveEntity(sc));
        }*/
    }
}