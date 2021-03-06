﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DAO;
using Entities;

namespace kipia_web_application
{
    public class FOrderDetails2018DAO:UniversalDAO
    {
        public override UniversalEntity createEntity()
        {
            UniversalEntity ue = new UniversalEntity();
            while (!dr.Read())
            {
                FOD2018 ent = new FOD2018();
                ent = createEntityFromReader(dr);
                ue.Add(ent);
            }
            return ue;
        }

        public FOD2018 createEntityFromReader(SqlDataReader dr)
        {
            FOD2018 ent = new FOD2018();

            if (!dr.IsDBNull(dr.GetOrdinal("ID")))
                ent.ID = Convert.ToInt32(dr["ID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("FOrderID")))
                ent.FOrderID = Convert.ToInt32(dr["FOrderID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("VodomerID")))
                ent.VodomerID = Convert.ToInt32(dr["VodomerID"]);

            if (!dr.IsDBNull(dr.GetOrdinal("StartValue")))
                ent.StartValue = dr["StartValue"].ToString();

            if (!dr.IsDBNull(dr.GetOrdinal("EndValue")))
                ent.EndValue = dr["EndValue"].ToString();
            
            if (!dr.IsDBNull(dr.GetOrdinal("Price")))
                ent.Price = Convert.ToDouble(dr["Price"]);

            if (!dr.IsDBNull(dr.GetOrdinal("PriceRub")))
                ent.PriceRub = Convert.ToDouble(dr["PriceRub"]);

            if (!dr.IsDBNull(dr.GetOrdinal("SpecialPrice")))
                ent.SpecialPrice = Convert.ToDouble(dr["SpecialPrice"]);

            if (!dr.IsDBNull(dr.GetOrdinal("DefectVodomer")))
                ent.DefectVodomer = dr["DefetcVodomer"].ToString();
            
            return ent;
        }

        public UniversalEntity createEntity(SqlDataReader idr)
        {
            dr = idr;
            return createEntity();
        }
    }
}