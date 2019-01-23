using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DAO;
using Entities;

namespace DAO
{
    public class FOrder2018DAO:UniversalDAO
    {
        public override UniversalEntity createEntity()
        {
            UniversalEntity ue = new UniversalEntity();
            while (!dr.Read())
            {
                FOrder2018 ent = new FOrder2018();
                ent = createEntityFromReader(dr);
                ue.Add(ent);
            }

            return ue;
        }

        public FOrder2018 createEntityFromReader(SqlDataReader dr)
        {
            FOrder2018 ent = new FOrder2018();

            if (!dr.IsDBNull(dr.GetOrdinal("ID")))
                ent.ID = Convert.ToInt32(dr["ID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("FAbonentID")))
                ent.FAbonentID = Convert.ToInt32(dr["FAbonentID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("DateIn")))
                ent.DateIn = Convert.ToDateTime(dr["DateIn"]);

            if (!dr.IsDBNull(dr.GetOrdinal("DateOut")))
                ent.DateOut = Convert.ToDateTime(dr["DateOut"]);

            if (!dr.IsDBNull(dr.GetOrdinal("Comment")))
                ent.Comment = dr["Comment"].ToString();

            if (!dr.IsDBNull(dr.GetOrdinal("IsPaid")))
                ent.IsPaid = Convert.ToBoolean(dr["IsPaid"]);

            if (!dr.IsDBNull(dr.GetOrdinal("ActionType")))
                ent.ActionType = dr["ActionType"].ToString();

            if (!dr.IsDBNull(dr.GetOrdinal("PaymentDay")))
                ent.PaymentDay = Convert.ToDateTime(dr["PaymentDay"]);

            if (!dr.IsDBNull(dr.GetOrdinal("UserID")))
                ent.UserID = Convert.ToInt32(dr["UserID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("DefectVodomer")))
                ent.DefectVodmer = Convert.ToBoolean(dr["DefectVodomer"]);

            return ent;
        }

        public UniversalEntity createEntity(SqlDataReader idr)
        {
            dr = idr;
            return createEntity();
        }
    }
}