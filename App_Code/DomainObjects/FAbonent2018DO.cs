using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using DAO;
using Entities;

namespace DomainObjects
{
    public class FAbonent2018DO:UniversalDO
    {
        void AddParametersToSqlCommand(FAbonent2018 ent, ref SqlCommand sc)
        {
            sc.Parameters.Add("@FirstName", ent.FirstName);
            sc.Parameters.Add("@Surname", ent.Surname);
            sc.Parameters.Add("@LastName", ent.LastName);
            sc.Parameters.Add("@Address", ent.Address);
            sc.Parameters.Add("@Phone", ent.Phone);
            sc.Parameters.Add("@NumberJournal", ent.NumberJournal);
            sc.Parameters.Add("@DistrictID", ent.DistrictID);
            sc.Parameters.Add("@NotPay", ent.NotPay);
        }

        void addParameters(FAbonent2018 ent)
        {
            AddParametersToSqlCommand(ent, ref sc);
        }

        public int CreateFAbonent(FAbonent2018 ent)
        {
            int createid = 0;
            FAbonent2018DAO entDAO = new FAbonent2018DAO();
            sc = new SqlCommand("CreateFAbonent2018");
            sc.CommandType = CommandType.StoredProcedure;
            addParameters(ent);
            createid = (entDAO.createEntity(sc));
            return createid;
        }

        /*public UniversalEntity RetrieveByOrderID(int id)
        {
            FAbonent2018DAO entDAO = new FAbonent2018DAO();
            sc = new SqlCommand("RetrieveFAbonentByOrderID2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@OrderID", id);
            return (entDAO.retrieveEntity(sc));
        }*/

        
        /*public UniversalEntity RetrieveByOrderID(int id)
        {
            FAbonent2018DAO entDAO = new FAbonent2018DAO();
            sc = new SqlCommand("RetrieveFAbonentByOrderID2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@OrderID", id);
            return (entDAO.retrieveEntity(sc));
        }*/

        public UniversalEntity RetrieveByOrder2018ID(int id)
        {
            FAbonent2018DAO entDAO = new FAbonent2018DAO();
            sc = new SqlCommand("RetrieveFAbonentByOrderID2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@OrderID", id);
            return (entDAO.retrieveEntity(sc));
        }
         
        

        public bool Delete(int FabonentID, int UserID)
        {
            bool success = true;
            FAbonent2018DAO entDAO = new FAbonent2018DAO();
            sc = new SqlCommand("DeleteFAbonent2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@UserID", UserID);
            sc.Parameters.Add("@FAbonentID", FabonentID);
            success = (entDAO.updateEntity(sc));
            return success;
        }

        public bool Update(FAbonent2018 ent, int UserID)
        {
            bool succes = true;
            FAbonent2018DAO entDAO = new FAbonent2018DAO();
            sc = new SqlCommand("UpdateFAbonent2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@FAbonentID", ent.ID);
            sc.Parameters.Add("@UserID", UserID);
            sc.Parameters.Add("@FirstName", ent.FirstName);
            sc.Parameters.Add("@Surname", ent.Surname);
            sc.Parameters.Add("@LastName", ent.LastName);
            sc.Parameters.Add("@DistrictID", ent.DistrictID);
            sc.Parameters.Add("@Phone", ent.Phone);
            sc.Parameters.Add("@Address", ent.Address);
            sc.Parameters.Add("@NotPay", ent.NotPay);
            sc.Parameters.Add("@NumberJournal", ent.NumberJournal);
            succes = (entDAO.updateEntity(sc));
            return succes;
        }
    }
}