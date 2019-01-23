using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DomainObjects;
using Entities;

namespace kipia_web_application
{
    public class FOrderDetails2018DO:UniversalDO
    {
        void AddParametersToSqlCommand(FOD2018 ent, ref SqlCommand sc)
        {
            sc.Parameters.Add("@FOrderID", ent.FOrderID);
            sc.Parameters.Add("@VodomerID", ent.VodomerID);
            sc.Parameters.Add("@StartValue", ent.StartValue);
            //sc.Parameters.Add("@EndValue", ent.EndValue);
            /*sc.Parameters.Add("@Price", ent.Price);
            sc.Parameters.Add("@PriceRub", ent.PriceRub);
            sc.Parameters.Add("@SpecialPrice", ent.SpecialPrice);*/
            sc.Parameters.Add("@DefectVodomer", ent.DefectVodomer);
        }

        void addParameters(FOD2018 ent)
        {
            AddParametersToSqlCommand(ent, ref sc);
        }

        public int CreateFOrderDetails(FOD2018 ent)
        {
            int createid = 0;
            FOrderDetails2018DAO entDAO = new FOrderDetails2018DAO();
            sc = new SqlCommand("CreateFOrderDetails2018");
            sc.CommandType = CommandType.StoredProcedure;
            addParameters(ent);
            createid = (entDAO.createEntity(sc));
            return createid;
        }

        public UniversalEntity RetrieveFOrderDetailsByOrderID(int id)
        {
            FOrderDetails2018DAO entDAO = new FOrderDetails2018DAO();
            sc = new SqlCommand("RetrieveFOrderDetailsByOrderID2018");
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add("@OrderID", id);
            return (entDAO.retrieveEntity(sc));
        }
    }
}